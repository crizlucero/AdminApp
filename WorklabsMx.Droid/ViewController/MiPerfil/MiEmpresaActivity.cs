﻿using Android.App;
using Android.OS;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class MiEmpresaActivity : Activity
    {
        SimpleStorage storage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MiEmpresaLayout);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");
            FillData();
        }

        void FillData()
        {
            EmpresaModel empresa = new EmpresaController().GetEmpresaMiembro(storage.Get("Usuario_Id"));
            FindViewById<ImageView>(Resource.Id.imgEmpresaPerfil).SetImageURI(Android.Net.Uri.Parse(empresa.Empresa_Miembro_Logotipo));
            FindViewById<TextView>(Resource.Id.txtCompanyName).Text = empresa.Empresa_Miembro_Nombre;
            FindViewById<TextView>(Resource.Id.txtEmailCompanyPerfil).Text = empresa.Empresa_Miembro_Correo_Electronico;
            FindViewById<TextView>(Resource.Id.txtGiroEmpresa).Text = empresa.Giro_Descripcion;
            FindViewById<TextView>(Resource.Id.txtDireccionEmpresa).Text = empresa.Territorio.Municipio + ", " + empresa.Territorio.Estado + ", "
                                                   + empresa.Empresa_Miembro_Calle + " #" + empresa.Empresa_Miembro_Numero_Exterior +
                                                    (!string.IsNullOrEmpty(empresa.Empresa_Miembro_Numero_Interior) ? " int. " + empresa.Empresa_Miembro_Numero_Interior : "") +
                " Col. " + empresa.Territorio.Colonia
                + " CP. " + empresa.Territorio.CP;
            FindViewById<TextView>(Resource.Id.txtTelefonoEmpresa).Text = empresa.Empresa_Miembro_Telefono;
            FindViewById<TextView>(Resource.Id.txtRFCEmpresa).Text = empresa.Empresa_Miembro_Rfc;
            FindViewById<TextView>(Resource.Id.txtRazonSocialEmpresa).Text = empresa.Empresa_Miembro_Razon_Social;
            FindViewById<TextView>(Resource.Id.txtPaginaWebEmpresa).Text = empresa.Empresa_Miembro_Pagina_Web;
            FindViewById<TextView>(Resource.Id.txtFbEmpresa).Text = empresa.Empresa_Miembro_Red_Social_1;
            FindViewById<TextView>(Resource.Id.txtTwitterEmpresa).Text = empresa.Empresa_Miembro_Red_Social_2;
            FindViewById<TextView>(Resource.Id.txtInstagramEmpresa).Text = empresa.Empresa_Miembro_Red_Social_3;
        }
    }
}
