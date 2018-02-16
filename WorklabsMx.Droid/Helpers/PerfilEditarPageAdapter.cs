using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using Java.Lang;
using WorklabsMx.Controllers;
using WorklabsMx.Enum;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    public class PerfilEditarPageAdapter : PagerAdapter
    {
        readonly Context context;
        List<string> titulos;
        List<EtiquetaModel> etiquetas;
        readonly UsuarioModel miembro;
        View profileView;
        public PerfilEditarPageAdapter(Context context, List<string> titulos, UsuarioModel miembro)
        {
            this.context = context;
            this.titulos = titulos;
            this.miembro = miembro;
            etiquetas = new PickerItemsController().GetEtiquetas();
        }

        public override Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            switch (position)
            {
                case 1: profileView = liView.Inflate(Resource.Layout.SobreMiSocialEditarLayout, null, true); FillSocial(); break;
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
            profileView.FindViewById<TextView>(Resource.Id.txtSobreMi).Text = miembro.Usuario_Descripcion;
            EditText txtHabilidades = profileView.FindViewById<EditText>(Resource.Id.txtHabilidades);
            //txtHabilidades.Adapter = FillAdapterEtiquetas(TipoEtiquetas.Habilidad);
            txtHabilidades.EditorAction += Etiqueta_KeyPress;
            EditText txtIntereses = profileView.FindViewById<EditText>(Resource.Id.txtIntereses);
            //txtHabilidades.Adapter = FillAdapterEtiquetas(TipoEtiquetas.Interes);
            txtIntereses.EditorAction += Etiqueta_KeyPress;
            miembro.Etiquetas.ToList().ForEach(habilidad =>
            {
                if (habilidad.Etiqueta_Tipo == "Habilidad")
                    FillEtiqueta(habilidad.Etiqueta_Nombre, profileView.FindViewById<RelativeLayout>(Resource.Id.rlHabilidades));
            });
        }

        void Etiqueta_KeyPress(object sender, TextView.EditorActionEventArgs e)
        {
            if (e.ActionId == ImeAction.Done)
            {
                TipoEtiquetas etiqueta_tipo;
                if (((EditText)sender).Id == Resource.Id.txtHabilidades)
                    etiqueta_tipo = TipoEtiquetas.Habilidad;
                else
                    etiqueta_tipo = TipoEtiquetas.Interes;
                string etiqueta_id;
                try
                {
                    etiqueta_id = etiquetas.Find(etiqueta => etiqueta.Etiqueta_Nombre.Equals(((EditText)sender).Text)).Etiqueta_Id;
                }catch{
                    etiqueta_id = null;
                }
                new UsuariosController().AddRemoveEtiquetas(miembro.Usuario_Id, miembro.Usuario_Tipo,
                                                            !string.IsNullOrEmpty(etiqueta_id) ? etiqueta_id : null,
                                                            ((EditText)sender).Text, etiqueta_tipo, null);
            }

        }

        ArrayAdapter FillAdapterEtiquetas(TipoEtiquetas etiqueta_tipo) =>
            new ArrayAdapter(context, Android.Resource.Layout.SimpleDropDownItem1Line, etiquetas.FindAll(etiqueta => etiqueta.Etiqueta_Tipo == etiqueta_tipo.ToString()));

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
            profileView.FindViewById<TextView>(Resource.Id.lblAgregarExperiencia).Click += (sender, e) => profileView.FindViewById<GridLayout>(Resource.Id.glNuevoEmpleo).Visibility = ViewStates.Visible;
            profileView.FindViewById<Button>(Resource.Id.btnAgregar).Click += (sender, e) => profileView.FindViewById<GridLayout>(Resource.Id.glNuevoEmpleo).Visibility = ViewStates.Gone;
        }

    }
}
