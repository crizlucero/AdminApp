using System;
using Android.App;
using Android.Content;
using Android.OS;
using PerpetualEngine.Storage;
using WorklabsMx.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //var storage = SimpleStorage.EditGroup("Login");
            //if (!string.IsNullOrEmpty(storage.Get("Usuario_Id")) && !string.IsNullOrEmpty(storage.Get("Usuario_Tipo")))
            //{

            //}
            //else
            //{
                StartActivity(typeof(LoginActivity));
            //}
        }
    }
}