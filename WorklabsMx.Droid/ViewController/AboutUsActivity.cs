using Android.App;
using Android.Content;
using Android.Net;
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

            FindViewById<TextView>(Resource.Id.lblVersion).Text = GetString(Resource.String.str_version, PackageManager.GetPackageInfo(PackageName, 0).VersionName);

            FindViewById<TextView>(Resource.Id.lblFacebook).Click += delegate
            {
                Intent intent;
                try
                {
                    PackageManager.GetPackageInfo("com.facebook.katana", 0);
                    intent = new Intent(Intent.ActionView, Uri.Parse("fb://page/1214192658624957"));
                }
                catch
                {
                    intent = new Intent(Intent.ActionView, Uri.Parse("https://www.facebook.com/worklabsmx"));
                }
                intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            };

            FindViewById<TextView>(Resource.Id.lblTwitter).Click += delegate
            {
                Intent intent;
                try
                {
                    PackageManager.GetPackageInfo("com.twitter.android", 0);
                    intent = new Intent(Intent.ActionView, Uri.Parse("twitter://user?user_id=3519294614"));
                }
                catch
                {
                    intent = new Intent(Intent.ActionView, Uri.Parse("https://twitter.com/worklabsmx"));
                }
                intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            };

            FindViewById<TextView>(Resource.Id.lblInstagram).Click += delegate
            {
                Intent intent;
                try
                {
                    PackageManager.GetPackageInfo("com.instagram.android", 0);
                    intent = new Intent(Intent.ActionView, Uri.Parse("http://instagram.com/_u/worklabs.mx"));
                }
                catch
                {
                    intent = new Intent(Intent.ActionView, Uri.Parse("http://instagram.com/worklabs.mx"));
                }
                intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent);
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
