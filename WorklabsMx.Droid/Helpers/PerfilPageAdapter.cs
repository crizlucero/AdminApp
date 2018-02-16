using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Graphics.Drawables;
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
            miembro.Etiquetas.ToList().ForEach(habilidad =>
            {
                if (habilidad.Etiqueta_Tipo == "Habilidad")
                    FillEtiqueta(habilidad.Etiqueta_Nombre, profileView.FindViewById<RelativeLayout>(Resource.Id.rlHabilidades));
                else if (habilidad.Etiqueta_Tipo == "Interes")
                    FillEtiqueta(habilidad.Etiqueta_Nombre, profileView.FindViewById<RelativeLayout>(Resource.Id.rlIntereses));
            });

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
