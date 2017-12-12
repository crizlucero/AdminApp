
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class SalasJuntasActivity : FragmentActivity
    {
        private ViewPager _viewPager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReservaSalaJuntasLayout);

            _viewPager = FindViewById<ViewPager>(Resource.Id.vpDemo);
            _viewPager.Adapter = new SalaJuntasAdapter(this, new List<SalaJuntasModel>());
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

        public override Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View SucursalView = liView.Inflate(Resource.Layout.SalasJuntasLayout, null, true);
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(SucursalView);
            return SucursalView;
        }

        public override int Count => salaJuntas.Count;

        public override bool IsViewFromObject(View view, Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new String(salaJuntas[position].Sala_Descripcion);

        public override void DestroyItem(View container, int position, Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);
    }
}
