using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ReservaSalaJuntasActivity")]
    public class ReservaSalaJuntasActivity : Activity
    {
        List<SalaJuntasModel> salas;
        SalaJuntasModel sala_seleccionada;
        readonly SalasJuntasController SalasController;
        string fecha_seleccionada, hora_inicio_seleccionada, hora_fin_seleccionada;
        readonly SimpleStorage storage;
        readonly UsuarioModel usuario;
        readonly string salas_imagen_path;
        ListView lvSalasJuntas;
        AlertDialog dialog;
        Dictionary<string, byte[]> imagenes;

        public ReservaSalaJuntasActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
            SalasController = new SalasJuntasController();
            usuario = new UsuariosController().GetMemberData(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
            salas_imagen_path = new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE SALAS DE REUNIONES").Parametro_Varchar_1;
            imagenes = new Dictionary<string, byte[]>();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReservacionSalaJuntasLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room_reservation);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            FindViewById<TextView>(Resource.Id.txtSeleccionarFecha).Text = fecha_seleccionada = DateTime.Now.ToString("yyyy-MM-dd");
            FindViewById<TextView>(Resource.Id.txtSeleccionarHoraInicio).Text = hora_inicio_seleccionada = CalendarHelper.RoundUp(DateTime.Now, TimeSpan.FromMinutes(30)).ToString("HH:mm");
            FindViewById<TextView>(Resource.Id.txtSeleccionarHoraFin).Text = hora_fin_seleccionada = CalendarHelper.RoundUp(DateTime.Now.AddMinutes(30), TimeSpan.FromMinutes(30)).ToString("HH:mm");

            FindViewById<TextView>(Resource.Id.lblCreditosDisponibles).Text = SalasController.GetCreditosDisponibles(storage.Get("Usuario_Id")).ToString();
            FindViewById<LinearLayout>(Resource.Id.llSeleccionarFecha).Click += (sender, e) =>
            {
                DatePickerMinFragment frag = DatePickerMinFragment.NewInstance(delegate (DateTime time)
                {
                    FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = time.DayOfWeek.ToString().Substring(0, 3);
                    FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = time.Day.ToString();
                    FindViewById<TextView>(Resource.Id.txtSeleccionarFecha).Text = fecha_seleccionada = time.ToString("yyyy-MM-dd");
                    SeleccionElemento();
                });
                frag.Show(FragmentManager, Resources.GetString(Resource.String.str_label_select_date));
            };

            FindViewById<LinearLayout>(Resource.Id.llSeleccionarHoraInicio).Click += (sender, e) =>
            {
                TimePickerIntervalFragment frag = TimePickerIntervalFragment.NewInstance(delegate (DateTime time)
                {
                    FindViewById<TextView>(Resource.Id.txtSeleccionarHoraInicio).Text = hora_inicio_seleccionada = time.ToString("HH:mm");
                    if (DateTime.Parse(hora_fin_seleccionada).Subtract(DateTime.Parse(hora_inicio_seleccionada)).TotalHours < 0)
                        FindViewById<TextView>(Resource.Id.txtSeleccionarHoraFin).Text = hora_fin_seleccionada = time.AddMinutes(30).ToString("HH:mm");
                    SeleccionElemento();
                    FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = DateTime.Parse(hora_fin_seleccionada).Subtract(DateTime.Parse(hora_inicio_seleccionada)).TotalHours.ToString();
                    FindViewById<TextView>(Resource.Id.lblCreditosUsados).Text = CalcularCreditos().ToString();
                });
                frag.Show(FragmentManager, Resources.GetString(Resource.String.str_label_select_hour_initial));
            };

            FindViewById<LinearLayout>(Resource.Id.llSeleccionarHoraFin).Click += (sender, e) =>
            {
                TimePickerIntervalFragment frag = TimePickerIntervalFragment.NewInstance(delegate (DateTime time)
                {
                    if (DateTime.Parse(hora_fin_seleccionada).Subtract(DateTime.Parse(hora_inicio_seleccionada)).TotalHours > 0)
                    {
                        FindViewById<TextView>(Resource.Id.txtSeleccionarHoraFin).Text = hora_fin_seleccionada = time.ToString("HH:mm");
                        SeleccionElemento();
                        FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = DateTime.Parse(hora_fin_seleccionada).Subtract(DateTime.Parse(hora_inicio_seleccionada)).TotalHours.ToString();
                        FindViewById<TextView>(Resource.Id.lblCreditosUsados).Text = CalcularCreditos().ToString();
                    }
                    else
                        Toast.MakeText(this, "Su hora de termino debe ser mayor a la hora de inicio", ToastLength.Short).Show();
                });
                frag.Show(FragmentManager, Resources.GetString(Resource.String.str_label_select_hour_final));
            };

            salas = SalasController.GetSalaJuntas(Intent.GetStringExtra("sucursal_id"), fecha_seleccionada, hora_inicio_seleccionada, hora_fin_seleccionada);
            FillImagenes();
            lvSalasJuntas = FindViewById<ListView>(Resource.Id.lvSalasJuntas);
            lvSalasJuntas.SetMinimumHeight(salas.Count * 200);
            lvSalasJuntas.Adapter = new SalasJuntasListAdapter(salas);
            lvSalasJuntas.ItemClick += (sender, e) =>
            {
                sala_seleccionada = salas[e.Position];
            };


            FindViewById<RadioGroup>(Resource.Id.rgCapacidad).CheckedChange += (sender, e) =>
            {
                SeleccionElemento();
            };


            FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = DateTime.Parse(fecha_seleccionada).DayOfWeek.ToString().Substring(0, 3);
            FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
            FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = DateTime.Parse(hora_fin_seleccionada).Subtract(DateTime.Parse(hora_inicio_seleccionada)).TotalHours.ToString();
            FindViewById<TextView>(Resource.Id.lblCreditosUsados).Text = CalcularCreditos().ToString();//DateTime.Parse(hora_fin_seleccionada).Subtract(DateTime.Parse(hora_inicio_seleccionada)).TotalHours.ToString();


            FindViewById<TextView>(Resource.Id.lblAgendar).Click += delegate
            {
                if (sala_seleccionada != null)
                    ShowConfirmacion();
                else
                    Toast.MakeText(this, "Seleccione una sala de reunión", ToastLength.Short).Show();
            };
        }

        double CalcularCreditos()
        {
            double horas = DateTime.Parse(hora_fin_seleccionada).Subtract(DateTime.Parse(hora_inicio_seleccionada)).TotalHours * 2;
            DateTime hora_inicio = DateTime.Parse(hora_inicio_seleccionada);
            DateTime hora_fin = DateTime.Parse(hora_fin_seleccionada);
            double tiempo = 0;
            for (double i = 0; i < horas; i += .5)
            {
                if (hora_inicio.Hour > 11 && hora_inicio.Hour < 17)
                {
                    if (hora_fin != hora_inicio)
                    {
                        tiempo += .5;
                        hora_inicio = hora_inicio.AddMinutes(30);
                    }
                    else break;
                }
                    else break;
            }
            return horas + tiempo;
        }

        void SeleccionElemento()
        {
            salas = SalasController.GetSalaJuntas(Intent.GetStringExtra("sucursal_id"), fecha_seleccionada, hora_inicio_seleccionada, hora_fin_seleccionada);
            FillImagenes();
            lvSalasJuntas.Adapter = new SalasJuntasListAdapter(salas);
            sala_seleccionada = null;
        }

        void FillImagenes()
        {
            salas.ForEach(sala =>
            {
                if (!imagenes.ContainsKey(sala.Sala_Id) && !string.IsNullOrEmpty(sala.Sala_Fotografia))
                {
                    imagenes.Add(sala.Sala_Id, new UploadImages().DownloadFileFTP(sala.Sala_Fotografia, salas_imagen_path));
                    sala.Sala_Fotografia_Imagen = imagenes[sala.Sala_Id];
                }

            });
        }

        void ShowConfirmacion()
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            View customView = LayoutInflater.Inflate(Resource.Layout.DetallesReservacionLayout, null, true);

            TableLayout tlReservaciones = customView.FindViewById<TableLayout>(Resource.Id.tlReservaciones);
            LayoutInflater li = LayoutInflater;

            View detalleView = li.Inflate(Resource.Layout.DetallesReservacionSalaJuntaLayout, null, true);
            detalleView.FindViewById<TextView>(Resource.Id.lblSalasJuntas).Text = sala_seleccionada.Sala_Descripcion;
            detalleView.FindViewById<TextView>(Resource.Id.lblPiso).Text = "Nivel " + sala_seleccionada.Sala_Nivel;
            detalleView.FindViewById<TextView>(Resource.Id.lblFechaNumero).Text = DateTime.Parse(fecha_seleccionada).ToString("M");

            detalleView.FindViewById<TextView>(Resource.Id.lblHorario).Text = hora_inicio_seleccionada + " - " + hora_fin_seleccionada;

            TableRow row = new TableRow(this);
            row.AddView(detalleView);
            tlReservaciones.AddView(row);

            customView.FindViewById<Button>(Resource.Id.btnCancelar).Click += (sender, e) => dialog.Dismiss();
            customView.FindViewById<Button>(Resource.Id.btnConfirmar).Click += delegate
            {
                string correoInvitacion = new StreamReader(Assets.Open("SalaJuntasReserva.html")).ReadToEnd();
                new Emails().SendMail(usuario.Usuario_Correo_Electronico, usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos,
                                           correoInvitacion.Replace("{{NOMBRE}}", usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos)
                                      .Replace("{{NOMBRESALA}}", sala_seleccionada.Sala_Descripcion)
                                      .Replace("{{CAPACIDADSALA}}", sala_seleccionada.Sala_Capacidad)
                                      .Replace("{{DIALETRA}}", new CultureInfo("es-MX").DateTimeFormat.GetDayName(DateTime.Parse(fecha_seleccionada).DayOfWeek).Substring(0, 3))
                                      .Replace("{{DIANUMERO}}", DateTime.Parse(fecha_seleccionada).Day.ToString())
                                      .Replace("{{HORARIO}}", hora_inicio_seleccionada + " - " + hora_fin_seleccionada),
                                      "Worklabs - Confirmación de sala de junta");
                if (SalasController.AsignarSalaJuntas("ALTA", sala_seleccionada.Sala_Id, storage.Get("Usuario_Id"),
                                                      storage.Get("Usuario_Tipo"), DateTime.Parse(fecha_seleccionada), hora_inicio_seleccionada, hora_fin_seleccionada) == -1)
                    SlackLogs.SendMessage("ERROR: Registro de sala de junta", GetType().Name, "ShowConfirmacion");
                dialog.Dismiss();
                SetContentView(Resource.Layout.SalasJuntasConfirmacionLayout);

                FindViewById<TextView>(Resource.Id.lblDiaSemana).Text = new CultureInfo("es-MX").DateTimeFormat.GetDayName(DateTime.Parse(fecha_seleccionada).DayOfWeek).Substring(0, 3);
                FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
                FindViewById<TextView>(Resource.Id.lblHorario).Text = hora_inicio_seleccionada + " - " + hora_fin_seleccionada;
                FindViewById<Button>(Resource.Id.btnContinuar).Click += delegate
                {
                    StartActivity(new Intent(this, typeof(TabSalasJuntasHistorialActivity)));
                    Finish();
                };
            };
            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }
        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }

        public override void OnBackPressed()
        {
            StartActivity(new Intent(this, typeof(SalasJuntasSucursalActivity)));
            Finish();
        }
    }
}