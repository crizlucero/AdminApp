using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class CeldaEmpresasCell : UITableViewCell
    {

        public event EventHandler InfoEmpresas;

        private EmpresaModel EmpresaLocal;

        public CeldaEmpresasCell (IntPtr handle) : base (handle)
        {
        }

        partial void btnImagenEmpresa_Touch(UIButton sender)
        {
            if (InfoEmpresas != null)
            {
                this.InfoEmpresas(this.EmpresaLocal, EventArgs.Empty);
            }
        }

        public void UpdateCell(EmpresaModel Empresa)
        {
            this.lblEmpresas.Text = Empresa.Empresa_Miembro_Nombre;
            this.EmpresaLocal = Empresa;
        }


    }
}