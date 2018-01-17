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
        Context context;
        List<string> titulos;
        MiembroModel miembro;
        View profileView;
        public PerfilPageAdapter(Context context, List<string> titulos, MiembroModel miembro)
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
                case 1: profileView = liView.Inflate(Resource.Layout.SobreMiSocialLayout, null, true); break;
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
            profileView.FindViewById<TextView>(Resource.Id.lblSobreMi);
            miembro.Miembro_Habilidades.Split(',').ToList().ForEach(habilidad => FillEtiqueta(habilidad, profileView.FindViewById<RelativeLayout>(Resource.Id.rlHabilidades)));
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
            Drawable icon = ContextCompat.GetDrawable(context, context.Resources.GetIdentifier("", "mipmap", context.PackageName));
            icon.SetTintList(context.GetColorStateList(Resource.Color.comment_pressed));
            icon.SetBounds(0, 0, 50, 50);
            TextView lblRedSocial = new TextView(context);

            lblRedSocial.SetCompoundDrawables(icon, null, null, null);
        }

        void FillTrabajo()
        {
            EmpresaModel empresa = new EmpresaController().GetEmpresaMiembro(miembro.Miembro_Id);
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View empresaView = liView.Inflate(Resource.Layout.TituloEmpresaLayout, null, true);
            empresaView.FindViewById<TextView>(Resource.Id.lblNombre).Text = empresa.Empresa_Miembro_Nombre;
            empresaView.FindViewById<TextView>(Resource.Id.lblPais).Text = empresa.Territorio_Estado_Descripcion;
            profileView.FindViewById<LinearLayout>(Resource.Id.llEmpleoActual).AddView(empresaView);
        }
    }
}
