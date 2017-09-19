using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "PerfilActivity")]
    public class PerfilActivity : Activity
    {
        SimpleStorage storage;
        public string usuario_id = string.Empty, usuario_tipo = string.Empty;
        MiembrosController Favorites;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            usuario_id = Intent.GetStringExtra("usuario_id");
            usuario_tipo = Intent.GetStringExtra("usuario_tipo");
            if (!string.IsNullOrEmpty(usuario_id) && !string.IsNullOrEmpty(usuario_tipo))
            {
                SetContentView(Resource.Layout.PrePerfilLayout);
                Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                SetActionBar(toolbar);
                ActionBar.SetDisplayHomeAsUpEnabled(true);
                ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            }
            else
                SetContentView(Resource.Layout.PerfilLayout);
            SimpleStorage.SetContext(ApplicationContext);
            Favorites = new MiembrosController();
            storage = SimpleStorage.EditGroup("Login");

            FillUserData();
        }

        void FillUserData()
        {
            MiembroModel miembro;
            ImageButton btnFavorito = FindViewById<ImageButton>(Resource.Id.btnFavorite);

            if (string.IsNullOrEmpty(usuario_id) && string.IsNullOrEmpty(usuario_tipo))
            {
                miembro = new MiembrosController().GetMemberData(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
            }
            else
            {
                miembro = new MiembrosController().GetMemberData(usuario_id, usuario_tipo);
                ActionBar.Title = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
                if (storage.Get("Usuario_Id") != miembro.Miembro_Id || storage.Get("Usuario_Tipo") != miembro.Miembro_Tipo)
                {
                    KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(usuario_id, usuario_tipo, miembro.Miembro_Id, miembro.Miembro_Tipo);
                    btnFavorito.Visibility = ViewStates.Visible;
                    btnFavorito.SetBackgroundColor(Android.Graphics.Color.White);
                    if (isFavorite.Value)
                        btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                    btnFavorito.Click += (sender, e) =>
                    {
                        if (isFavorite.Key == 0)
                        {
                            if (Favorites.AddMiembroFavorito(usuario_id, usuario_tipo, miembro.Miembro_Id, miembro.Miembro_Tipo))
                                btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                            else
                                Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                        }
                        else
                        {
                            if (Favorites.RemoveMiembroFavorito(isFavorite))
                            {
                                if (isFavorite.Value)
                                    btnFavorito.SetImageResource(Resource.Mipmap.ic_star_border);
                                else
                                    btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                            }
                            else
                                Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                        }
                        isFavorite = Favorites.IsMiembroFavorito(usuario_id, usuario_tipo, miembro.Miembro_Id, miembro.Miembro_Tipo);
                    };
                }
            }
            FindViewById<ImageView>(Resource.Id.imgPerfil).SetImageURI(Android.Net.Uri.Parse("http://worklabs.mx/Dashboard_Client/usr_imgs/" + miembro.Miembro_Fotografia));
            FindViewById<TextView>(Resource.Id.txtProfileName).Text = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
            FindViewById<TextView>(Resource.Id.txtEmailPerfil).Text = miembro.Miembro_Correo_Electronico;
            FindViewById<TextView>(Resource.Id.txtGeneroPerfil).Text = miembro.Genero_Descripcion;
            FindViewById<TextView>(Resource.Id.txtFechaNacimientoPerfil).Text = DateTime.Parse(miembro.Miembro_Fecha_Nacimiento).ToString("dd/MM/yyyy");
            FindViewById<TextView>(Resource.Id.txtProfesionPerfil).Text = miembro.Miembro_Profesion;
            FindViewById<TextView>(Resource.Id.txtPuestoPerfil).Text = miembro.Miembro_Puesto;
            FindViewById<TextView>(Resource.Id.txtHabilidadesPerfil).Text = miembro.Miembro_Habilidades;
            FindViewById<TextView>(Resource.Id.txtTelefonoPerfil).Text = miembro.Miembro_Telefono;
            FindViewById<TextView>(Resource.Id.txtCelularPerfil).Text = miembro.Miembro_Celular;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            base.OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }
    }
}