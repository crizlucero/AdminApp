using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class CeldaSucursales : UICollectionViewCell
    {
        public CeldaSucursales (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(SucursalModel Sucursal)
        {
            this.lblNombre.Text = Sucursal.Sucursal_Domicilio;
            this.lblDomicilio.Text = Sucursal.Sucursal_Descripcion;
        }
    }
}