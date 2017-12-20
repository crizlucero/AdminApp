using System;
using System.Collections.Generic;
using System.Globalization;
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
        List<int> horas, HorasNoDisponibles;
        string fecha_seleccionada;
        SimpleStorage storage;
        AlertDialog dialog;
        List<SalaJuntasModel> salas;
        readonly SalasJuntasController SalasController;
        LinearLayout llhHorario;
        double creditos;
        Dictionary<string, Dictionary<string, List<int>>> Horarios;
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
            salas = SalasController.GetSalaJuntas(Intent.GetStringExtra("sucursal_id"));
            _viewPager.Adapter = new SalaJuntasAdapter(this, salas);
            Horarios.Add(salas[_viewPager.CurrentItem].Sala_Id, new Dictionary<string, List<int>>());
            Horarios[salas[_viewPager.CurrentItem].Sala_Id].Add(fecha_seleccionada, new List<int>());
            FindViewById<LinearLayout>(Resource.Id.llSeleccionarFecha).Click += (sender, e) => ShowCalendarView();
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
            FindViewById<RelativeLayout>(Resource.Id.rlAgendar).Click += delegate
            {
                Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].ForEach(hora =>
                {
                    int reservacion_id = SalasController.AsignarSalaJuntas("ALTA", salas[_viewPager.CurrentItem].Sala_Id, storage.Get("Usuario_Id"),
                                                                                       storage.Get("Usuario_Tipo"), fecha_seleccionada, (hora - 1).ToString("00") + ":00", hora.ToString("00") + ":00");
                });
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
        void ShowCalendarView()
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            View customView = liView.Inflate(Resource.Layout.CalendarioLayout, null, true);

            CalendarView calendar = customView.FindViewById<CalendarView>(Resource.Id.cvCalendario);
            calendar.MinDate = new Java.Util.Date().Time;
            calendar.FirstDayOfWeek = (int)DayOfWeek.Sunday;
            calendar.DateChange += (sender, e) =>
            {
                fecha_seleccionada = e.DayOfMonth + "/" + e.Month + "/" + e.Year;
                DateTime fecha = DateTime.ParseExact(fecha_seleccionada, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = fecha.DayOfWeek.ToString().Substring(0, 3);
                FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = fecha.Day.ToString();
                HorasNoDisponibles.Clear();
                SalasController.GetHorasNoDisponibles(fecha_seleccionada, salas[_viewPager.CurrentItem].Sala_Id).ForEach(horas => HorasNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour));
                if (!Horarios[salas[_viewPager.CurrentItem].Sala_Id].ContainsKey(fecha_seleccionada))
                    Horarios[salas[_viewPager.CurrentItem].Sala_Id].Add(fecha_seleccionada, new List<int>());
                FillHorario();
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
