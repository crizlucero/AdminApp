
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "AccesoActivity")]
    public class AccesoActivity : Activity
    {
        string strAcceso = string.Empty;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AccesoLayout);
			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Acceso);
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            var storageLocal = SimpleStorage.EditGroup("Login");
            strAcceso = new MiembrosController().GetLlaveAcceso(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));
            WebView qrCode = FindViewById<WebView>(Resource.Id.wvQRCode);
            string url = "https://api.qrserver.com/v1/create-qr-code/?data=" + strAcceso;
            qrCode.LoadUrl(url);
        }

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			//MenuInflater.Inflate(Resource.Menu.top_menus, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			base.OnBackPressed(); 
			return base.OnOptionsItemSelected(item);
		}
    }
}
