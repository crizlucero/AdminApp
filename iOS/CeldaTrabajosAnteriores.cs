using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{
    public partial class CeldaTrabajosAnteriores : UICollectionViewCell
    {
        public CeldaTrabajosAnteriores (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(EmpresaModel Empresa)
        {
            this.lblPais.Text = (Empresa.Territorio.Municipio + ", " + Empresa.Territorio.Pais != "") ? Empresa.Territorio.Municipio + ", " + Empresa.Territorio.Pais : "Sin Info";
            this.lblPuesto.Text = "Sin Info";
            this.lblEmpresa.Text = (Empresa.Empresa_Nombre != "") ? Empresa.Empresa_Nombre : "Sin Info";
            this.lblFechaInicioFin.Text = "Sin Info";
        }
    }
}