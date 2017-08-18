
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Util;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid.ViewElement
{
    public class MenuView : Activity
    {
        //readonly Context context;
        public MenuView(Context context)
        {
            //this.context = context;
            Initialize();
        }
        void Initialize()
        {
        }

        public void FillMenu(TableLayout menuLayout, string tipo, string parent = null)
        {
            foreach (ItemsMenu menu in new EscritorioController().GetMenuAndroid(Convert.ToInt32(tipo), parent))
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
                btnMenu.Click += (sender, e) =>
                {
                    StartActivity(new Intent(this, Type.GetType(menu.Controller)));
                };

                row.SetMinimumHeight(30);
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            }


        }
    }
}
