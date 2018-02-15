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

        public UsuarioModel Miembro = new UsuarioModel();

        public InfoEmpresaTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            StyleHelper.Style(this.vwEmpresa.Layer);
            StyleHelper.Style(this.vwEmpresasAnteriores.Layer);
            StyleHelper.Style(this.vwColaboradores.Layer);
            EmpresaModel empresa = new EmpresaController().GetEmpresaMiembro(Miembro.Usuario_Id);
            this.lblPais.Text = empresa.Territorio.Municipio + ", " + empresa.Territorio.Pais;
            this.lblEmpresa.Text = empresa.Empresa_Miembro_Nombre;
            this.lblPuesto.Text = Miembro.Usuario_Puesto;
            this.lblFechaInicioFin.Text = "";

        }
    }
}