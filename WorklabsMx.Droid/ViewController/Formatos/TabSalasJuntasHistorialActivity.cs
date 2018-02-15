using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using com.refractored;
using Java.Lang;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class TabSalasJuntasHistorialActivity : FragmentActivity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalasJuntasHistorialesLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.SalasJuntas);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.vpHistorial);
            _viewPager.Adapter = new HistorialesAdapter(this, new List<string> { Resources.GetString(Resource.String.Recientes),
                Resources.GetString(Resource.String.Historico),
                Resources.GetString(Resource.String.Canceladas) });

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.add_element_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_add_element:
                    StartActivity(new Intent(this, typeof(SalasJuntasSucursalActivity)));
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
    class HistorialesAdapter : PagerAdapter
    {
        readonly Context context;
        List<string> historiales;
        SimpleStorage storage;
        View SalasView;
        List<SalaJuntasReservacionModel> historico;
        readonly SalasJuntasController controller;

        public HistorialesAdapter(Context context, List<string> historiales)
        {
            this.context = context;
            this.historiales = historiales;
            storage = SimpleStorage.EditGroup("Login");
            controller = new SalasJuntasController();
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            SalasView = liView.Inflate(Resource.Layout.SalaJuntasHistorialLayout, null, true);
            var viewPager = container.JavaCast<ViewPager>();
            historico = controller.GetReservaciones(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), historiales[position] == context.Resources.GetString(Resource.String.Recientes) ? 1 :
                                                                     historiales[position] == context.Resources.GetString(Resource.String.Historico) ? 2 : 0);
            SwipeRefreshLayout refresher = SalasView.FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_container);
            refresher.SetColorSchemeColors(Color.Gray, Color.LightGray, Color.Gray, Color.DarkGray, Color.Black, Color.DarkGray);
            refresher.Refresh += (sender, e) =>
            {
                historico = controller.GetReservaciones(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), historiales[position] == context.Resources.GetString(Resource.String.Recientes) ? 1 :
                                                                     historiales[position] == context.Resources.GetString(Resource.String.Historico) ? 2 : 0);
                HistorialValidation();
                ((SwipeRefreshLayout)sender).Refreshing = false;
            };
            HistorialValidation();

            viewPager.AddView(SalasView);
            return SalasView;
        }

        public override int Count => historiales.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new Java.Lang.String(historiales[position]);

        public override void DestroyItem(View container, int position, Java.Lang.Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);

        void HistorialValidation()
        {
            if (historico.Count > 0)
            {
                FillHistorial();
                SalasView.FindViewById<TextView>(Resource.Id.lblSalaJunta).Text = historico[0].Sala_Descripcion;
                SalasView.FindViewById<TextView>(Resource.Id.lblDiaSemana).Text = DateTime.Parse(historico[0].Sala_Fecha).Day.ToString();
                SalasView.FindViewById<TextView>(Resource.Id.lblDia).Text = DateTime.Parse(historico[0].Sala_Fecha).DayOfWeek.ToString();
                SalasView.FindViewById<TextView>(Resource.Id.lblHorario).Text = historico[0].Sala_Hora_Inicio.Substring(0, 5) + " - " + historico[0].Sala_Hora_Fin.Substring(0, 5);
            }
            else
            {
                SalasView.FindViewById<TextView>(Resource.Id.lblDiaSemana).Text = "Sin Reservaciones";
                SalasView.FindViewById<TextView>(Resource.Id.lblSalaJunta).Text = "";
                SalasView.FindViewById<TextView>(Resource.Id.lblDia).Text = "";
                SalasView.FindViewById<TextView>(Resource.Id.lblHorario).Text = "";
            }
        }

        void FillHistorial()
        {
            TableLayout table = SalasView.FindViewById<TableLayout>(Resource.Id.historial_table);
            table.RemoveAllViews();
            historico.ForEach(reservacion =>
            {
                LayoutInflater inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
                View ReservaView = inflater.Inflate(Resource.Layout.ReservacionElementoLayout, null, true);
                ReservaView.FindViewById<TextView>(Resource.Id.lblSalaJunta).Text = reservacion.Sala_Descripcion;
                ReservaView.FindViewById<TextView>(Resource.Id.lblDiaSemana).Text = DateTime.Parse(reservacion.Sala_Fecha).Day.ToString();
                ReservaView.FindViewById<TextView>(Resource.Id.lblDia).Text = DateTime.Parse(reservacion.Sala_Fecha).DayOfWeek.ToString();
                ReservaView.FindViewById<TextView>(Resource.Id.lblHorario).Text = reservacion.Sala_Hora_Inicio.Substring(0, 5) + " - " + reservacion.Sala_Hora_Fin.Substring(0, 5);
                ReservaView.FindViewById<ImageButton>(Resource.Id.btnCancelar).Click += delegate
                {
                    if (controller.CancelarSalaJuntas("Baja", reservacion.Sala_Junta_Reservacion_Id)){
                        Toast.MakeText(context, Resource.String.str_meeting_room_canceled, ToastLength.Short).Show();
                        historico.Remove(reservacion);
                        HistorialValidation();
                    }else
                        Toast.MakeText(context, Resource.String.ErrorIntento, ToastLength.Short).Show();
                };

                TableRow row = new TableRow(context);
                row.AddView(ReservaView);
                table.AddView(row);
            });
        }
    }
}
