using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using AndroidHUD;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/SplashTheme", MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var newIntent = new Intent(this, typeof(MainActivity));
            newIntent.AddFlags(ActivityFlags.ClearTop);
            newIntent.AddFlags(ActivityFlags.SingleTop);
            //AndHUD.Shared.Show(this, null, -1, MaskType.Black);
            StartActivity(newIntent);
            Finish();
        }
    }
}
