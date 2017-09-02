
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
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid.Droid
{
    public class LoginFragment : Android.Support.V4.App.Fragment, IFragmentVisible
    {
        public static LoginFragment NewInstance() =>
            new LoginFragment { Arguments = new Bundle() };

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.LoginLayout, container, false);
            SimpleStorage.SetContext(view.Context);

            var storage = SimpleStorage.EditGroup("Login");
            EditText txtEmail = view.FindViewById<EditText>(Resource.Id.txtEmail);
            EditText txtPassword = view.FindViewById<EditText>(Resource.Id.txtPassword);
            Button btnLogin = view.FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Touch += (sender, e) =>
            {
                List<string> MiembrosId = new LoginController().MemberLogin(txtEmail.Text, new PassSecurity().EncodePassword(txtPassword.Text));
                if (MiembrosId.Count > 0)
                {
                    var localStorage = SimpleStorage.EditGroup("Login");
                    localStorage.Put("Usuario_Id", MiembrosId[0]);
                    localStorage.Put("Usuario_Tipo", MiembrosId[1]);
                    //OpenDashboard();
                }
                else
                    Toast.MakeText(view.Context, Resource.String.LoginError, ToastLength.Short);
            };
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

		public void BecameVisible()
		{

		}
    }
}
