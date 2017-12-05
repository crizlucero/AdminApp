using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class AboutMeController : UIViewController
    {
        MiembroModel miembro;
        public AboutMeController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            miembro = new MiembrosController().GetMemberData(KeyChainHelper.GetKey("Usuario_Id"),KeyChainHelper.GetKey("Usuario_Tipo"));
            FillData();
            btnEditar.BackgroundColor = UIColor.FromRGB(101, 216, 250);
            btnEditar.SetTitleColor(UIColor.Black, UIControlState.Normal);
            btnEditar.Layer.CornerRadius = 10;
        }

        void FillData()
        {
            #region Datos del miembro
            lblProfesion.Text = miembro.Miembro_Profesion;
            lblPuesto.Text = miembro.Miembro_Puesto;
            lblHabilidades.Text = miembro.Miembro_Habilidades;
            lblTelefono.Text = miembro.Miembro_Telefono;
            lblCelular.Text = miembro.Miembro_Celular;
            #endregion
        }
    }
}