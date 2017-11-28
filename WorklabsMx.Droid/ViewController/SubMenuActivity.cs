using System;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
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
            FillMenu(FindViewById<TableLayout>(Resource.Id.menu_layout));
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
        }

        void FillMenu(TableLayout menuLayout)
        {
            new EscritorioController().GetMenuAndroid(Convert.ToInt32(storage.Get("Usuario_Tipo")), storage.Get("Parent")).ForEach((menu) =>
            {
                TableRow row = new TableRow(this);
                Drawable icon = ContextCompat.GetDrawable(this, Resources.GetIdentifier(menu.Image, "mipmap", PackageName));
                icon.SetBounds(0, 0, 30, 30);
                Button btnMenu = new Button(this)
                {
                    Text = menu.Label,
                    TextAlignment = TextAlignment.ViewStart
                };
                btnMenu.SetWidth(Resources.DisplayMetrics.WidthPixels);
                btnMenu.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
                btnMenu.SetBackgroundColor(Color.White);
                btnMenu.SetCompoundDrawables(icon, null, null, null);
                btnMenu.Click += delegate
                {
                    switch (menu.Controller)
                    {
                        case "ReservaSalaJuntasActivity": StartActivity(new Intent(this, typeof(ReservaSalaJuntasActivity))); break;
                        case "RegistroInvitadosActivity": StartActivity(new Intent(this, typeof(RegistroInvitadosActivity))); break;
                        case "PerfilActivity": StartActivity(new Intent(this, typeof(TabPerfilActivity))); break;
                        case "DatosFacturacionActivity": StartActivity(new Intent(this, typeof(DatosFacturacionActivity))); break;
                        case "MisColaboradoresActivity": StartActivity(new Intent(this, typeof(TabColaboradoresActivity))); break;
                        case "MembresiasActivity": StartActivity(new Intent(this, typeof(MembresiasActivity))); break;
                        case "ProductosActivity": StartActivity(new Intent(this, typeof(ProductosActivity))); break;
                        case "ColeccionProductosActivity": StartActivity(new Intent(this, typeof(ColeccionProductosActivity))); break;
                        case "DirectorioUsuarioActivity": StartActivity(new Intent(this, typeof(DirectorioUsuariosActivity))); break;
                        case "DirectorioEmpresasActivity": StartActivity(new Intent(this, typeof(DirectorioEmpresaActivity))); break;
                    }
                };

                row.SetMinimumHeight(30);
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            });
        }
    }
}
