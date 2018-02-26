
using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class AboutUsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AboutLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_general_about_us);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu_white);

            FindViewById<TextView>(Resource.Id.lblVersion).Text = GetString(Resource.String.str_version, PackageManager.GetPackageInfo(PackageName, 0).VersionName);

            FindViewById<TextView>(Resource.Id.lblFacebook).Click += delegate
            {
                    StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://www.facebook.com/worklabsmx")));
            };

            FindViewById<TextView>(Resource.Id.lblTwitter).Click += delegate
            {
                    StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://twitter.com/worklabsmx")));
            };

            FindViewById<TextView>(Resource.Id.lblInstagram).Click += delegate
            {
                try
                {
                    PackageManager.GetPackageInfo("com.instagram.android", 0);
                    StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("http://instagram.com/_u/worklabs.mx")));
                }
                catch (Exception e)
                {
                    StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("http://instagram.com/worklabs.mx")));
                }
            };
        }
        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();

            return base.OnOptionsItemSelected(item);
        }
    }
}
