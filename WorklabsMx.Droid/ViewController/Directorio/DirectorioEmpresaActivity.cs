using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "DirectorioEmpresaActivity")]
    public class DirectorioEmpresaActivity : Activity
    {
        ScrollView svDirectorio;
        EmpresaController CompanyController;
        public DirectorioEmpresaActivity()
        {
            CompanyController = new EmpresaController();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Directorio();

        }

        void Directorio(string nombre = "", string pais = "", string estado = "", string municipio = "", string giro = "")
        {
            SetContentView(Resource.Layout.DirectorioLayout);
            SetTitle(Resource.String.DirectorioEmpresas);

            svDirectorio = FindViewById<ScrollView>(Resource.Id.svDirectorio);
            FillDirectorioUsuario(nombre, pais, estado, municipio, giro);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.DirectorioEmpresas);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
        }

        void FillDirectorioUsuario(string nombre = "", string pais = "", string estado = "", string municipio = "", string giro = "")
        {
            LinearLayout llDirectorio = new LinearLayout(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            CompanyController.GetDirectorioEmpresas(nombre, pais, estado, municipio, giro).ForEach((empresa) =>
            {
                LinearLayout llNombre = new LinearLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };
                TextView txtNombre = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Nombre,
                    TextSize = 22
                };
                txtNombre.SetX(10);
                llNombre.AddView(txtNombre);
                llDirectorio.AddView(llNombre);

                LinearLayout llEmail = new LinearLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };
                TextView txtEmail = new TextView(this)
                {
                    TextSize = 14,
                    Text = empresa.Empresa_Miembro_Correo_Electronico
                };
                txtEmail.Click += (sender, e) =>
                {
                    try
                    {
                        Intent email = new Intent(Intent.ActionSend);
                        email.PutExtra(Intent.ExtraEmail,
                                       new string[] { empresa.Empresa_Miembro_Correo_Electronico });
                        email.PutExtra(Intent.ExtraSubject, Resources.GetString(Resource.String.AsuntoCorreo));
                        email.SetType("message/rfc822");
                        StartActivity(email);
                    }
                    catch (Exception ex)
                    {
                        SlackLogs.SendMessage(ex.Message);
                        Toast.MakeText(this, Resource.String.AplicationNotFound, ToastLength.Short).Show();
                    }
                };
                llEmail.AddView(txtEmail);

                llDirectorio.AddView(llEmail);

                ScrollView svInfo = new ScrollView(this)
                {
                    LayoutParameters = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, 600)
                };
                LinearLayout llInfo = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                    Orientation = Orientation.Vertical
                };

                LinearLayout llImg = new LinearLayout(this)
                {
                    Orientation = Orientation.Vertical
                };
                ImageView imgInfo = new ImageView(this);

                llImg.AddView(imgInfo);
                llInfo.AddView(llImg);
                #region Giro Comercial
                RelativeLayout rlGiro = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
                };

                ImageView imgGiro = new ImageView(this);
                imgGiro.SetImageResource(Resource.Mipmap.ic_business_center);
                rlGiro.AddView(imgGiro);
                TextView txtGiro = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.GiroComercial)
                };
                txtGiro.SetX(100);
                rlGiro.AddView(txtGiro);
                llInfo.AddView(rlGiro);

                LinearLayout llGiro = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroGiro = new TextView(this)
                {
                    Text = empresa.Giro_Descripcion
                };
                txtMiembroGiro.SetX(50);
                llGiro.AddView(txtMiembroGiro);
                llInfo.AddView(llGiro);
                #endregion
                #region Dirección
                RelativeLayout rlDireccion = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgDireccion = new ImageView(this);
                imgDireccion.SetImageResource(Resource.Mipmap.ic_place);
                rlDireccion.AddView(imgDireccion);
                TextView txtDireccion = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Direccion)
                };
                txtDireccion.SetX(100);
                rlDireccion.AddView(txtDireccion);
                llInfo.AddView(rlDireccion);

                LinearLayout llDireccion = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroDireccion = new TextView(this)
                {
                    Text = empresa.Territorio_Municipio_Descripcion + ", " + empresa.Territorio_Estado_Descripcion + ", "
                                                   + empresa.Empresa_Miembro_Calle + " #" + empresa.Empresa_Miembro_Numero_Exterior +
                                                    (!string.IsNullOrEmpty(empresa.Empresa_Miembro_Numero_Interior) ? " int. " + empresa.Empresa_Miembro_Numero_Interior : "") +
                                                   " Col. " + empresa.Territorio_Colonia_Descripcion
                                                    + " CP. " + empresa.Territorio_Cp
                };
                txtMiembroDireccion.SetX(50);
                llDireccion.AddView(txtMiembroDireccion);
                llInfo.AddView(llDireccion);
                #endregion
                #region Telefono
                RelativeLayout rlTelefono = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgTelefono = new ImageView(this);
                imgTelefono.SetImageResource(Resource.Mipmap.ic_call);
                rlTelefono.AddView(imgTelefono);
                TextView txtTelefono = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Telefono)
                };
                txtTelefono.SetX(100);
                rlTelefono.AddView(txtTelefono);
                llInfo.AddView(rlTelefono);

                LinearLayout llTelefono = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroTelefono = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Telefono
                };
                txtMiembroTelefono.SetX(50);
                llTelefono.AddView(txtMiembroTelefono);
                llInfo.AddView(llTelefono);
                #endregion
                #region RFC
                RelativeLayout rlRFC = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgRFC = new ImageView(this);
                imgRFC.SetImageResource(Resource.Mipmap.ic_label);
                rlRFC.AddView(imgRFC);
                TextView txtRFC = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.RFC)
                };
                txtRFC.SetX(100);
                rlRFC.AddView(txtRFC);
                llInfo.AddView(rlRFC);

                LinearLayout llRFC = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroRFC = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Rfc
                };
                txtMiembroRFC.SetX(50);
                llRFC.AddView(txtMiembroRFC);
                llInfo.AddView(llRFC);
                #endregion
                #region Razón Social
                RelativeLayout rlRazonSocial = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgRazonSocial = new ImageView(this);
                imgRazonSocial.SetImageResource(Resource.Mipmap.ic_label);
                rlRazonSocial.AddView(imgRazonSocial);
                TextView txtRazonSocial = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.RazonSocial)
                };
                txtRazonSocial.SetX(100);
                rlRazonSocial.AddView(txtRazonSocial);
                llInfo.AddView(rlRazonSocial);

                LinearLayout llRazonSocial = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroRazonSocial = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Razon_Social
                };
                txtMiembroRazonSocial.SetX(50);
                llRazonSocial.AddView(txtMiembroRazonSocial);
                llInfo.AddView(llRazonSocial);
                #endregion
                #region Página Web
                RelativeLayout rlPaginaWeb = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgPaginaWeb = new ImageView(this);
                imgPaginaWeb.SetImageResource(Resource.Mipmap.ic_create);
                rlPaginaWeb.AddView(imgPaginaWeb);
                TextView txtPaginaWeb = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.PaginaWeb)
                };
                txtPaginaWeb.SetX(100);
                rlPaginaWeb.AddView(txtPaginaWeb);
                llInfo.AddView(rlPaginaWeb);

                LinearLayout llPaginaWeb = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroPaginaWeb = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Pagina_Web
                };
                txtMiembroPaginaWeb.SetX(50);
                llPaginaWeb.AddView(txtMiembroPaginaWeb);
                llInfo.AddView(llPaginaWeb);
                #endregion
                #region Redes Sociales
                RelativeLayout rlRedesSociales = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgRedesSociales = new ImageView(this);
                imgRedesSociales.SetImageResource(Resource.Mipmap.ic_share);
                rlRedesSociales.AddView(imgRedesSociales);
                TextView txtRedesSociales = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.RedesSociales)
                };
                txtRedesSociales.SetX(100);
                rlRedesSociales.AddView(txtRedesSociales);
                llInfo.AddView(rlRedesSociales);
                #region Facebook
                RelativeLayout rlFacebook = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgFacebook = new ImageView(this);
                imgFacebook.SetImageResource(Resource.Mipmap.ic_facebook);
                rlFacebook.AddView(imgFacebook);
                TextView txtFacebook = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Red_Social_1
                };
                txtFacebook.SetX(100);
                rlFacebook.AddView(txtFacebook);
                llInfo.AddView(rlFacebook);
                #endregion
                #region Twitter
                RelativeLayout rlTwitter = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgTwitter = new ImageView(this);
                imgTwitter.SetImageResource(Resource.Mipmap.ic_twitter);
                rlTwitter.AddView(imgTwitter);
                TextView txtTwitter = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Red_Social_2
                };
                txtTwitter.SetX(100);
                rlTwitter.AddView(txtTwitter);
                llInfo.AddView(rlTwitter);
                #endregion
                #region Instagram
                RelativeLayout rlInstagram = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgInstagram = new ImageView(this);
                imgInstagram.SetImageResource(Resource.Mipmap.ic_instagram);
                rlInstagram.AddView(imgInstagram);
                TextView txtInstagram = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Red_Social_3
                };
                txtInstagram.SetX(100);
                rlInstagram.AddView(txtInstagram);
                llInfo.AddView(rlInstagram);
                #endregion
                #endregion

                svInfo.AddView(llInfo);
                llDirectorio.AddView(svInfo);
            });
            svDirectorio.AddView(llDirectorio);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.search_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_search:
                    SearchView();
                    break;
                default:
                    base.OnBackPressed();
                    break;
            }

            return base.OnOptionsItemSelected(item);
        }

        void SearchView()
        {
            SetContentView(Resource.Layout.SearchCompanyLayout);


            FindViewById<ImageButton>(Resource.Id.btnClear).Click += (sender, e) =>
            {
                Directorio();
            };

            FindViewById<Button>(Resource.Id.btnBuscar).Click += (sender, e) =>
            {
                Directorio(FindViewById<TextView>(Resource.Id.txtNombre).Text, FindViewById<TextView>(Resource.Id.txtPais).Text,
                           FindViewById<TextView>(Resource.Id.txtEstado).Text, FindViewById<TextView>(Resource.Id.txtMunicipio).Text,
                           FindViewById<TextView>(Resource.Id.txtGiroComercial).Text);
            };
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.DirectorioEmpresas);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
        }
    }
}
