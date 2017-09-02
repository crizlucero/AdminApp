
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

namespace WorklabsMx.Droid.Fragments
{
    public class MenuFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
			var textToDisplay = new StringBuilder().Insert(0, "The quick brown fox jumps over the lazy dog. ", 450).ToString();
			var view = inflater.Inflate(Resource.Layout.MenuLayout, container, false);

            //FillMenu();
            return view;
        }

		void FillMenu(TableLayout menuLayout, string tipo, string parent = null)
		{
            Context c = Application.Context;
			foreach (ItemsMenu menu in new EscritorioController().GetMenuAndroid(Convert.ToInt32(tipo), parent))
			{
				TableRow row = new TableRow(c);
				Drawable icon = ContextCompat.GetDrawable(c, Resources.GetIdentifier(menu.Image, "mipmap", c.PackageName));
				icon.SetBounds(0, 0, 30, 30);
				Button btnMenu = new Button(c)
				{
					Text = menu.Label,
					TextAlignment = TextAlignment.ViewStart

				};
				btnMenu.SetCompoundDrawables(icon, null, null, null);
				btnMenu.Click += (sender, e) =>
				{
					//Type activity = Type.GetType(menu.Controller, true);
					//Intent intent = new Intent(this, activity);
					//StartActivity(new Intent(this, activity));
				};

				row.SetMinimumHeight(30);
				row.AddView(btnMenu);
				menuLayout.AddView(row);
			}
		}
    }
}
