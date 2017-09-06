
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "EditPerfilActivity")]
    public class EditPerfilActivity : Activity
    {
        SimpleStorage storage;
        TextView nombre, apellidos, email, fechaNacimiento, Profesion, Puesto, Habilidades, Telefono, Celular;
        Spinner generos;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.EditPerfilLayout);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.EditarPerfil);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            generos = FindViewById<Spinner>(Resource.Id.txtGeneroPerfil);
            generos.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new PickerItemsController().GetGeneros().ToArray());
            nombre = FindViewById<TextView>(Resource.Id.txtNombrePerfil);
            apellidos = FindViewById<TextView>(Resource.Id.txtApellidosPerfil);
            email = FindViewById<TextView>(Resource.Id.txtEmailPerfil);
            fechaNacimiento = FindViewById<TextView>(Resource.Id.txtFechaNacimientoPerfil);
            Profesion = FindViewById<TextView>(Resource.Id.txtProfesionPerfil);
            Puesto = FindViewById<TextView>(Resource.Id.txtPuestoPerfil);
            Habilidades = FindViewById<TextView>(Resource.Id.txtHabilidadesPerfil);
            Telefono = FindViewById<TextView>(Resource.Id.txtTelefonoPerfil);
            Celular = FindViewById<TextView>(Resource.Id.txtCelularPerfil);
            FillUserData();
        }

        void FillUserData()
        {
            MiembroModel miembro = new MiembrosController().GetMemberData(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
            //FindViewById<ImageView>(Resource.Id.imgPerfil).SetImageURI(Android.Net.Uri.Parse("http://worklabs.mx/Dashboard_Client/usr_imgs/" + miembro.Miembro_Fotografia));
            nombre.Text = miembro.Miembro_Nombre;
            apellidos.Text = miembro.Miembro_Apellidos;
            email.Text = miembro.Miembro_Correo_Electronico;
            generos.SetSelection(miembro.Genero_Descripcion == "Femenino" ? 0 : 1, true);
            fechaNacimiento.Text = miembro.Miembro_Fecha_Nacimiento;
            Profesion.Text = miembro.Miembro_Profesion;
            Puesto.Text = miembro.Miembro_Puesto;
            Habilidades.Text = miembro.Miembro_Habilidades;
            Telefono.Text = miembro.Miembro_Telefono;
            Celular.Text = miembro.Miembro_Celular;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.save_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_save:
                    if (new MiembrosController().UpdateDataMiembros(Convert.ToInt32(storage.Get("Usuario_Id")), nombre.Text, apellidos.Text, email.Text,
                                                                Telefono.Text, Celular.Text, Profesion.Text, Puesto.Text, Habilidades.Text,
                                                                   Convert.ToDateTime(fechaNacimiento), ""))
                        Toast.MakeText(this, Resource.String.DatosGuardados, ToastLength.Short);
                    else
                        Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                    break;
                default:
                    base.OnBackPressed(); break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
