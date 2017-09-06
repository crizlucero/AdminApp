
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace WorklabsMx.Droid.Fragments
{
    public class MyProfileFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			base.OnCreateView(inflater, container, savedInstanceState);

			var view = inflater.Inflate(
                Resource.Layout.PerfilLayout, container, false);

			var sampleTextView =
                view.FindViewById<TextView>(Resource.Id.txtProfileName);
			sampleTextView.Text = "sample fragment text";


			return view;
        }
    }
}
