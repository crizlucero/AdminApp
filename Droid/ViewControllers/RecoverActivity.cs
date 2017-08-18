using System;
using Android.App;
using Android.OS;
using Android.Widget;
using WorklabsMx.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/Recovery")]
    public class RecoverActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.RecoveryLayout);

            EditText Email = FindViewById<EditText>(Resource.Id.txtRecoveryEmail);
            Button btnRecuperar = FindViewById<Button>(Resource.Id.btnRecoveryPassword);

            btnRecuperar.Touch += (sender, e) =>
            {
                try
                {
                    new Emails().SendMail(((EditText)sender).Text, "", "");
                }
                catch (Exception ex)
                {
                    SlackLogs.SendMessage(ex.Message);
                }
            };
        }
    }
}
