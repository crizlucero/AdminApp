using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class SalasJuntasActivity : FragmentActivity
    {
        ViewPager _viewPager;
        List<int> HorasSeleccionadas, horas, HorasNoDisponibles;
        string fecha_seleccionada;
        SimpleStorage storage;
        AlertDialog dialog;
        List<SalaJuntasModel> salas;
        readonly SalasJuntasController SalasController;
        LinearLayout llhHorario;
        public SalasJuntasActivity()
        {
            HorasSeleccionadas = new List<int>();
            HorasNoDisponibles = new List<int>();
            storage = SimpleStorage.EditGroup("Login");
            fecha_seleccionada = DateTime.Now.ToString("d");
            SalasController = new SalasJuntasController();
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
            salas = SalasController.GetSalaJuntas(Intent.GetStringExtra("sucursal_id"));
            _viewPager.Adapter = new SalaJuntasAdapter(this, salas);

            FindViewById<LinearLayout>(Resource.Id.llSeleccionarFecha).Click += (sender, e) => ShowCalendarView();
            FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = DateTime.Parse(fecha_seleccionada).DayOfWeek.ToString().Substring(0, 3);
            FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
            FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = HorasSeleccionadas.Count.ToString();
            llhHorario = FindViewById<LinearLayout>(Resource.Id.llhHorario);
            SalasController.GetHorasNoDisponibles(fecha_seleccionada, salas[_viewPager.CurrentItem].Sala_Id).ForEach(horas =>
            {
                HorasNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour);
            });
            _viewPager.PageSelected += (sender, e) =>
            {
                HorasSeleccionadas.Clear();
                HorasNoDisponibles.Clear();
                SalasController.GetHorasNoDisponibles(fecha_seleccionada, salas[_viewPager.CurrentItem].Sala_Id).ForEach(horas =>
                    HorasNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour));
                FillHorario();
            };
            FindViewById<RelativeLayout>(Resource.Id.rlAgendar).Click += delegate
            {
                HorasSeleccionadas.ForEach(hora =>
                {
                    int reservacion_id = SalasController.AsignarSalaJuntas("ALTA", salas[_viewPager.CurrentItem].Sala_Id, storage.Get("Usuario_Id"),
                                                                                       storage.Get("Usuario_Tipo"), fecha_seleccionada, (hora - 1).ToString("00") + ":00", hora.ToString("00") + ":00");
                    /*ContentValues eventValues = new ContentValues();
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.CalendarId, 1);
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Id, reservacion_id);
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Title, "Reunión en Worklabs " + salas[_viewPager.CurrentItem].Sucursal_Descripcion);
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Description, "Tiene una reunión pendiente en la sala " + salas[_viewPager.CurrentItem].Sala_Descripcion);
                    DateTime fecha = DateTime.Parse(fecha_seleccionada);
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Dtstart, new CalendarHelper().GetDateTimeMS(fecha.Year, fecha.Month, fecha.Day, hora, 0));
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.Dtend, new CalendarHelper().GetDateTimeMS(fecha.Year, fecha.Month, fecha.Day, hora + 1, 0));
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.EventTimezone, "UTC");
                    eventValues.Put(CalendarContract.Events.InterfaceConsts.EventEndTimezone, "UTC");

                    var uri = ContentResolver.Insert(CalendarContract.Events.ContentUri, eventValues);*/
                });
                SetContentView(Resource.Layout.SalasJuntasConfirmacionLayout);

                FindViewById<Button>(Resource.Id.btnContinuar).Click += delegate
                {
                    StartActivity(new Intent(this, typeof(TabSalasJuntasHistorialActivity)));
                    Finish();
                };
            };
            FillHorario();
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
                HorarioView.Click += delegate
                {
                    if (!HorasNoDisponibles.Contains(hora))
                    {
                        if (!HorasSeleccionadas.Contains(hora))
                        {
                            horario.SetBackgroundColor(Color.Rgb(162, 219, 255));
                            HorasSeleccionadas.Add(hora);
                        }
                        else
                        {
                            horario.SetBackgroundColor(Color.Rgb(225, 252, 195));
                            HorasSeleccionadas.Remove(hora);
                        }
                    }
                    FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = HorasSeleccionadas.Count.ToString();
                };
                llhHorario.AddView(HorarioView);
            });
            //HorizontalScrollView scroll = FindViewById<HorizontalScrollView>(Resource.Id.hsvHorario);
            //scroll.SetX(scroll.Width);
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
        void ShowCalendarView()
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            View customView = liView.Inflate(Resource.Layout.CalendarioLayout, null, true);

            CalendarView calendar = customView.FindViewById<CalendarView>(Resource.Id.cvCalendario);
            calendar.MinDate = new Java.Util.Date().Time;
            calendar.DateChange += (sender, e) =>
            {
                fecha_seleccionada = e.DayOfMonth + "/" + e.Month + "/" + e.Year;
                FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = DateTime.Parse(fecha_seleccionada).DayOfWeek.ToString().Substring(0, 3);
                FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
                SalasController.GetHorasNoDisponibles(fecha_seleccionada, salas[_viewPager.CurrentItem].Sala_Id).ForEach(horas =>
                {
                    HorasNoDisponibles.Clear();
                    HorasNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour);
                    FillHorario();
                });
                dialog.Dismiss();
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
