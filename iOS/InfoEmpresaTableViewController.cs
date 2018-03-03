using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using Foundation;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class InfoEmpresaTableViewController : UITableViewController
    {

        public UsuarioModel Miembro = new UsuarioModel();
        EmpresaModel empresa;
        public InfoEmpresaTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            StyleHelper.Style(this.vwEmpresa.Layer);
            StyleHelper.Style(this.vwEmpresasAnteriores.Layer);
            StyleHelper.Style(this.vwColaboradores.Layer);
            await GetEmpresa();
            empresa = new EmpresaController().GetEmpresaMiembro(Miembro.Usuario_Id);
            this.lblPais.Text = ((empresa.Territorio.Municipio + ", " + empresa.Territorio.Pais) != "") ? (empresa.Territorio.Municipio + ", " + empresa.Territorio.Pais) : "Sin Info";
            this.lblEmpresa.Text = (empresa.Empresa_Nombre != "") ? empresa.Empresa_Nombre : "Sin Info";
            this.lblPuesto.Text = (Miembro.Usuario_Puesto != "") ? Miembro.Usuario_Puesto : "Sin Info";
            //this.lblFechaInicioFin.Text = (Miembro.Usuario_Fecha_Nacimiento != "") ? Miembro.Usuario_Fecha_Nacimiento : "Sin Info";
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "EmpresasAnteriores")
            {
                var VistaEmpresas = (ColeccionTrabajosAnteriores)segue.DestinationViewController;
                VistaEmpresas.Empresas_Anteriores = Miembro.Empresas_Anteriores;
            }
            else if (segue.Identifier == "Colaboradores")
            {
                var VistaColaboradores = (coleccionColaboradores)segue.DestinationViewController;
                VistaColaboradores.Miembro = Miembro;
            }
        }

         async Task GetEmpresa()
        {
            await Task.Run(() =>
            {
                empresa = new EmpresaController().GetEmpresaMiembro(Miembro.Usuario_Id);
            });
        }
    }
}