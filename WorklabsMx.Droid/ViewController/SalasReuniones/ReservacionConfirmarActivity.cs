
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservacionConfirmarActivity : Activity
    {
        SalaJuntasModel sala;
        string Tipo, sala_id, fecha_seleccionada, hora_inicio, hora_fin, cantidad_personas, cantidad_creditos;
        readonly int creditos_disponibles;
        readonly SimpleStorage storage;
        readonly UsuarioModel usuario;
        AlertDialog dialog;

        public ReservacionConfirmarActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
            usuario = new UsuariosController().GetMemberData(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
            creditos_disponibles = new SalasJuntasController().GetCreditosDisponibles(storage.Get("Usuario_Id"));
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalasReunionConfirmarLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            sala_id = Intent.GetStringExtra("sala_id");

            sala = new SalasJuntasController().GetSalaJuntasInfo(sala_id);
            fecha_seleccionada = Intent.GetStringExtra("fecha_seleccionada");
            hora_inicio = Intent.GetStringExtra("hora_inicio");
            hora_fin = Intent.GetStringExtra("hora_fin");
            cantidad_personas = Intent.GetStringExtra("cantidad_personas");
            cantidad_creditos = Intent.GetStringExtra("cantidad_creditos");
            FillView();

            FindViewById<Button>(Resource.Id.btnAvanzar).Click += delegate
            {
                /*string correoInvitacion = new StreamReader(Assets.Open("SalaJuntasReserva.html")).ReadToEnd();
                new Emails().SendMail(usuario.Usuario_Correo_Electronico, usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos,
                                           correoInvitacion.Replace("{{NOMBRE}}", usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos)
                                      .Replace("{{NOMBRESALA}}", sala.Sala_Descripcion)
                                      .Replace("{{CAPACIDADSALA}}", sala.Sala_Capacidad)
                                      .Replace("{{DIALETRA}}", new CultureInfo("es-MX").DateTimeFormat.GetDayName(DateTime.Parse(fecha_seleccionada).DayOfWeek).Substring(0, 3))
                                      .Replace("{{DIANUMERO}}", DateTime.Parse(fecha_seleccionada).Day.ToString())
                                      .Replace("{{HORARIO}}", hora_inicio + " - " + hora_fin),
                                      "Worklabs - Confirmación de sala de junta");
                if (new SalasJuntasController().AsignarSalaJuntas("ALTA", sala.Sala_Id, storage.Get("Usuario_Id"),
                                                      storage.Get("Usuario_Tipo"), DateTime.Parse(fecha_seleccionada), hora_inicio, hora_fin, cantidad_creditos) == -1)
                    SlackLogs.SendMessage("ERROR: Registro de sala de junta", GetType().Name, "ShowConfirmacion");
                    else*/
                Intent intent = new Intent(this, typeof(ReservacionConfirmacionActivity));
                intent.PutExtra("fecha_seleccionada", fecha_seleccionada);
                intent.PutExtra("hora_inicio", hora_inicio);
                intent.PutExtra("hora_fin", hora_fin);
                intent.PutExtra("cantidad_personas", cantidad_personas);
                intent.PutExtra("sala_id", sala.Sala_Id);
                StartActivity(intent);
            };

            FindViewById<Button>(Resource.Id.btnRetroceder).Click += delegate
            {
                OnBackPressed();
            };
        }

        void FillView()
        {
            FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Parse(fecha_seleccionada, new CultureInfo("es-MX")).ToLongDateString();
            FindViewById<TextView>(Resource.Id.lblHorario).Text = string.Format("{0} - {1} / {2}Hrs", hora_inicio, hora_fin, (Convert.ToInt32(cantidad_creditos) / 2));
            FindViewById<TextView>(Resource.Id.lblCreditosDisponibles).Text = creditos_disponibles.ToString();
            FindViewById<TextView>(Resource.Id.lblCosto).Text = cantidad_creditos;
            FindViewById<TextView>(Resource.Id.lblNombre).Text = sala.Sala_Descripcion;
            FindViewById<TextView>(Resource.Id.lblNivel).Text = string.Format("Nivel {0}", sala.Sala_Nivel);
            FindViewById<TextView>(Resource.Id.lblCapacidadSala).Text = string.Format("Sala para {0} personas", sala.Sala_Capacidad);
        }

    }
}
