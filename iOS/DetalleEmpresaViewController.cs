using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{
    public partial class DetalleEmpresaViewController : UITableViewController
    {

        public EmpresaModel Empresa;

        public DetalleEmpresaViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.lblNombreEmpresa.Text = Empresa.Empresa_Miembro_Nombre;
            this.lblDescripcion.Text = Empresa.Giro_Descripcion;
            this.imgEmpresa.SetBackgroundImage(ImageGallery.LoadImage(Empresa.Empresa_Miembro_Logotipo) ?? UIImage.FromBundle("ProfileImageBig"), UIControlState.Normal);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }
    }
}