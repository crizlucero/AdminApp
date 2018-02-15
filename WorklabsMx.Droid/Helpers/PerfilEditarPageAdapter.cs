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
    public class PerfilEditarPageAdapter : PagerAdapter
    {
        readonly Context context;
        List<string> titulos;
        readonly UsuarioModel miembro;
        View profileView;
        public PerfilEditarPageAdapter(Context context, List<string> titulos, UsuarioModel miembro)
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
                case 1: profileView = liView.Inflate(Resource.Layout.SobreMiSocialEditarLayout, null, true); break;
                case 2: profileView = liView.Inflate(Resource.Layout.SobreMiTrabajoEditarLayout, null, true); FillTrabajo(); break;
                default: profileView = liView.Inflate(Resource.Layout.SobreMiEditarLayout, null, true); FillSobreMi(); break;
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
            miembro.Etiquetas.ToList().ForEach(habilidad =>
            {
                if (habilidad.Etiqueta_Tipo == "Habilidad")
                    FillEtiqueta(habilidad.Etiqueta_Nombre, profileView.FindViewById<RelativeLayout>(Resource.Id.rlHabilidades));
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
            Drawable icon = ContextCompat.GetDrawable(context, context.Resources.GetIdentifier("", "mipmap", context.PackageName));
            icon.SetTintList(context.GetColorStateList(Resource.Color.comment_pressed));
            icon.SetBounds(0, 0, 50, 50);
            TextView lblRedSocial = new TextView(context);

            lblRedSocial.SetCompoundDrawables(icon, null, null, null);
        }

        void FillTrabajo()
        {
            profileView.FindViewById<TextView>(Resource.Id.lblAgregarExperiencia).Click += (sender, e) => profileView.FindViewById<GridLayout>(Resource.Id.glNuevoEmpleo).Visibility = ViewStates.Visible;
            profileView.FindViewById<Button>(Resource.Id.btnAgregar).Click += (sender, e) => profileView.FindViewById<GridLayout>(Resource.Id.glNuevoEmpleo).Visibility = ViewStates.Gone;
        }

    }
}
