using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Com.Mitec.Suitemcommerce.Beans;
using Com.Mitec.Suitemcommerce.Controller;
using Com.Mitec.Suitemcommerce.Utilities;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Enum;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class PaymentActivity : Activity, ISuiteControllerDelegate
    {
        readonly PagosController controller;
        readonly SimpleStorage storage;

        AlertDialog.Builder dialog;
        static ProgressDialog progressDialog;

        SuiteController suiteController;
        Bean3DS bean3DS;
        BeanTokenization beanTokenization;

        public PaymentActivity()
        {
            controller = new PagosController();
            storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PagoLayout);



            dialog = new AlertDialog.Builder(this);
            dialog.SetPositiveButton("Aceptar", delegate
            {

            });
            dialog.SetCancelable(false);

            progressDialog = new ProgressDialog(this);
            progressDialog.SetMessage("Procesando operación");

            suiteController = new SuiteController(Com.Mitec.Suitemcommerce.Utilities.Environment.Qa, this, this);
            beanTokenization = new BeanTokenization
            {
                Branch = "000025",
                Company = "Z703",
                Country = "MEX",
                User = "Z703CSES0",
                Password = "OOMYO17MS7",
                Merchant = "158198",
                Currency = Currency.Mxn,
                OperationType = "6",
                Reference = "Referencia dada por el usuario",
                Amount = "100.00",
                Token = "1234567890124242"

            };
            bean3DS = new Bean3DS
            {
                Branch = "000025",
                Company = "Z703",
                Country = "MX",
                User = "Z703CSES0",
                Password = "OOMYO17MS7",
                Merchant = "158128",
                Currency = Currency.Mxn,
                Reference = "Referencia dada por el usuario",
                AuthKey = "516883685552545048505454"
            };
            suiteController.Authenticate(beanTokenization, bean3DS);
            suiteController.SndPayWithToken(beanTokenization, bean3DS);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.payment_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            base.OnBackPressed();
            Finish();
            return base.OnOptionsItemSelected(item);
        }

        public void CanceledProcessByUser()
        {
            base.OnBackPressed();
            Finish();
        }

        public void DidFinishAuthenticationProcess(BeanTokenizeResponse beanTokenizeResponse, SuiteError suiteError)
        {

            progressDialog.Dismiss();
            if (beanTokenizeResponse != null)
            {
                Intent intent = new Intent(this, typeof(ResultActivity));
                intent.PutExtra("beanTokenizeResponse", beanTokenizeResponse);
                StartActivity(intent);
            }
            if (suiteError != null)
            {
                Utilities.Println("didFinishAuthenticationProcess " + suiteError);
                DialogAlert("Error", suiteError.Error);
            }
        }

        void DialogAlert(string title, string message)
        {
            dialog.SetTitle(title);
            dialog.SetMessage(message);

            dialog.Show();
        }

        public void DidFinishPayProcess(string p0, SuiteError p1)
        {
            progressDialog.Dismiss();
            DialogAlert("Operación", "Operación cancelada por el usuario");
        }

        public void DidFinishTokenizeTransaction(BeanPaymentWithToken p0, SuiteError p1)
        {
        }

        class Authenticate : AsyncTask<Java.Lang.Void, Java.Lang.Void, Java.Lang.Void>
        {
            readonly SuiteController suiteController;
            readonly BeanTokenization beanTokenization;
            readonly Bean3DS bean3DS;
            public Authenticate(SuiteController suiteController, BeanTokenization beanTokenization, Bean3DS bean3DS)
            {
                this.suiteController = suiteController;
                this.beanTokenization = beanTokenization;
                this.bean3DS = bean3DS;
            }

            protected override Java.Lang.Void RunInBackground(params Java.Lang.Void[] @params)
            {
                suiteController.Authenticate(beanTokenization, bean3DS);
                return null;
            }
        }
    }
}