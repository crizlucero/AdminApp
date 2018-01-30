using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Views;
using Android.Widget;
using Java.IO;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;
using static Android.Provider.MediaStore.Images;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class MisColaboradoresCambiosActivity : Activity
    {
        string colaborador_id, colaborador_tipo, imagePath, imgPublish;
        EditText txtNombre, txtApellidos, txtCorreo, txtNacimiento,
        txtProfesion, txtPuesto, txtHabilidades, txtTelefono, txtCelular;
        Spinner spGenero;
        File _file, _dir;
        Bitmap bitmap;
        readonly int sizePage = 10, PickImageId = 1000, TakePicture = 500;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ColaboradorCambioLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.MisColaboradores);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            InitiateView();
            colaborador_id = Intent.GetStringExtra("colaborador_id");
            colaborador_tipo = Intent.GetStringExtra("colaborador_tipo");
            if (!string.IsNullOrEmpty(colaborador_id) && !string.IsNullOrEmpty(colaborador_tipo))
            {
                FillData();
            }
        }

        void InitiateView()
        {
            txtNombre = FindViewById<EditText>(Resource.Id.txtNombre);
            txtApellidos = FindViewById<EditText>(Resource.Id.txtApellidos);
            txtCorreo = FindViewById<EditText>(Resource.Id.txtEmail);
            txtNacimiento = FindViewById<EditText>(Resource.Id.txtFechaNacimiento);
            txtProfesion = FindViewById<EditText>(Resource.Id.txtProfesion);
            txtPuesto = FindViewById<EditText>(Resource.Id.txtPuesto);
            txtHabilidades = FindViewById<EditText>(Resource.Id.txtHabilidades);
            txtTelefono = FindViewById<EditText>(Resource.Id.txtTelefono);
            txtCelular = FindViewById<EditText>(Resource.Id.txtCelular);
            spGenero = FindViewById<Spinner>(Resource.Id.txtGenero);
            spGenero.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new PickerItemsController().GetGeneros().ToArray());
            FindViewById<ImageButton>(Resource.Id.imgColaborador).Click += delegate
            {
                CreateDirectoryForPictures();
                IsThereAnAppToTakePictures();
                Intent intent = new Intent(MediaStore.ActionImageCapture);
                _file = new File(_dir, String.Format("{0}.png", Guid.NewGuid()));
                intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(_file));
                StartActivityForResult(intent, TakePicture);
            };
        }

        void FillData()
        {
            UsuarioModel colaborador = new UsuariosController().GetColaborador(colaborador_id);

            txtNombre.Text = colaborador.Usuario_Nombre;
            txtApellidos.Text = colaborador.Usuario_Apellidos;
            txtCorreo.Text = colaborador.Usuario_Correo_Electronico;
            txtNacimiento.Text = colaborador.Usuario_Fecha_Nacimiento;
            txtProfesion.Text = colaborador.Usuario_Profesion;
            txtPuesto.Text = colaborador.Usuario_Puesto;
            //txtHabilidades.Text = colaborador.Usuario_Habilidades;
            txtTelefono.Text = colaborador.Usuario_Telefono;
            txtCelular.Text = colaborador.Usuario_Celular;
            spGenero.SetSelection(Convert.ToInt32(colaborador.Genero.Genero_Id) - 1, true);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.send_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.menu_send:
                    System.IO.MemoryStream stream = new System.IO.MemoryStream();
                    bitmap?.Compress(Bitmap.CompressFormat.Png, 0, stream);
                    byte[] bitmapData = stream?.ToArray();
                    new UsuariosController().AddChangeColaborador(PerpetualEngine.Storage.SimpleStorage.EditGroup("Login").Get("Empresa_Id"), txtNombre.Text, txtApellidos.Text,
                                                                       txtCorreo.Text, txtTelefono.Text, txtCelular.Text, txtProfesion.Text,
                                                                       txtPuesto.Text, txtHabilidades.Text, txtNacimiento.ToString(),
                                                                       colaborador_id, (spGenero.SelectedItemId + 1).ToString(), bitmapData);
                    break;
                default:
                    StartActivity(new Intent(this, typeof(TabColaboradoresActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
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
            ImageButton imgPicture = FindViewById<ImageButton>(Resource.Id.imgColaborador);
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
            }
        }
    }
}
