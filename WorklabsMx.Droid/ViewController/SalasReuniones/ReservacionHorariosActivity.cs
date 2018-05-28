using System;
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservacionHorariosActivity : Activity
    {
        LinearLayout llhHoraInicio, llhHoraFin, llhCantidad;
        List<TextView> txtHorasInicio, txtHorasFin, txtCantidad;
        List<View> vHorasInicio, vHorasFin, vCantidades;
        readonly List<int> horas, totalPersonas;
        int Tipo;
        string horaInicio, horaFin, CantidadPersonas, reservacion_id;
        Color ColorSel = Color.Rgb(59, 219, 213), ColorUnSel = Color.Rgb(239, 239, 239), ColorBlock = Color.Rgb(235, 235, 235);
        CalendarView cvFecha;
        List<double> HorasFinNoDisponibles, HorasInicioNoDisponibles;

        public ReservacionHorariosActivity()
        {
            HorasFinNoDisponibles = new List<double>();
            HorasInicioNoDisponibles = new List<double>();
            horas = new List<int>();
            for (int i = 0; i < 24; i++)
                horas.Add(i);
            totalPersonas = new List<int>();
            for (int i = 1; i < 11; i++)
                totalPersonas.Add(i);
            txtHorasInicio = new List<TextView>();
            txtHorasFin = new List<TextView>();
            txtCantidad = new List<TextView>();

            vHorasInicio = new List<View>();
            vHorasFin = new List<View>();
            vCantidades = new List<View>();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalasReunionSeleccionarFechaLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            Tipo = Intent.GetIntExtra("Tipo", 1);
            if (Tipo == (int)TipoSalaReunionFlujo.Sala)
            {
                FindViewById<ProgressBar>(Resource.Id.pbAvance).Progress = 2;
            }
            string sala_id = Intent.GetStringExtra("sala_id");
            reservacion_id = Intent.GetStringExtra("Reservacion_Id");
            if (!string.IsNullOrEmpty(sala_id))
                new SalasJuntasController().GetHorasNoDisponibles(Intent.GetStringExtra("fecha_seleccionada"), sala_id).AsParallel().ToList().ForEach(horas =>
                {
                    HorasFinNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour);
                    HorasInicioNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Inicio).Hour);
                });

            llhHoraInicio = FindViewById<LinearLayout>(Resource.Id.llhHoraInicio);
            llhHoraFin = FindViewById<LinearLayout>(Resource.Id.llhHoraFin);
            llhCantidad = FindViewById<LinearLayout>(Resource.Id.llhCantidad);
            cvFecha = FindViewById<CalendarView>(Resource.Id.cvFecha);
            DateTime currently = DateTime.Now;
            cvFecha.MinDate = new CalendarHelper().GetDateTimeMS(currently.Year, currently.Month - 1, currently.Day, 0, 0);


            FillHorarioInicio();
            FillHorarioFin();
            FillCantidad();

            FindViewById<Button>(Resource.Id.btnAvanzar).Click += delegate
            {
                if (!string.IsNullOrEmpty(horaInicio) && !string.IsNullOrEmpty(horaFin) && !string.IsNullOrEmpty(CantidadPersonas))
                {
                    if (DateTime.Parse(horaFin).Subtract(DateTime.Parse(horaInicio)).TotalHours > 0)
                    {
                        Intent intent;
                        if (Tipo == (int)TipoSalaReunionFlujo.Horario)
                        {
                            intent = new Intent(this, typeof(ReservacionSalasActivity));
                            intent.PutExtra("Tipo", (int)TipoSalaReunionFlujo.Horario);
                        }
                        else if (Tipo == (int)TipoSalaReunionFlujo.Sala)
                        {
                            intent = new Intent(this, typeof(ReservacionConfirmarActivity));
                            intent.PutExtra("sala_id", sala_id);
                            intent.PutExtra("cantidad_creditos", DateHelper.CalcularCreditos(horaInicio, horaFin).ToString());
                        }
                        else
                        {
                            intent = new Intent(this, typeof(ReservacionSalaOpcionesActivity));
                            intent.PutExtra("Opcion", "Editar");
                            intent.PutExtra("Reservacion_Id", reservacion_id);
                            intent.PutExtra("sala_id", sala_id);
                        }

                        intent.PutExtra("fecha_seleccionada", new CalendarHelper().GetDate(cvFecha.Date));
                        intent.PutExtra("hora_inicio", horaInicio);
                        intent.PutExtra("hora_fin", horaFin);
                        intent.PutExtra("cantidad_personas", CantidadPersonas);

                        StartActivity(intent);
                    }
                    else
                    {
                        Toast.MakeText(this, "La hora final debe ser mayor que la hora inicial", ToastLength.Short).Show();
                    }
                }
                else
                {
                    Toast.MakeText(this, "Debes de elegir todos los campos", ToastLength.Short).Show();
                }
            };
            FindViewById<Button>(Resource.Id.btnRetroceder).Click += delegate
            {
                if (Tipo != (int)TipoSalaReunionFlujo.Editar)
                {
                    if (Tipo == (int)TipoSalaReunionFlujo.Horario)
                        StartActivity(new Intent(this, typeof(ReservacionReunionActivity)));
                    else
                        StartActivity(new Intent(this, typeof(ReservacionSalasActivity)));
                }
                else
                {
                    Intent intent = new Intent(this, typeof(ReservacionSalaOpcionesActivity));
                    intent.PutExtra("Opcion", "Editar");
                    intent.PutExtra("Reservacion_Id", reservacion_id);
                    intent.PutExtra("sala_id", sala_id);
                }
                Finish();
            };
        }

        void FillHorarioInicio()
        {
            llhHoraInicio.RemoveAllViews();
            //PutZeroHour();
            int hora_actual = DateTime.Now.Hour + 2;
            horas.AsParallel().ToList().ForEach(hora =>
            {
                View HorarioView = LayoutInflater.Inflate(Resource.Layout.HorarioSeleccionLayout, null, true);
                TextView Horario = HorarioView.FindViewById<TextView>(Resource.Id.lblHora);
                View vHora = HorarioView.FindViewById<View>(Resource.Id.vHora);
                TextView Minutos = HorarioView.FindViewById<TextView>(Resource.Id.lblMinuto);
                View vMinutos = HorarioView.FindViewById<View>(Resource.Id.vMinutos);

                txtHorasInicio.Add(Horario);
                txtHorasInicio.Add(Minutos);
                vHorasInicio.Add(vHora);
                vHorasInicio.Add(vMinutos);
                Horario.Text = hora.ToString();

                if (hora < hora_actual)
                {
                    Horario.SetTextColor(ColorBlock);
                    Minutos.SetTextColor(ColorBlock);
                }
                /*if (Intent.GetStringExtra("hora_inicio").Contains(hora.ToString("D2")))
                {
                    if (Intent.GetStringExtra("hora_inicio").Contains("30"))
                    {
                        Minutos.SetBackgroundColor(ColorSel);
                        vMinutos.SetBackgroundColor(ColorSel);
                        horaInicio = hora.ToString() + ":30";
                    }
                    else
                    {
                        Horario.SetBackgroundColor(ColorSel);
                        vHora.SetBackgroundColor(ColorSel);
                        horaInicio = hora.ToString() + ":00";
                    }
                }*/

                Horario.Click += delegate
                {
                    ClearScrollSelection(txtHorasInicio, vHorasInicio);
                    Horario.SetBackgroundColor(ColorSel);
                    vHora.SetBackgroundColor(ColorSel);
                    horaInicio = hora.ToString() + ":00";
                };
                Minutos.Click += delegate
                {
                    ClearScrollSelection(txtHorasInicio, vHorasInicio);
                    Minutos.SetBackgroundColor(ColorSel);
                    vMinutos.SetBackgroundColor(ColorSel);
                    horaInicio = hora.ToString() + ":30";
                };

                llhHoraInicio.AddView(HorarioView);
            });

            FindViewById<HorizontalScrollView>(Resource.Id.hsvHoraInicio).PostDelayed(delegate
            {
                if (Convert.ToInt32(Build.VERSION.Sdk) < 23)
                    FindViewById<HorizontalScrollView>(Resource.Id.hsvHoraInicio).ScrollTo(hora_actual * 75, 0);
                else
                    FindViewById<HorizontalScrollView>(Resource.Id.hsvHoraInicio).ScrollTo(hora_actual * 150, 0);
            }, 100);
        }
        void FillHorarioFin()
        {
            llhHoraFin.RemoveAllViews();
            //PutZeroHour();
            int hora_actual = DateTime.Now.Hour + 2;
            horas.AsParallel().ToList().ForEach(hora =>
            {
                View HorarioView = LayoutInflater.Inflate(Resource.Layout.HorarioSeleccionLayout, null, true);
                TextView Horario = HorarioView.FindViewById<TextView>(Resource.Id.lblHora);
                View vHora = HorarioView.FindViewById<View>(Resource.Id.vHora);
                TextView Minutos = HorarioView.FindViewById<TextView>(Resource.Id.lblMinuto);
                View vMinutos = HorarioView.FindViewById<View>(Resource.Id.vMinutos);

                Horario.Text = hora.ToString();
                txtHorasFin.Add(Horario);
                txtHorasFin.Add(Minutos);
                vHorasFin.Add(vHora);
                vHorasFin.Add(vMinutos);

                if (hora < hora_actual)
                {
                    Horario.SetTextColor(ColorBlock);
                    Minutos.SetTextColor(ColorBlock);
                }

                /*if (Intent.GetStringExtra("hora_fin").Contains(hora.ToString("D2")))
                {
                    if (Intent.GetStringExtra("hora_fin").Contains("30"))
                    {
                        Minutos.SetBackgroundColor(ColorSel);
                        vMinutos.SetBackgroundColor(ColorSel);
                        horaFin = hora.ToString() + ":30";
                    }
                    else
                    {
                        Horario.SetBackgroundColor(ColorSel);
                        vHora.SetBackgroundColor(ColorSel);
                        horaFin = hora.ToString() + ":00";
                    }
                }*/

                Horario.Click += delegate
                {
                    ClearScrollSelection(txtHorasFin, vHorasFin);
                    Horario.SetBackgroundColor(ColorSel);
                    vHora.SetBackgroundColor(ColorSel);
                    horaFin = hora.ToString() + ":00";
                };
                Minutos.Click += delegate
                {
                    ClearScrollSelection(txtHorasFin, vHorasFin);
                    Minutos.SetBackgroundColor(ColorSel);
                    vMinutos.SetBackgroundColor(ColorSel);
                    horaFin = hora.ToString() + ":30";
                };
                llhHoraFin.AddView(HorarioView);
            });
            FindViewById<HorizontalScrollView>(Resource.Id.hsvHoraFin).PostDelayed(delegate
            {
                if (Convert.ToInt32(Build.VERSION.Sdk) < 23)
                    FindViewById<HorizontalScrollView>(Resource.Id.hsvHoraFin).ScrollTo(hora_actual * 75, 0);
                else
                    FindViewById<HorizontalScrollView>(Resource.Id.hsvHoraFin).ScrollTo(hora_actual * 150, 0);
            }, 100);
        }
        void FillCantidad()
        {
            llhCantidad.RemoveAllViews();
            //PutZeroHour();
            totalPersonas.AsParallel().ToList().ForEach(numero =>
            {
                View CantidadView = LayoutInflater.Inflate(Resource.Layout.CantidadSeleccionLayout, null, true);
                TextView Cantidad = CantidadView.FindViewById<TextView>(Resource.Id.lblCantidad);
                View vCantidad = CantidadView.FindViewById<View>(Resource.Id.vCantidad);

                Cantidad.Text = numero.ToString();
                txtCantidad.Add(Cantidad);
                vCantidades.Add(vCantidad);

                /*if (Intent.GetStringExtra("cantidad_personas").Contains(numero.ToString()))
                {
                    Cantidad.SetBackgroundColor(ColorSel);
                    vCantidad.SetBackgroundColor(ColorSel);
                    CantidadPersonas = numero.ToString();
                }*/

                Cantidad.Click += delegate
                {
                    ClearScrollSelection(txtCantidad, vCantidades);
                    Cantidad.SetBackgroundColor(ColorSel);
                    vCantidad.SetBackgroundColor(ColorSel);
                    CantidadPersonas = numero.ToString();
                };
                llhCantidad.AddView(CantidadView);
            });
        }

        void ClearScrollSelection(List<TextView> labels, List<View> views)
        {
            labels.AsParallel().ToList().ForEach(label =>
            {
                label.SetBackgroundColor(Color.White);
            });
            views.AsParallel().ToList().ForEach(view =>
            {
                view.SetBackgroundColor(ColorUnSel);
            });
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }

        public override void OnBackPressed()
        {

            if (Tipo != (int)TipoSalaReunionFlujo.Editar)
            {
                if (Tipo == (int)TipoSalaReunionFlujo.Horario)
                    StartActivity(new Intent(this, typeof(ReservacionReunionActivity)));
                else
                    StartActivity(new Intent(this, typeof(ReservacionSalasActivity)));
            }
            else
            {
                Intent intent = new Intent(this, typeof(ReservacionSalaOpcionesActivity));
                intent.PutExtra("Opcion", "Editar");
                intent.PutExtra("Reservacion_Id", reservacion_id);
                intent.PutExtra("sala_id", Intent.GetStringExtra("sala_id"));
            }
            Finish();

        }
    }
}
