using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Content.PM;
using Android.Graphics.Drawables;
using Android.Net;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    public class PerfilPageAdapter : PagerAdapter
    {
        readonly Context context;
        List<string> titulos;
        readonly UsuarioModel miembro;
        View profileView;
        public PerfilPageAdapter(Context context, List<string> titulos, UsuarioModel miembro)
        {
            this.context = context;
            this.titulos = titulos;
            this.miembro = miembro;
        }

        public override Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            switch (position)
            {
                case 1: profileView = liView.Inflate(Resource.Layout.SobreMiSocialLayout, null, true); FillSocial(); break;
                case 2: profileView = liView.Inflate(Resource.Layout.SobreMiTrabajoLayout, null, true); FillTrabajo(); break;
                default: profileView = liView.Inflate(Resource.Layout.SobreMiLayout, null, true); FillSobreMi(); break;
            }
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(profileView);
            return profileView;
        }

        public override int Count => titulos.Count;

        public override bool IsViewFromObject(View view, Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new String(titulos[position]);

        public override void DestroyItem(View container, int position, Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);

        void FillSobreMi()
        {
            profileView.FindViewById<TextView>(Resource.Id.lblSobreMi).Text = miembro.Usuario_Descripcion;
            if (!string.IsNullOrEmpty(miembro.Usuario_Telefono))
            {
                TextView telefono = profileView.FindViewById<TextView>(Resource.Id.lblTelefono);
                telefono.Text = miembro.Usuario_Telefono;
                telefono.Click += Telefono_Click;
            }

            if (!string.IsNullOrEmpty(miembro.Usuario_Celular))
            {
                TextView celular = profileView.FindViewById<TextView>(Resource.Id.lblCelular);
                celular.Text = miembro.Usuario_Celular;
                celular.Click += Telefono_Click;
            }

            if (!string.IsNullOrEmpty(miembro.Usuario_Correo_Electronico))
            {
                TextView correo = profileView.FindViewById<TextView>(Resource.Id.lblCorreo);
                correo.Text = miembro.Usuario_Correo_Electronico;
                correo.Click += (sender, e) =>
                {
                    var email = new Intent(Intent.ActionSend);
                    email.PutExtra(Intent.ExtraEmail, new string[] { miembro.Usuario_Correo_Electronico });

                    email.PutExtra(Intent.ExtraSubject, "Contacto desde Worklabs");

                    email.PutExtra(Intent.ExtraText, "");
                    email.SetType("message/rfc822");
                    context.StartActivity(email);
                };
            }

            miembro.Etiquetas.ToList().ForEach(habilidad =>
            {
                if (habilidad.Etiqueta_Tipo == "Habilidad")
                    FillEtiqueta(habilidad.Etiqueta_Nombre, profileView.FindViewById<RelativeLayout>(Resource.Id.rlHabilidades));
                else if (habilidad.Etiqueta_Tipo == "Interes")
                    FillEtiqueta(habilidad.Etiqueta_Nombre, profileView.FindViewById<RelativeLayout>(Resource.Id.rlIntereses));
            });

        }

        void Telefono_Click(object sender, System.EventArgs e)
        {
            Intent intent;
            try { intent = context.PackageManager.GetLaunchIntentForPackage("mx.worklabs"); }
            catch
            {
                intent = new Intent(Intent.ActionView, Uri.Parse("market://details?id=mx.worklabs"));
                intent.AddFlags(ActivityFlags.NewTask);
            }

            context.StartActivity(intent);
        }

        void FillEtiqueta(string etiqueta, RelativeLayout rlEtiqueta)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View etiquetaView = liView.Inflate(Resource.Layout.EtiquetasLayout, null, true);
            etiquetaView.FindViewById<TextView>(Resource.Id.lblEtiqueta).Text = etiqueta;
            rlEtiqueta.AddView(etiquetaView);
        }

        void FillSocial()
        {
            profileView.FindViewById<TextView>(Resource.Id.lblTotalPublicaciones).Text = miembro.Red_Social_Publicaciones;
            profileView.FindViewById<TextView>(Resource.Id.lblTotalSiguiendo).Text = miembro.Red_Social_Siguiendo;
            profileView.FindViewById<TextView>(Resource.Id.lblTotalSeguidores).Text = miembro.Red_Social_Seguidores;
        }

        void FillTrabajo()
        {
            EmpresaModel empresa = new EmpresaController().GetEmpresaMiembro(miembro.Usuario_Id);
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View empresaView = liView.Inflate(Resource.Layout.TituloEmpresaLayout, null, true);
            empresaView.FindViewById<TextView>(Resource.Id.lblNombre).Text = empresa.Empresa_Miembro_Nombre;
            empresaView.FindViewById<TextView>(Resource.Id.lblPais).Text = empresa.Territorio.Pais;
            profileView.FindViewById<LinearLayout>(Resource.Id.llEmpleoActual).AddView(empresaView);
        }
    }
}
