using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using PerpetualEngine.Storage;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/SplashTheme", MainLauncher = true, Icon = "@mipmap/icon")]
    public class SplashActivity : AppCompatActivity
    {
        SimpleStorage localStorage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SimpleStorage.SetContext(ApplicationContext);
            localStorage = SimpleStorage.EditGroup("Login");
            Intent newIntent;
            if (localStorage.HasKey("Usuario_Id") && localStorage.HasKey("Usuario_Tipo"))
                newIntent = new Intent(this, typeof(MainActivity));
            else
                newIntent = new Intent(this, typeof(LoginActivity));
            newIntent.AddFlags(ActivityFlags.ClearTop);
            newIntent.AddFlags(ActivityFlags.SingleTop);
            StartActivity(newIntent);
            Finish();
        }
    }
}
