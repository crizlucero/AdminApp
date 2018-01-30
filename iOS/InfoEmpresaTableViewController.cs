using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using Foundation;

namespace WorklabsMx.iOS
{
    public partial class InfoEmpresaTableViewController : UITableViewController
    {

        public MiembroModel Miembro = new MiembroModel();

        public InfoEmpresaTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            StyleHelper.Style(this.vwEmpresa.Layer);
            StyleHelper.Style(this.vwEmpresasAnteriores.Layer);
            EmpresaModel empresa = new EmpresaController().GetEmpresaMiembro(Miembro.Miembro_Id);
            this.lblPais.Text = "México";
            this.lblEmpresa.Text = empresa.Empresa_Miembro_Nombre;
        }
    }
}