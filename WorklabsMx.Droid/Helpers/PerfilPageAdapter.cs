﻿using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    public class PerfilPageAdapter : PagerAdapter
    {
        Context context;
        List<string> titulos;
        MiembroModel miembro;
        public PerfilPageAdapter(Context context, List<string> titulos, MiembroModel miembro)
        {
            this.context = context;
            this.titulos = titulos;
            this.miembro = miembro;
        }

        public override Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View profileView = liView.Inflate(Resource.Layout.DatosGeneralesLayout, null, true);

            profileView.FindViewById<TextView>(Resource.Id.lblPuesto).Text = miembro.Miembro_Puesto;
            profileView.FindViewById<TextView>(Resource.Id.lblProfesion).Text = miembro.Miembro_Profesion;
            profileView.FindViewById<TextView>(Resource.Id.lblFechaNacimiento).Text = miembro.Miembro_Fecha_Nacimiento;

            TextView txtPhone = profileView.FindViewById<TextView>(Resource.Id.lblContacto);
            txtPhone.Text = miembro.Miembro_Celular;
            txtPhone.Click += delegate
            {
                try
                {
                    var uri = Android.Net.Uri.Parse("tel:" + miembro.Miembro_Celular);
                    var intent = new Intent(Intent.ActionDial, uri);
                    context.StartActivity(intent);
                }
                catch (System.Exception ex)
                {
                    SlackLogs.SendMessage(ex.Message);
                }
            };

            TextView txtEmail = profileView.FindViewById<TextView>(Resource.Id.lblCorreo);
            txtEmail.Text = miembro.Miembro_Correo_Electronico;
            txtEmail.Click += delegate
            {
                try
                {
                    Intent email = new Intent(Intent.ActionSend);
                    email.PutExtra(Intent.ExtraEmail,
                                   new string[] { miembro.Miembro_Correo_Electronico });
                    email.PutExtra(Intent.ExtraSubject, context.Resources.GetString(Resource.String.AsuntoCorreo));
                    email.SetType("message/rfc822");
                    context.StartActivity(email);
                }
                catch (System.Exception ex)
                {
                    SlackLogs.SendMessage(ex.Message);
                }
            };
            profileView.FindViewById<TextView>(Resource.Id.lblFacebook).Text = "";
            profileView.FindViewById<TextView>(Resource.Id.lblInstagram).Text = "";
            profileView.FindViewById<TextView>(Resource.Id.lblTwitter).Text = "";
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(profileView);
            return profileView;
        }

        public override int Count => titulos.Count;

        public override bool IsViewFromObject(View view, Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new String(titulos[position]);

        public override void DestroyItem(View container, int position, Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);
    }
}
