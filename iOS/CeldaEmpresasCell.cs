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
        public CeldaEmpresasCell (IntPtr handle) : base (handle)
        {
        }

        partial void btnImagenEmpresa_Touch(UIButton sender)
        {
            
        }

        public void UpdateCell(EmpresaModel Empresa)
        {
            this.lblEmpresas.Text = Empresa.Empresa_Miembro_Nombre;
        }
    }
}