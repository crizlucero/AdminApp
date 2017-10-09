using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidHUD;

namespace WorklabsMx.Droid
{
    [Activity(Label = "PaymentActivity")]
    public class PaymentActivity : Activity
    {
        decimal Descuento, Subtotal, Total, IVATotal;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PagoLayout);

			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
			ActionBar.Title = Resources.GetString(Resource.String.RealizaPago);
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			//ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            Descuento = Convert.ToDecimal(Intent.GetStringExtra("Descuento"));
            Subtotal = Convert.ToDecimal(Intent.GetStringExtra("Subtotal"));
            IVATotal = Convert.ToDecimal(Intent.GetStringExtra("IVA"));
            Total = Convert.ToDecimal(Intent.GetStringExtra("Total"));
            FillPrices();
        }

        void FillPrices()
        {
            FindViewById<TextView>(Resource.Id.tvSubtotal).Text = Subtotal.ToString("C");
            FindViewById<TextView>(Resource.Id.tvDescuento).Text = Descuento.ToString("C");
            FindViewById<TextView>(Resource.Id.tvIVA).Text = IVATotal.ToString("C");
            FindViewById<TextView>(Resource.Id.tvTotal).Text = Total.ToString("C");
        }

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.payment_menu, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId)
			{
				case Resource.Id.menu_payment:
                    AndHUD.Shared.Show(this, Resources.GetString(Resource.String.RealizandoPago), -1, MaskType.Black);
                    Console.WriteLine("x");
                    //AndHUD.Shared.Dismiss(this);
					break;
				default:
					base.OnBackPressed();
					break;
			}
			return base.OnOptionsItemSelected(item);
		}
    }
}