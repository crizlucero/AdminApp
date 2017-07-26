using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS
{
    public partial class EmpresaMiembroController : UIViewController
    {
        EmpresaModel empresa;
        public EmpresaMiembroController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
			empresa = new EmpresaController().GetEmpresaMiembro(storageLocal.Get("Miembro_Id"));
			btnEditar.BackgroundColor = UIColor.FromRGB(101, 216, 250);
			btnEditar.SetTitleColor(UIColor.Black, UIControlState.Normal);
			btnEditar.Layer.CornerRadius = 10;
			this.FillData();
		}

		private void FillData()
		{
			#region Datos de la empresa del miembro
			lblNombreEmpresa.Text = empresa.Empresa_Miembro_Nombre;
			lblGiroComercial.Text = empresa.Giro_Descripcion;
			lblDireccion.Text = empresa.Territorio_Estado_Descripcion + ", " + empresa.Empresa_Miembro_Calle + " #" + empresa.Empresa_Miembro_Numero_Exterior +
				(empresa.Empresa_Miembro_Numero_Interior != null || empresa.Empresa_Miembro_Numero_Interior != "" ? " int. " + empresa.Empresa_Miembro_Numero_Interior : "")
				+ ", CP " + empresa.Territorio_Cp;
			lblPaginaWeb.Text = empresa.Empresa_Miembro_Pagina_Web;
			lblRedesSociales.Text = empresa.Empresa_Miembro_Red_Social_1 + "\n" + empresa.Empresa_Miembro_Red_Social_2 + "\n" + empresa.Empresa_Miembro_Red_Social_3;
			lblEmailEmpresa.Text = empresa.Empresa_Miembro_Correo_Electronico;
			#endregion

		}
    }
}