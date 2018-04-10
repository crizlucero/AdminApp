using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat")]
    public class LoginActivity : Activity
    {
        EditText txtEmail, txtPassword;
        SimpleStorage localStorage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LoginLayout);

            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtEmail.EditorAction += (sender, e) =>
            {
                if (Android.Util.Patterns.EmailAddress.Matcher(txtEmail.Text).Matches())
                {
                    if (e.ActionId == ImeAction.Done || e.ActionId == ImeAction.Next)
                    {
                        txtPassword.RequestFocus();
                    }
                }
                else Toast.MakeText(this, Resource.String.FormatoCorreoError, ToastLength.Short).Show();
            };

            txtPassword.EditorAction += (sender, e) =>
            {
                if (e.ActionId == ImeAction.Done)
                {
                    BtnLogin_Touch();
                }
            };
            btnLogin.Touch += (sender, e) => BtnLogin_Touch();
        }

        void BtnLogin_Touch()
        {
            txtEmail.Text = txtEmail.Text.Trim();
            if (Android.Util.Patterns.EmailAddress.Matcher(txtEmail.Text).Matches())
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    List<string> MiembrosId = new LoginController().MemberLogin(txtEmail.Text, txtPassword.Text);
                    if (MiembrosId.Count > 0)
                    {
                        localStorage = SimpleStorage.EditGroup("Login");
                        localStorage.Put("Usuario_Id", MiembrosId[0]);
                        localStorage.Put("Usuario_Tipo", MiembrosId[1]);
                        StartActivity(new Intent(this, typeof(MainActivity)));
                        Finish();
                    }
                    else
                    {
                        Toast.MakeText(this, Resource.String.str_login_error, ToastLength.Short).Show();
                    }
                }
                else Toast.MakeText(this, Resource.String.PasswordIncorrecto, ToastLength.Short).Show();
            }
            else
                Toast.MakeText(this, Resource.String.FormatoCorreoError, ToastLength.Short).Show();
        }
    }
}
