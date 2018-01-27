﻿using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Provider;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using Java.IO;
using Newtonsoft.Json;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using static Android.Provider.MediaStore.Images;

namespace WorklabsMx.Droid
{
    public partial class MainActivity
    {
        View customView;
        File _file, _dir;
        readonly int sizePage = 10, PickImageId = 1000, TakePicture = 500;
        Bitmap bitmap;
        AlertDialog dialog;
        string imgPublish, imagePath;
        void ShowPerfilCard(MiembroModel miembro)
        {
            Intent intent = new Intent(this, typeof(PerfilCardActivity));
            intent.PutExtra("Miembro", JsonConvert.SerializeObject(miembro));
            StartActivity(intent);
        }

        public void ShowPublish()
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            customView = liView.Inflate(Resource.Layout.PublishLayout, null, true);

            customView.FindViewById<TextView>(Resource.Id.lblNombre).Text = nombre;
            customView.FindViewById<TextView>(Resource.Id.lblPuesto).Text = puesto;
            customView.FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Now.ToString("d");
            customView.FindViewById<ImageButton>(Resource.Id.imgPicture).Visibility = ViewStates.Gone;
            customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
            customView.FindViewById<ImageButton>(Resource.Id.imgPicture).Click += delegate
            {
                AndHUD.Shared.ShowImage(this, Drawable.CreateFromPath(_file.ToPath().ToString()));
            };

            customView.FindViewById<EditText>(Resource.Id.txtPublicacion).TextChanged += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(((EditText)sender).Text))
                    customView.FindViewById<Button>(Resource.Id.btnPublishApply).Enabled = true;
                else
                    customView.FindViewById<Button>(Resource.Id.btnPublishApply).Enabled = false;
            };

            customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Click += delegate
            {
                ImageButton imgPicture = customView.FindViewById<ImageButton>(Resource.Id.imgPicture);
                imgPicture.SetImageURI(null);
                imgPicture.Visibility = ViewStates.Gone;
                _file = null;
                customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
            };

            customView.FindViewById<ImageButton>(Resource.Id.btnTakePicture).Click += delegate
            {
                CreateDirectoryForPictures();
                IsThereAnAppToTakePictures();
                Intent intent = new Intent(MediaStore.ActionImageCapture);
                _file = new File(_dir, String.Format("{0}.png", Guid.NewGuid()));
                intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(_file));
                StartActivityForResult(intent, TakePicture);
            };

            customView.FindViewById<ImageButton>(Resource.Id.btnAttachImage).Click += delegate
            {
                var imageIntent = new Intent();
                imageIntent.SetType("image/*");
                imageIntent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(
                    Intent.CreateChooser(imageIntent, "Select photo"), PickImageId);
            };
            customView.FindViewById<Button>(Resource.Id.btnPublishApply).Click += async delegate
            {
                try
                {
                    System.IO.MemoryStream stream = new System.IO.MemoryStream();
                    bitmap?.Compress(Bitmap.CompressFormat.Png, 0, stream);
                    byte[] bitmapData = stream?.ToArray();
                    if (new EscritorioController().SetPost(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"),
                                                           customView.FindViewById<EditText>(Resource.Id.txtPublicacion).Text,
                                                           bitmapData))
                    {
                        page = 0;
                        posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
                        await FillPosts();
                        dialog.Dismiss();
                        customView.FindViewById<ImageView>(Resource.Id.imgPicture).Visibility = ViewStates.Gone;
                        customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
                    }
                    else
                        Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                }
                catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            };

            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }

        void CreateDirectoryForPictures()
        {
            _dir = new File(
                Android.OS.Environment.GetExternalStoragePublicDirectory(
                    Android.OS.Environment.DirectoryPictures), "WorklabsMx");
            if (!_dir.Exists())
                _dir.Mkdirs();
        }

        bool IsThereAnAppToTakePictures()
        {
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(new Intent(MediaStore.ActionImageCapture), PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            ImageButton imgPicture = customView.FindViewById<ImageButton>(Resource.Id.imgPicture);
            if (resultCode == Result.Ok)
            {
                if (requestCode == TakePicture && resultCode == Result.Ok)
                {    
                    Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
                    Android.Net.Uri contentUri = Android.Net.Uri.FromFile(_file);
                    mediaScanIntent.SetData(contentUri);
                    SendBroadcast(mediaScanIntent);

                    int height = Resources.DisplayMetrics.HeightPixels;
                    int width = 900;
                    imagePath = _file.Path;
                    bitmap = _file.Path.LoadAndResizeBitmap(width, height);
                    if (bitmap != null)
                        imgPicture.SetImageBitmap(bitmap);
                    GC.Collect();
                }
                if (requestCode == PickImageId && resultCode == Result.Ok && data != null)
                {
                    imagePath = (string)data.Data;
                    bitmap = Media.GetBitmap(ContentResolver, data.Data);
                    imgPicture.SetImageURI(data.Data);
                    imgPublish = Uri.EscapeUriString(data.Data.LastPathSegment);
                }
                imgPicture.Visibility = ViewStates.Visible;
                customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Visible;
                customView.FindViewById<Button>(Resource.Id.btnPublishApply).Enabled = true;
                customView.FindViewById<GridLayout>(Resource.Id.gvPublish).SetMinimumHeight(440);
            }
        }
    }
}