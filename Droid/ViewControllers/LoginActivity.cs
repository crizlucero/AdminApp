﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/Login")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LoginLayout);

            EditText email = FindViewById<EditText>(Resource.Id.txtEmail);
            EditText password = FindViewById<EditText>(Resource.Id.txtPassword);

            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Touch += (sender, e)=>{
				List<string> MiembrosId = new LoginController().MemberLogin(email.Text, new PassSecurity().EncodePassword(password.Text));
				if (MiembrosId.Count > 0)
				{
					var localStorage = SimpleStorage.EditGroup("Login");
					localStorage.Put("Usuario_Id", MiembrosId[0]);
					localStorage.Put("Usuario_Tipo", MiembrosId[1]);
				}
				else
				{
                    Toast.MakeText(this, "Correo y/o contraseña incorrecto", ToastLength.Short).Show();
				}
            };
            Button btnRecover = FindViewById<Button>(Resource.Id.btnForget);
            btnRecover.Touch += (sender, e) => {
                
            };
        }
    }
}
