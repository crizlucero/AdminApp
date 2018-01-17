using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class InvitadosActivity : Activity
    {
        SimpleStorage storage;
        TableLayout DatosBasicos;
        List<MiembroModel> invitados;

        public InvitadosActivity()
        {
            invitados = new List<MiembroModel>();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.InvitadosLayout);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.RegistroInvitados);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            TextView lblFecha = FindViewById<TextView>(Resource.Id.lblFecha);
            lblFecha.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt").ToUpper();
            FindViewById<Button>(Resource.Id.btnFecha).Click += (sender, e) =>
            {
                DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
                {
                    TimePickerFragment timeFrag = TimePickerFragment.NewInstance(delegate (DateTime hour)
                    {
                        lblFecha.Text = time.ToString("MMMM dd, yyyy ").ToUpper() + hour.ToString("hh:mm tt");
                    });

                    timeFrag.Show(FragmentManager, Resources.GetString(Resource.String.ReservaSala));
                });
                frag.Show(FragmentManager, Resources.GetString(Resource.String.ReservaSala));
            };
            DatosBasicos = FindViewById<TableLayout>(Resource.Id.tlDatosBasicos);
            AddDatosBasicos();

            Spinner ubicacion = FindViewById<Spinner>(Resource.Id.spUbicacion);
            Dictionary<string, string> sucursales = new SucursalController().GetSucursalInfo();
            List<string> display = sucursales.Keys.ToList();
            ubicacion.Adapter = new ArrayAdapter<string>(this, Resource.Drawable.spinner_style, display);

            EditText txtAsunto = FindViewById<EditText>(Resource.Id.txtAsunto);


            FindViewById<TextView>(Resource.Id.lblAgregarInvitado).Click += (sender, e) => AddDatosBasicos();
            FindViewById<TextView>(Resource.Id.lblEnviar).Click += delegate
            {
                Console.WriteLine(sucursales[ubicacion.SelectedItem.ToString()]);
                invitados.ForEach(invitado =>
                {
                    if (new InvitadosController().RegistraInvitado(invitado.Miembro_Nombre, invitado.Miembro_Apellidos, invitado.Miembro_Correo_Electronico, 
                                                                   txtAsunto.Text, DateTime.Parse(lblFecha.Text), sucursales[ubicacion.SelectedItem.ToString()], 
                                                                   storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo")))
                        Toast.MakeText(this, Resource.String.DatosGuardados, ToastLength.Short).Show();
                    else
                        Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short).Show();
                });
            };
        }

        void AddDatosBasicos()
        {
            MiembroModel invitado = new MiembroModel();
            LayoutInflater liView = LayoutInflater;
            View basicView = liView.Inflate(Resource.Layout.DatosBasicosLayout, null, false);
            basicView.FindViewById<EditText>(Resource.Id.txtNombre).TextChanged += (sender, e) =>
            {
                invitado.Miembro_Nombre = ((EditText)sender).Text;
            };

            basicView.FindViewById<EditText>(Resource.Id.txtApellidos).TextChanged += (sender, e) =>
            {
                invitado.Miembro_Apellidos = ((EditText)sender).Text;
            };

            basicView.FindViewById<EditText>(Resource.Id.txtEmail).TextChanged += (sender, e) =>
            {
                invitado.Miembro_Correo_Electronico = ((EditText)sender).Text;
            };

            TableRow row = new TableRow(this);
            row.AddView(basicView);
            DatosBasicos.AddView(row);
            invitados.Add(invitado);
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
        }
    }

}
