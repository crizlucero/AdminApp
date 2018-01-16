using System;
using System.Collections.Generic;
using System.Globalization;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class SalasJuntasActivity : Activity
    {
        ViewPager _viewPager;
        List<int> horas, HorasNoDisponibles;
        string fecha_seleccionada;
        SimpleStorage storage;
        AlertDialog dialog;
        List<SalaJuntasModel> salas;
        readonly SalasJuntasController SalasController;
        LinearLayout llhHorario;
        double creditos;
        readonly Dictionary<string, Dictionary<string, List<int>>> Horarios;
        public SalasJuntasActivity()
        {
            //HorasSeleccionadas = new List<int>();
            HorasNoDisponibles = new List<int>();
            storage = SimpleStorage.EditGroup("Login");
            fecha_seleccionada = DateTime.Now.ToString("d");
            SalasController = new SalasJuntasController();
            Horarios = new Dictionary<string, Dictionary<string, List<int>>>();
            horas = new List<int>();
            for (int i = 1; i < 25; i++)
            {
                if (i < 24)
                    horas.Add(i);
                else
                    horas.Add(0);
            }
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReservaSalaJuntasLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.ReservaSala);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            _viewPager = FindViewById<ViewPager>(Resource.Id.vpSucursal);
            salas = SalasController.GetSalaJuntas(Intent.GetIntExtra("sucursal_id",-1));
            _viewPager.Adapter = new SalaJuntasAdapter(this, salas);
            Horarios.Add(salas[_viewPager.CurrentItem].Sala_Id, new Dictionary<string, List<int>>());
            Horarios[salas[_viewPager.CurrentItem].Sala_Id].Add(fecha_seleccionada, new List<int>());
            FindViewById<LinearLayout>(Resource.Id.llSeleccionarFecha).Click += (sender, e) =>
            {
                DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
                {
                    FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = time.DayOfWeek.ToString().Substring(0, 3);
                    FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = time.Day.ToString();
                    //_dateDisplay.Text = time.ToLongDateString();
                });
                frag.Show(FragmentManager, Resources.GetString(Resource.String.ReservaSala));
            };
            FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = DateTime.Parse(fecha_seleccionada).DayOfWeek.ToString().Substring(0, 3);
            FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
            FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Count.ToString();
            FindViewById<TextView>(Resource.Id.lblCreditosUsados).Text = creditos.ToString();
            llhHorario = FindViewById<LinearLayout>(Resource.Id.llhHorario);
            SalasController.GetHorasNoDisponibles(fecha_seleccionada, salas[_viewPager.CurrentItem].Sala_Id).ForEach(horas =>
            {
                HorasNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour);
            });

            _viewPager.PageSelected += (sender, e) =>
            {
                //Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Clear();
                HorasNoDisponibles.Clear();
                SalasController.GetHorasNoDisponibles(fecha_seleccionada, salas[_viewPager.CurrentItem].Sala_Id).ForEach(horas =>
                    HorasNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour));
                if (!Horarios.ContainsKey(salas[_viewPager.CurrentItem].Sala_Id))
                    Horarios.Add(salas[_viewPager.CurrentItem].Sala_Id, new Dictionary<string, List<int>>());
                if (!Horarios[salas[_viewPager.CurrentItem].Sala_Id].ContainsKey(fecha_seleccionada))
                    Horarios[salas[_viewPager.CurrentItem].Sala_Id].Add(fecha_seleccionada, new List<int>());
                FillHorario();
            };
            FindViewById<RelativeLayout>(Resource.Id.rlAgendar).Click += (sender, e) => ShowConfirmacion();
            FillHorario();
            HorizontalScrollView scrollHoras = FindViewById<HorizontalScrollView>(Resource.Id.hsvHorario);
            scrollHoras.SmoothScrollTo(500, 0);
        }

        void FillHorario()
        {
            llhHorario.RemoveAllViews();
            PutZeroHour();
            horas.ForEach(hora =>
            {
                LayoutInflater liView = LayoutInflater;
                View HorarioView = liView.Inflate(Resource.Layout.HorarioItemLayout, null, true);
                if (hora < 24)
                    HorarioView.FindViewById<TextView>(Resource.Id.lblHora).Text = hora.ToString();
                else
                    HorarioView.FindViewById<TextView>(Resource.Id.lblHora).Text = "0";
                ImageView horario = HorarioView.FindViewById<ImageView>(Resource.Id.ivHora);
                if (HorasNoDisponibles.Contains(hora))
                {
                    horario.SetBackgroundColor(Color.Rgb(85, 85, 85));
                    horario.SetImageResource(Resource.Mipmap.ic_diagonal_lines);
                }
                if (Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Contains(hora))
                {
                    horario.SetBackgroundColor(Color.Rgb(162, 219, 255));
                }
                HorarioView.Click += delegate
                {
                    if (!HorasNoDisponibles.Contains(hora))
                    {
                        if (!Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Contains(hora))
                        {
                            horario.SetBackgroundColor(Color.Rgb(162, 219, 255));
                            Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Add(hora);
                        }
                        else
                        {
                            horario.SetBackgroundColor(Color.Rgb(225, 252, 195));
                            Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Remove(hora);
                        }
                    }
                    int totalHoras = 0;

                    creditos = 0;
                    salas.ForEach(sala =>
                    {
                        if (Horarios.ContainsKey(sala.Sala_Id))
                        {

                            foreach (KeyValuePair<string, List<int>> fechaHorario in Horarios[sala.Sala_Id])
                            {
                                totalHoras += fechaHorario.Value.Count;
                                fechaHorario.Value.ForEach(time =>
                                {
                                    creditos++;
                                    if (sala.Sala_Capacidad == "10" && time > 10 && time < 18)
                                        creditos += .5;
                                });
                            }
                        }
                    });
                    FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = totalHoras.ToString();
                    FindViewById<TextView>(Resource.Id.lblCreditosUsados).Text = creditos.ToString();

                };
                llhHorario.AddView(HorarioView);
            });
        }

        void PutZeroHour()
        {
            GridLayout glZero = new GridLayout(this);
            glZero.ColumnCount = 3;
            glZero.RowCount = 1;
            glZero.SetBackgroundColor(Color.White);
            glZero.AddView(new TextView(this)
            {
                Text = "0"
            });
            View line = new View(this);
            line.SetBackgroundColor(Color.Rgb(149, 152, 154));
            line.SetMinimumWidth(1);
            line.SetMinimumHeight(60);
            line.SetForegroundGravity(GravityFlags.Right);
            glZero.AddView(line);
            llhHorario.AddView(glZero);
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(SalasJuntasSucursalActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
        }

        void ShowConfirmacion()
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            View customView = liView.Inflate(Resource.Layout.DetallesReservacionLayout, null, true);
            Dictionary<int, int> aux = new Dictionary<int, int>();
            Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Sort();
            int aux2 = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][0] - 1;
            aux.Add(aux2, aux2 + 1);

            for (int i = 1; i < Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Count; i++)
            {
                if (aux[aux2] == Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][i] - 1)
                {
                    aux[aux2] = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][i];
                }
                else
                {
                    aux2 = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][i] - 1;
                    aux.Add(aux2, aux2 + 1);

                }
            }


            TableLayout tlReservaciones = customView.FindViewById<TableLayout>(Resource.Id.tlReservaciones);

            foreach (KeyValuePair<int, int> horas in aux)
            {
                LayoutInflater li = LayoutInflater;

                View detalleView = li.Inflate(Resource.Layout.DetallesReservacionSalaJuntaLayout, null, true);
                detalleView.FindViewById<TextView>(Resource.Id.lblSalasJuntas).Text = salas[_viewPager.CurrentItem].Sala_Descripcion;
                detalleView.FindViewById<TextView>(Resource.Id.lblPiso).Text = "Nivel " + salas[_viewPager.CurrentItem].Sala_Nivel;
                detalleView.FindViewById<TextView>(Resource.Id.lblFechaNumero).Text = DateTime.Parse(fecha_seleccionada).ToString("M");
                detalleView.FindViewById<TextView>(Resource.Id.lblHorario).Text = (horas.Key).ToString("00") + ":00 - " + horas.Value.ToString("00") + ":00";

                TableRow row = new TableRow(this);
                row.AddView(detalleView);
                tlReservaciones.AddView(row);
            }

            /*Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].ForEach(hora =>
            {

                LayoutInflater li = LayoutInflater;

                View detalleView = li.Inflate(Resource.Layout.DetallesReservacionSalaJuntaLayout, null, true);
                detalleView.FindViewById<TextView>(Resource.Id.lblSalasJuntas).Text = salas[_viewPager.CurrentItem].Sala_Descripcion;
                detalleView.FindViewById<TextView>(Resource.Id.lblPiso).Text = "Nivel " + salas[_viewPager.CurrentItem].Sala_Nivel;
                detalleView.FindViewById<TextView>(Resource.Id.lblFechaNumero).Text = DateTime.Parse(fecha_seleccionada).ToString("M");
                detalleView.FindViewById<TextView>(Resource.Id.lblHorario).Text = (hora - 1).ToString("00") + ":00 - " + hora.ToString("00") + ":00";

                TableRow row = new TableRow(this);
                row.AddView(detalleView);
                tlReservaciones.AddView(row);
            });*/


            customView.FindViewById<Button>(Resource.Id.btnCancelar).Click += (sender, e) => dialog.Dismiss();
            customView.FindViewById<Button>(Resource.Id.btnConfirmar).Click += delegate
            {
                Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].ForEach(hora =>
                {
                    ContentValues eventValues = new ContentValues();

                    eventValues.Put(CalendarContract.Events.InterfaceConsts.CalendarId,
                        1);
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Title,
                        "Test Event from M4A");
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Description,
                        "This is an event created from Xamarin.Android");
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Dtstart,
                        new CalendarHelper().GetDateTimeMS(2017, 1, 12, 16, 55));
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Dtend,
                                    new CalendarHelper().GetDateTimeMS(2017, 1, 12, 18, 40));

                    eventValues.Put(CalendarContract.Events.InterfaceConsts.EventTimezone,
                        "UTC");
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.EventEndTimezone,
                        "UTC");

                    var uri = ContentResolver.Insert(CalendarContract.Events.ContentUri,
                        eventValues);
                    Console.WriteLine(uri);
                    long eventID = long.Parse(uri.LastPathSegment);

                    ContentValues reminderValues = new ContentValues();
                    reminderValues.Put(CalendarContract.Reminders.InterfaceConsts.Minutes, 30);
                    reminderValues.Put(CalendarContract.Reminders.InterfaceConsts.EventId, eventID);
                    //reminderValues.Put(CalendarContract.Reminders.InterfaceConsts.CalendarId, 1);
                    reminderValues.Put(CalendarContract.Reminders.InterfaceConsts.Method, (int)RemindersMethod.Alert);
                    var reminderUri = ContentResolver.Insert(CalendarContract.Reminders.ContentUri, reminderValues);
                    Console.WriteLine("Uri for new event: {0}", reminderUri);
                    //SalasController.AsignarSalaJuntas("ALTA", salas[_viewPager.CurrentItem].Sala_Id, storage.Get("Usuario_Id"),
                    //                                  storage.Get("Usuario_Tipo"), fecha_seleccionada, (hora - 1).ToString("00") + ":00", hora.ToString("00") + ":00");
                }
                );
                dialog.Dismiss();
                SetContentView(Resource.Layout.SalasJuntasConfirmacionLayout);
                FindViewById<TextView>(Resource.Id.lblDiaSemana).Text = DateTime.Parse(fecha_seleccionada).DayOfWeek.ToString().Substring(0, 3);
                FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
                FindViewById<TextView>(Resource.Id.lblHorario).Text = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][0] + " - " + Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][0];
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


    }


    class SalaJuntasAdapter : PagerAdapter
    {
        Context context;
        List<SalaJuntasModel> salaJuntas;
        public SalaJuntasAdapter(Context context, List<SalaJuntasModel> salaJuntas)
        {
            this.context = context;
            this.salaJuntas = salaJuntas;
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View SucursalView = liView.Inflate(Resource.Layout.SalasJuntasLayout, null, true);
            SucursalView.FindViewById<TextView>(Resource.Id.lblSalaJunta).Text = salaJuntas[position].Sala_Descripcion;
            SucursalView.FindViewById<TextView>(Resource.Id.tvCapacidad).Text = salaJuntas[position].Sala_Capacidad + "-" + (Convert.ToInt32(salaJuntas[position].Sala_Capacidad) + 2).ToString();
            SucursalView.FindViewById<TextView>(Resource.Id.tvNivel).Text = "Nivel " + Convert.ToInt32(salaJuntas[position].Sala_Nivel).ToString("00");
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(SucursalView);
            return SucursalView;
        }

        public override int Count => salaJuntas.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new Java.Lang.String(salaJuntas[position].Sala_Descripcion);

        public override void DestroyItem(View container, int position, Java.Lang.Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);
    }
}
