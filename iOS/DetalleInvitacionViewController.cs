using Foundation;
using System;
using UIKit;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{

    public partial class DetalleInvitacionViewController : UIViewController
    {

        public List<MiembroModel> Invitados = new List<MiembroModel>();
        public string DomicilioInvitacion = "";
        string strAcceso = string.Empty;
        public string FechaReservacion;

        public DetalleInvitacionViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.LlenarInfo();
        }

        public void LlenarInfo()
        {

            nfloat WidthView = 0;

            nfloat XLabelNombre = 0;
            nfloat XViewQR = 106;
            nfloat XImageQR = 0;

            for (int indice = 0; indice < this.Invitados.Count; indice++)
            {
                WidthView = WidthView + this.vwQR.Frame.Width;
            }

            if (this.Invitados.Count == 1)
            {
                this.btnAtras.Hidden = true;
                this.btnAtras.Enabled = false;

                this.btnAdelante.Hidden = true;
                this.btnAdelante.Enabled = false;
            }

            CGRect newFrame = new CGRect(this.vwQR.Frame.X, this.vwQR.Frame.Y, WidthView, this.vwQR.Frame.Height);

            this.vwQR.Frame = newFrame;

            var PrimerInvitado = Invitados[0];

            this.lblFecha.Text = this.FechaReservacion;
            this.lblDomicilio.Text = DomicilioInvitacion;
            this.lblNombreInvitado.Text = PrimerInvitado.Miembro_Nombre + " " + PrimerInvitado.Miembro_Apellidos;
            string newAcceso = new MiembrosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
            //LoadingView loadPop = new LoadingView(UIScreen.MainScreen.Bounds);
            //View.Add(loadPop);
            //strAcceso = newAcceso;
            imgQR.Image = ImageGallery.LoadImageUrl(newAcceso);
            //loadPop.Hide();
            Invitados.Remove(PrimerInvitado);
            foreach(MiembroModel Invitado in Invitados)
            {
                XLabelNombre = XLabelNombre + this.lblNombreInvitado.Frame.Width;
                UILabel LabelNombre = new UILabel();
                LabelNombre.Frame = new CGRect(XLabelNombre, this.lblNombreInvitado.Frame.Y, this.lblNombreInvitado.Frame.Width, this.lblNombreInvitado.Frame.Height);
                LabelNombre.Text = Invitado.Miembro_Nombre + " " + Invitado.Miembro_Apellidos;
                LabelNombre.Font = lblNombreInvitado.Font;
                LabelNombre.TextColor = UIColor.White;
                LabelNombre.TextAlignment = UITextAlignment.Left;

                XViewQR = XViewQR + vwContentQR.Frame.Width;
                UIView VistaQR = new UIView();
                VistaQR.Frame = new CGRect(XViewQR, this.vwContentQR.Frame.Y, this.vwContentQR.Frame.Width, this.vwContentQR.Frame.Height);

                UIImageView ImagenQr = new UIImageView();
                ImagenQr.Frame = this.imgQR.Frame;
                newAcceso = new MiembrosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                ImagenQr.Image = ImageGallery.LoadImageUrl(newAcceso);

                VistaQR.Add(ImagenQr);
                VistaQR.BackgroundColor = UIColor.White;
                VistaQR.Layer.MasksToBounds = true;
                VistaQR.Layer.CornerRadius = 7f;

                this.vwQR.Add(LabelNombre);
                this.vwQR.Add(VistaQR);

            }

            this.scvQR.ContentSize = this.vwQR.Frame.Size;
        }

        partial void btnCerrar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnAtras_Touch(UIButton sender)
        {
        }

        partial void btnAdelante_Touch(UIButton sender)
        {
        }
    }
}