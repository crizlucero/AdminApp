using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class InvitadosActivity : Activity
    {
        SimpleStorage storage;
        LinearLayout DatosBasicos;
        EditText Nombre, Apellidos, Correo;
        List<UsuarioModel> invitados;
        Emails email;
        string correoInvitacion;
        public InvitadosActivity()
        {
            invitados = new List<UsuarioModel>();
            email = new Emails();
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
                DatePickerMinFragment frag = DatePickerMinFragment.NewInstance(delegate (DateTime time)
                {
                    TimePickerFragment timeFrag = TimePickerFragment.NewInstance(delegate (DateTime hour)
                    {
                        lblFecha.Text = time.ToString("MMMM dd, yyyy ").ToUpper() + hour.ToString("hh:mm tt");
                    });
                    timeFrag.Show(FragmentManager, Resources.GetString(Resource.String.str_meeting_room_reservation));
                });
                frag.Show(FragmentManager, Resources.GetString(Resource.String.str_meeting_room_reservation));
            };
            Nombre = FindViewById<EditText>(Resource.Id.txtNombre);
            Apellidos = FindViewById<EditText>(Resource.Id.txtApellidos);
            Correo = FindViewById<EditText>(Resource.Id.txtEmail);
            DatosBasicos = FindViewById<LinearLayout>(Resource.Id.llInvitados);

            Spinner ubicacion = FindViewById<Spinner>(Resource.Id.spUbicacion);
            Dictionary<string, string> sucursales = new SucursalController().GetSucursalInfo();
            List<string> display = sucursales.Keys.ToList();
            ubicacion.Adapter = new ArrayAdapter<string>(this, Resource.Drawable.spinner_style, display);

            EditText txtAsunto = FindViewById<EditText>(Resource.Id.txtAsunto);


            FindViewById<TextView>(Resource.Id.lblAgregarInvitado).Click += (sender, e) => AddDatosBasicos();
            FindViewById<TextView>(Resource.Id.lblEnviar).Click += delegate
            {
                List<int> invitados_id = new List<int>();
                AssetManager asset = Assets;
                correoInvitacion = new StreamReader(asset.Open("Invitacion.html")).ReadToEnd();
                SucursalModel sucursal = new SucursalController().GetSucursalInfo(sucursales[ubicacion.SelectedItem.ToString()]);
                invitados.AsParallel().ToList().ForEach(invitado =>
                {
                    try
                    {
                        invitados_id.Add(new InvitadosController().RegistraInvitado(invitado.Usuario_Nombre, invitado.Usuario_Apellidos, invitado.Usuario_Correo_Electronico,
                                                                       txtAsunto.Text, DateTime.Parse(lblFecha.Text), sucursales[ubicacion.SelectedItem.ToString()],
                                                                                  storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo")));

                        email.SendMail(invitado.Usuario_Correo_Electronico, invitado.Usuario_Nombre + " " + invitado.Usuario_Apellidos,
                                       correoInvitacion.Replace("{{NOMBRE}}", invitado.Usuario_Nombre + " " + invitado.Usuario_Apellidos)
                                       .Replace("{{FECHA}}", lblFecha.Text)
                                       .Replace("{{SUCURSAL}}", sucursal.Sucursal_Descripcion)
                                       .Replace("{{CALLE}}", sucursal.Sucursal_Domicilio)
                                       .Replace("{{COLONIA}}", sucursal.Territorio.Colonia)
                                       .Replace("{{QR}}", "INVITADO"), "Tiene una invitación");
                        Toast.MakeText(this, Resource.String.str_general_data_saved, ToastLength.Short).Show();

                    }
                    catch (Exception e)
                    {
                        Toast.MakeText(this, Resource.String.str_general_save_error, ToastLength.Short).Show();
                        SlackLogs.SendMessage(e.Message, GetType().Name, "OnCreate");
                    }
                });
                if (invitados_id.Count != 0)
                {
                    Intent intent = new Intent(this, typeof(InvitadosConfirmacionActivity));
                    intent.PutExtra("Invitados_Id", JsonConvert.SerializeObject(invitados_id));
                    StartActivity(intent);
                    Finish();
                }
            };
        }

        void AddDatosBasicos()
        {
            if (Android.Util.Patterns.EmailAddress.Matcher(Correo.Text).Matches() && !string.IsNullOrEmpty(Nombre.Text) && !string.IsNullOrEmpty(Apellidos.Text))
            {
                UsuarioModel invitado = new UsuarioModel();
                LayoutInflater liView = LayoutInflater;
                View basicView = liView.Inflate(Resource.Layout.DatosBasicosLayout, null, false);
                basicView.FindViewById<TextView>(Resource.Id.txtNombre).Text = Nombre.Text + " " + Apellidos.Text;
                basicView.FindViewById<TextView>(Resource.Id.txtEmail).Text = Correo.Text;

                invitado.Usuario_Nombre = Nombre.Text;
                invitado.Usuario_Apellidos = Apellidos.Text;
                invitado.Usuario_Correo_Electronico = Correo.Text;

                Nombre.Text = "";
                Apellidos.Text = "";
                Correo.Text = "";

                DatosBasicos.AddView(basicView);
                invitados.Add(invitado);
            }
            else
                Toast.MakeText(this, "Llene todos los campos correctamente", ToastLength.Short).Show();
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }
        public override void OnBackPressed()
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }
    }

}
