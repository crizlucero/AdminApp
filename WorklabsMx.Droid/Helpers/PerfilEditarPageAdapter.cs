using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using Java.Lang;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    public class PerfilEditarPageAdapter : PagerAdapter
    {
        readonly Activity context;
        List<string> titulos;
        List<EtiquetaModel> etiquetas;
        readonly UsuarioModel miembro;
        View profileView;
        public PerfilEditarPageAdapter(Activity context, List<string> titulos, ref UsuarioModel miembro)
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
            EditText sobremi = profileView.FindViewById<EditText>(Resource.Id.txtSobreMi);
            sobremi.Text = miembro.Usuario_Descripcion;
            sobremi.TextChanged += (sender, e) =>
                miembro.Usuario_Descripcion = ((TextView)sender).Text;

            EditText telefono = profileView.FindViewById<EditText>(Resource.Id.txtTelefono);
            telefono.Text = miembro.Usuario_Telefono;
            telefono.TextChanged += (sender, e) =>
                miembro.Usuario_Telefono = ((EditText)sender).Text;

            EditText celular = profileView.FindViewById<EditText>(Resource.Id.txtCelular);
            celular.Text = miembro.Usuario_Celular;
            celular.TextChanged += (sender, e) =>
                miembro.Usuario_Celular = ((EditText)sender).Text;

            EditText correo = profileView.FindViewById<EditText>(Resource.Id.txtCorreo);
            correo.Text = miembro.Usuario_Correo_Electronico;
            correo.TextChanged += (sender, e) =>
                miembro.Usuario_Correo_Electronico = ((EditText)sender).Text;
            EditText nacimiento = profileView.FindViewById<EditText>(Resource.Id.txtFechaNacimiento);
            nacimiento.ShowSoftInputOnFocus = false;
            nacimiento.Click += (sender, e) =>
            {
                DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (System.DateTime time)
                {
                    ((EditText)sender).Text = time.ToString("d");
                    miembro.Usuario_Fecha_Nacimiento = time.ToString("d");
                });
                frag.Show(context.FragmentManager, context.Resources.GetString(Resource.String.ReservaSala));
            };


            EditText txtHabilidades = profileView.FindViewById<EditText>(Resource.Id.txtHabilidades);
            txtHabilidades.EditorAction += Etiqueta_KeyPress;
            EditText txtIntereses = profileView.FindViewById<EditText>(Resource.Id.txtIntereses);
            txtIntereses.EditorAction += Etiqueta_KeyPress;
            miembro.Etiquetas.AsParallel().ToList().ForEach(habilidad =>
            {
                if (habilidad.Etiqueta_Tipo == "Habilidad")
                    FillEtiqueta(habilidad.Etiqueta_Nombre, profileView.FindViewById<RelativeLayout>(Resource.Id.rlHabilidades));
                else
                    FillEtiqueta(habilidad.Etiqueta_Nombre, profileView.FindViewById<RelativeLayout>(Resource.Id.rlIntereses));
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
                }
                catch
                {
                    etiqueta_id = null;
                }
                new UsuariosController().AddRemoveEtiquetas(miembro.Usuario_Id, miembro.Usuario_Tipo,
                                                            !string.IsNullOrEmpty(etiqueta_id) ? etiqueta_id : null,
                                                            ((EditText)sender).Text, etiqueta_tipo, null);
                if (etiqueta_tipo == TipoEtiquetas.Habilidad)
                    FillEtiqueta(etiqueta_tipo.ToString(), profileView.FindViewById<RelativeLayout>(Resource.Id.rlHabilidades));
                else
                    FillEtiqueta(etiqueta_tipo.ToString(), profileView.FindViewById<RelativeLayout>(Resource.Id.rlIntereses));
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
            miembro.Redes_Sociales.ForEach(red =>
            {
                if (red.Red_Social_Nombre.Contains("Web"))
                {
                    EditText enlace = profileView.FindViewById<EditText>(Resource.Id.txtPaginaWeb);
                    enlace.Text = red.Red_Social_Enlace;
                    enlace.TextChanged += (sender, e) => red.Red_Social_Enlace = ((EditText)sender).Text;
                }
                else if (red.Red_Social_Nombre.Contains("Facebook"))
                {
                    EditText enlace = profileView.FindViewById<EditText>(Resource.Id.txtFacebook);
                    enlace.Text = red.Red_Social_Enlace;
                    enlace.TextChanged += (sender, e) => red.Red_Social_Enlace = ((EditText)sender).Text;
                }
                else if (red.Red_Social_Nombre.Contains("Instagram"))
                {
                    EditText enlace = profileView.FindViewById<EditText>(Resource.Id.txtInstagram);
                    enlace.Text = red.Red_Social_Enlace;
                    enlace.TextChanged += (sender, e) => red.Red_Social_Enlace = ((EditText)sender).Text;
                }
                else if (red.Red_Social_Nombre.Contains("Twitter"))
                {
                    EditText enlace = profileView.FindViewById<EditText>(Resource.Id.txtTwitter);
                    enlace.Text = red.Red_Social_Enlace;
                    enlace.TextChanged += (sender, e) => red.Red_Social_Enlace = ((EditText)sender).Text;
                }
                else if (red.Red_Social_Nombre.Contains("YouTube"))
                {
                    EditText enlace = profileView.FindViewById<EditText>(Resource.Id.txtYoutube);
                    enlace.Text = red.Red_Social_Enlace;
                    enlace.TextChanged += (sender, e) => red.Red_Social_Enlace = ((EditText)sender).Text;
                }
                else if (red.Red_Social_Nombre.Contains("LinkedIn"))
                {
                    EditText enlace = profileView.FindViewById<EditText>(Resource.Id.txtLinkedin);
                    enlace.Text = red.Red_Social_Enlace;
                    enlace.TextChanged += (sender, e) => red.Red_Social_Enlace = ((EditText)sender).Text;
                }
                else if (red.Red_Social_Nombre.Contains("Skype"))
                {
                    EditText enlace = profileView.FindViewById<EditText>(Resource.Id.txtSkype);
                    enlace.Text = red.Red_Social_Enlace;
                    enlace.TextChanged += (sender, e) => red.Red_Social_Enlace = ((EditText)sender).Text;
                }
            });
        }

        void FillTrabajo()
        {
            //profileView.FindViewById<TextView>(Resource.Id.lblAgregarExperiencia).Click += (sender, e) => profileView.FindViewById<GridLayout>(Resource.Id.glNuevoEmpleo).Visibility = ViewStates.Visible;
            //profileView.FindViewById<Button>(Resource.Id.btnAgregar).Click += (sender, e) => profileView.FindViewById<GridLayout>(Resource.Id.glNuevoEmpleo).Visibility = ViewStates.Gone;
            EditText nombre = profileView.FindViewById<EditText>(Resource.Id.txtNombre);
            nombre.Text = miembro.Empresa_Actual.Empresa_Nombre;
            nombre.TextChanged += (sender, e) => miembro.Empresa_Actual.Empresa_Nombre = ((EditText)sender).Text;
            EditText web = profileView.FindViewById<EditText>(Resource.Id.txtPaginaWeb);
            web.Text = miembro.Empresa_Actual.Empresa_Pagina_Web;
            web.TextChanged += (sender, e) => miembro.Empresa_Actual.Empresa_Pagina_Web = ((EditText)sender).Text;
            EditText pais = profileView.FindViewById<EditText>(Resource.Id.txtPais);
            pais.Text = miembro.Empresa_Actual.Territorio.Pais;
            pais.TextChanged += (sender, e) => miembro.Empresa_Actual.Territorio.Pais = ((EditText)sender).Text;
            EditText municipio = profileView.FindViewById<EditText>(Resource.Id.txtMunicipio);
            municipio.Text = miembro.Empresa_Actual.Territorio.Municipio;
            municipio.TextChanged += (sender, e) => miembro.Empresa_Actual.Territorio.Municipio = ((EditText)sender).Text;
            EditText puesto = profileView.FindViewById<EditText>(Resource.Id.txtPuesto);
            puesto.Text = miembro.Usuario_Puesto;
            puesto.TextChanged += (sender, e) => miembro.Usuario_Puesto = ((EditText)sender).Text;
            EditText correo = profileView.FindViewById<EditText>(Resource.Id.txtPaginaWeb);
            correo.Text = miembro.Empresa_Actual.Empresa_Correo_Electronico;
            correo.TextChanged += (sender, e) => miembro.Empresa_Actual.Empresa_Correo_Electronico = ((EditText)sender).Text;
        }

    }
}
