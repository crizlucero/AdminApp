using System;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "SubMenuActivity")]
    public class SubMenuActivity : Activity
    {
        SimpleStorage storage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");

            SetContentView(Resource.Layout.MenuLayout);
            ScrollView menu_scroll = FindViewById<ScrollView>(Resource.Id.menu_scroll);
            menu_scroll.Visibility = ViewStates.Visible;
            menu_scroll.LayoutParameters.Height = Window.Attributes.Height;
			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
			ActionBar.Title = "Escritorio";
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            FillMenu(FindViewById<TableLayout>(Resource.Id.menu_layout));
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

		void FillMenu(TableLayout menuLayout)
		{
            foreach (ItemsMenu menu in new EscritorioController().GetMenuAndroid(Convert.ToInt32(storage.Get("Usuario_Tipo")),storage.Get("Parent")))
			{
				TableRow row = new TableRow(this);
				Drawable icon = ContextCompat.GetDrawable(this, Resources.GetIdentifier(menu.Image, "mipmap", PackageName));
				icon.SetBounds(0, 0, 30, 30);
				Button btnMenu = new Button(this)
				{
					Text = menu.Label,
					TextAlignment = TextAlignment.ViewStart

				};
				btnMenu.SetCompoundDrawables(icon, null, null, null);
				btnMenu.Click += delegate
				{
					switch (menu.Controller)
					{
                        case "PerfilActivity": StartActivity(new Intent(this, typeof(PerfilActivity))); break;
						case "DatosFacturacionActivity":
                        case "MisColaboradoresActivity":break;
					}
				};

				row.SetMinimumHeight(30);
				row.AddView(btnMenu);
				menuLayout.AddView(row);
			}
		}
    }
}
