
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
using WorklabsMx.Models;

namespace WorklabsMx.Droid.Helpers
{
    public class MenuService : Activity
    {

        public void FillMenu(TableLayout menuLayout, Context context, SimpleStorage storage, string parent = null)
        {
            storage.Delete("Parent");
            foreach (ItemsMenu menu in new EscritorioController().GetMenuAndroid(Convert.ToInt32(storage.Get("Usuario_Tipo")), parent))
            {
                TableRow row = new TableRow(context);
                Drawable icon = ContextCompat.GetDrawable(context, context.Resources.GetIdentifier(menu.Image, "mipmap", context.PackageName));
                icon.SetBounds(0, 0, 30, 30);
                Button btnMenu = new Button(context)
                {
                    Text = menu.Label,
                    TextAlignment = TextAlignment.ViewStart

                };
                btnMenu.SetCompoundDrawables(icon, null, null, null);
                btnMenu.Click += delegate
                {
                    switch (menu.Controller)
                    {
                        case "MainActivity": StartActivity(new Intent(context, typeof(MainActivity))); break;
                        case "SubMenuActivity":
                            storage.Put("Parent", menu.Menu_Id);
                            StartActivity(new Intent(context, typeof(SubMenuActivity))); break;
                        case "LogoutActivity":
                            storage.Delete("Usuario_Id"); storage.Delete("Usuario_Tipo");
                            StartActivity(new Intent(context, typeof(MainActivity))); break;
                    }
                };

                row.SetMinimumHeight(30);
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            }
        }
    }
}
