using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public interface EventosEmpresas
    {
        void InfoEmpresas(EmpresaModel EmpresaLocal);
    }

    public partial class CeldaEmpresasCell : UITableViewCell
    {

        public EventosEmpresas EventosEmpresasDelegate;

        private EmpresaModel EmpresaLocal;

        public CeldaEmpresasCell (IntPtr handle) : base (handle)
        {
        }

        partial void btnImagenEmpresa_Touch(UIButton sender)
        {
            EventosEmpresasDelegate.InfoEmpresas(EmpresaLocal);

        }

        public void UpdateCell(EmpresaModel Empresa)
        {
            this.lblEmpresas.Text = Empresa.Empresa_Nombre;
            this.EmpresaLocal = Empresa;
        }


    }
}