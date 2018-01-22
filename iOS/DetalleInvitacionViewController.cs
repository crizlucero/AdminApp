using Foundation;
using System;
using UIKit;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class DetalleInvitacionViewController : UIViewController
    {

        public List<MiembroModel> Invitados = new List<MiembroModel>();
        public string DomicilioInvitacion = "";
        string strAcceso = string.Empty;

        public DetalleInvitacionViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.LlenarInfo();
            string newAcceso = new MiembrosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));

            LoadingView loadPop = new LoadingView(UIScreen.MainScreen.Bounds);
            View.Add(loadPop);
            strAcceso = newAcceso;
            imgQR.Image = ImageGallery.LoadImageUrl(newAcceso);
            loadPop.Hide();

        }

        public void LlenarInfo()
        {
            foreach(MiembroModel Invitado in Invitados)
            {
                this.lblNombreInvitado.Text = Invitado.Miembro_Nombre + " " + Invitado.Miembro_Apellidos;
                this.lblFecha.Text = Invitado.Miembro_Fecha_Registro;
                this.lblDomicilio.Text = DomicilioInvitacion;
            }
        }

        partial void btnCerrar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}