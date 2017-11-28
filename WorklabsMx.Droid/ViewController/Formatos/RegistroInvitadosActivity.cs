
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

namespace WorklabsMx.Droid
{
    [Activity(Label = "RegistroInvitadosActivity")]
    public class RegistroInvitadosActivity : Activity
    {
        SimpleStorage storage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RegistroInvitadosLayout);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.RegistroInvitados);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
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
                    string nombre = FindViewById<EditText>(Resource.Id.txtNombreInvitado).Text;
                    string asunto = FindViewById<EditText>(Resource.Id.txtAsuntoInvitado).Text;
                    string correo = FindViewById<EditText>(Resource.Id.txtCorreoInvitado).Text;
                    string cc = FindViewById<EditText>(Resource.Id.txtCCInvitado).Text;
                    DateTime entrada = DateTime.Parse(FindViewById<EditText>(Resource.Id.txtHoraEntradaInvitado).Text);
                    DateTime salida = DateTime.Parse(FindViewById<EditText>(Resource.Id.txtHoraSalidaInvitado).Text);
                    DateTime fecha = DateTime.Parse(FindViewById<EditText>(Resource.Id.txtFechaInvitado).Text);
                    if (nombre.Trim().Length != 0 && asunto.Trim().Length != 0 && correo.Trim().Length != 0 && cc.Trim().Length != 0)
                        if (new InvitadosController().RegistraInvitado(nombre, asunto, correo, cc, entrada, salida, fecha))
                            Toast.MakeText(this, Resource.String.DatosGuardados, ToastLength.Short).Show();
                        else
                            Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short).Show();
                    else
                        Toast.MakeText(this, Resource.String.LlenarDatos, ToastLength.Short).Show();
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
