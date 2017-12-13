
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
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class SalasJuntasActivity : FragmentActivity
    {
        ViewPager _viewPager;
        List<int> HorasSeleccionadas;
        List<int> HorasNoDisponibles;

        public SalasJuntasActivity()
        {
            HorasSeleccionadas = new List<int>();
            HorasNoDisponibles = new List<int> { 12, 14, 10 };
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
            List<SalaJuntasModel> salas = new SalasJuntasController().GetSalaJuntas();
            _viewPager.Adapter = new SalaJuntasAdapter(this, salas);
            FillHorario();
        }

        void FillHorario()
        {
            LinearLayout llhHorario = FindViewById<LinearLayout>(Resource.Id.llhHorario);
            for (int i = 1; i < 25; i++)
            {
                LayoutInflater liView = LayoutInflater;
                View HorarioView = liView.Inflate(Resource.Layout.HorarioItemLayout, null, true);
                if (i < 24)
                    HorarioView.FindViewById<TextView>(Resource.Id.lblHora).Text = i.ToString();
                else
                    HorarioView.FindViewById<TextView>(Resource.Id.lblHora).Text = "0";
                ImageView horario = HorarioView.FindViewById<ImageView>(Resource.Id.ivHora);
                if(HorasNoDisponibles.Contains(i)){
                    horario.SetBackgroundColor(Color.Rgb(85, 85, 85));
                    horario.SetImageResource(Resource.Mipmap.ic_diagonal_lines);
                }
                HorarioView.FindViewById<ImageView>(Resource.Id.ivHora).Click += (sender, e) =>
                {
                    if (!HorasSeleccionadas.Contains(i))
                    {
                        ((ImageView)sender).SetBackgroundColor(Color.Rgb(162, 219, 255));
                        HorasSeleccionadas.Add(i);
                    }
                    else
                    {
                        ((ImageView)sender).SetBackgroundColor(Color.Rgb(225, 252, 195));
                        HorasSeleccionadas.Remove(i);
                    }
                };
                llhHorario.AddView(HorarioView);
            }
            FindViewById<HorizontalScrollView>(Resource.Id.hsvHorario).ScrollTo(DateTime.Now.Hour * 100, 0);
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
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
