using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class AccesoActivity : Activity
    {
        string strAcceso = string.Empty;
        WebView qrCode;
        SimpleStorage storageLocal;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AccesoLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_general_access);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            storageLocal = SimpleStorage.EditGroup("Login");
            strAcceso = new UsuariosController().GetLlaveAcceso(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));
            qrCode = FindViewById<WebView>(Resource.Id.wvQRCode);
            string url = "https://api.qrserver.com/v1/create-qr-code/?data=" + Uri.EscapeUriString(strAcceso);
            qrCode.LoadUrl(url);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.refresh_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_refresh:
                    RefreshAccess();
                    break;
                default:
                    OnBackPressed();
                    break;
            }

            return base.OnOptionsItemSelected(item);
        }

        void RefreshAccess()
        {
            string newAcceso = new UsuariosController().GetLlaveAcceso(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));
            if (!strAcceso.Equals(newAcceso))
            {
                qrCode.LoadUrl("https://api.qrserver.com/v1/create-qr-code/?data=" + Uri.EscapeUriString(strAcceso = newAcceso));
            }
            else
                Console.WriteLine(newAcceso);
        }

		public override void OnBackPressed()
		{
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
		}
	}
}