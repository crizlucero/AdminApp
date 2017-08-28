﻿using System;
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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.DirectorioLayout);
            SetTitle(Resource.String.DirectorioEmpresas);

            svDirectorio = FindViewById<ScrollView>(Resource.Id.svDirectorio);
            FillDirectorioUsuario();

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Perfil);
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
            foreach (EmpresaModel empresa in new EmpresaController().GetDirectorioEmpresas(nombre, pais, estado, municipio, giro))
            {
                RelativeLayout rlNombre = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };
                TextView txtNombre = new TextView(this)
                {
                    Text = empresa.Empresa_Miembro_Nombre,
                    TextSize = 20
                };
                txtNombre.SetX(10);
                rlNombre.AddView(txtNombre);

                TextView txtEmail = new TextView(this)
                {
                    TextSize = 14,
                    Text = empresa.Empresa_Miembro_Correo_Electronico
                };
                txtEmail.SetX(10);
                txtEmail.SetY(30);
                txtEmail.LayoutParameters = new ViewGroup.LayoutParams(350, 70);
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
                rlNombre.AddView(txtEmail);

                llDirectorio.AddView(rlNombre);

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
                txtGiro.SetX(50);
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
                txtMiembroGiro.SetX(20);
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
                txtDireccion.SetX(50);
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
                txtMiembroDireccion.SetX(20);
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
                txtTelefono.SetX(50);
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
                txtMiembroTelefono.SetX(20);
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
                txtRFC.SetX(50);
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
                txtMiembroRFC.SetX(20);
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
                txtRazonSocial.SetX(50);
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
                txtMiembroRazonSocial.SetX(20);
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
                txtPaginaWeb.SetX(50);
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
                txtMiembroPaginaWeb.SetX(20);
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
                txtRedesSociales.SetX(50);
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
                txtFacebook.SetX(50);
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
                txtTwitter.SetX(50);
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
                txtInstagram.SetX(50);
                rlInstagram.AddView(txtInstagram);
                llInfo.AddView(rlInstagram);
                #endregion
                #endregion

                svInfo.AddView(llInfo);
                llDirectorio.AddView(svInfo);
            }
            svDirectorio.AddView(llDirectorio);
        }
    }
}
