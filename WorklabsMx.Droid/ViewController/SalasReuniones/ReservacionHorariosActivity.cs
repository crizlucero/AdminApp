using System;
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Droid.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservacionHorariosActivity : Activity
    {
        LinearLayout llhHoraInicio, llhHoraFin, llhCantidad;
        List<TextView> txtHorasInicio, txtHorasFin, txtCantidad;
        List<View> vHorasInicio, vHorasFin, vCantidades;
        readonly List<int> horas, totalPersonas;
        string horaInicio, horaFin, CantidadPersonas;
        Color ColorSel = Color.Rgb(59, 219, 213), ColorUnSel = Color.Rgb(239, 239, 239);
        CalendarView cvFecha;

        public ReservacionHorariosActivity()
        {
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
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room_reservation);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            string Tipo = Intent.GetStringExtra("Tipo");
            string sala_seleccionada = Intent.GetStringExtra("sala_seleccionada");

            llhHoraInicio = FindViewById<LinearLayout>(Resource.Id.llhHoraInicio);
            llhHoraFin = FindViewById<LinearLayout>(Resource.Id.llhHoraFin);
            llhCantidad = FindViewById<LinearLayout>(Resource.Id.llhCantidad);
            cvFecha = FindViewById<CalendarView>(Resource.Id.cvFecha);
            DateTime currently = DateTime.Now;
            cvFecha.MinDate = new CalendarHelper().GetDateTimeMS(currently.Year, currently.Month - 1, currently.Day, 0, 0);


            FillHorarioInicio();
            FillHorarioFin();
            FillCantidad();

            FindViewById<Button>(Resource.Id.Avanzar).Click += delegate
            {
                Intent intent = new Intent(this, typeof(ReservacionSalasActivity));
                intent.PutExtra("Tipo", "horario");
                intent.PutExtra("fecha_seleccionada", cvFecha.Date.ToString("d"));
                intent.PutExtra("hora_inicio", horaInicio);
                intent.PutExtra("hora_fin", horaFin);
                intent.PutExtra("cantidad_personas", CantidadPersonas);

                StartActivity(intent);
            };
        }



        void FillHorarioInicio()
        {
            llhHoraInicio.RemoveAllViews();
            //PutZeroHour();
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
        }
        void FillHorarioFin()
        {
            llhHoraFin.RemoveAllViews();
            //PutZeroHour();
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
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }
    }
}
