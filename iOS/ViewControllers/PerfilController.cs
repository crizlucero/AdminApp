using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS
{
    public partial class PerfilController : UIViewController
    {
        MiembroModel miembro;
        public PerfilController (IntPtr handle) : base (handle)
        {
            
        }
		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            miembro = new MiembrosController().GetMemberData(storageLocal.Get("Miembro_Id"));
            this.FillData();
		}

        private void FillData()
        {
            #region Datos del miembro
            lblNombre.Text = miembro.Miembro_Nombre;
            lblCorreo.Text = miembro.Miembro_Correo_Electronico;
            lblGenero.Text = miembro.Genero_Descripcion;
            lblFechaNacimiento.Text = miembro.Miembro_Fecha_Nacimiento;
            imgMiembro.Image = ImageGallery.LoadImage(miembro.Miembro_Fotografia);
            #endregion

        }
    }
}