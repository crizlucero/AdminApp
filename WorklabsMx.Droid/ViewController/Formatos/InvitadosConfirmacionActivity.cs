using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Newtonsoft.Json;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "InvitadosConfirmacionActivity")]
    public class InvitadosConfirmacionActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ConfirmacionInvitacionesLayout);

            List<VisitaModel> invitados = new InvitadosController().GetInvitados(JsonConvert.DeserializeObject<List<int>>(Intent.GetStringExtra("Invitados_Id")));
            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.vpInvitaciones);
            _viewPager.Adapter = new ConfirmacionInvitadoAdapter(this, invitados);
            FindViewById<ImageView>(Resource.Id.btnPrevio).Click += delegate
            {
                _viewPager.SetCurrentItem(_viewPager.CurrentItem - 1, true);
            };
            FindViewById<ImageView>(Resource.Id.btnSiguiente).Click += delegate
            {
                _viewPager.SetCurrentItem(_viewPager.CurrentItem + 1, true);
            };
            FindViewById<ImageView>(Resource.Id.btnCerrar).Click += delegate
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
                Finish();
            };
        }

        public override void OnBackPressed()
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }
    }

    class ConfirmacionInvitadoAdapter : PagerAdapter
    {
        Context context;
        List<VisitaModel> invitados;

        public ConfirmacionInvitadoAdapter(Context context, List<VisitaModel> invitados)
        {
            this.context = context;
            this.invitados = invitados;
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View invitadoView = liView.Inflate(Resource.Layout.ConfirmacionInvitadoLayout, null, true);
            invitadoView.FindViewById<TextView>(Resource.Id.lblNombre).Text = invitados[position].Visita_Nombre + " " + invitados[position].Visita_Apellidos;
            invitadoView.FindViewById<TextView>(Resource.Id.lblFecha).Text = invitados[position].Visita_Fecha_Entrada;
            invitadoView.FindViewById<TextView>(Resource.Id.lblSucursal).Text = invitados[position].Sucursal.Sucursal_Descripcion;
            invitadoView.FindViewById<TextView>(Resource.Id.lblDireccion).Text = invitados[position].Sucursal.Sucursal_Domicilio + " " + invitados[position].Sucursal.Sucursal_No_Exterior +
                (!string.IsNullOrEmpty(invitados[position].Sucursal.Sucursal_No_Interior) ? " int. " + invitados[position].Sucursal.Sucursal_No_Interior : "");
            invitadoView.FindViewById<TextView>(Resource.Id.lblColonia).Text = invitados[position].Sucursal.Territorio.Colonia;
            WebView qrCode = invitadoView.FindViewById<WebView>(Resource.Id.wvQRCode);
            string url = "https://api.qrserver.com/v1/create-qr-code/?data=" + Uri.EscapeUriString(invitados[position].Visita_Codigo_Acceso);
            qrCode.LoadUrl(url);

            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(invitadoView);
            return invitadoView;
        }
        public override int Count => invitados.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object) => view == @object;

        void FillInvitaciones()
        {

        }
    }
}
