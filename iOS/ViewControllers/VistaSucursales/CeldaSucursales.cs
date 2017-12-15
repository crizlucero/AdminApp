using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class CeldaSucursales : UICollectionViewCell
    {

        public event EventHandler SucursalSeleccionada;
        string SucursalId;

        public CeldaSucursales (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(SucursalModel Sucursal)
        {
            this.lblNombre.Text = Sucursal.Sucursal_Descripcion;
            this.lblDomicilio.Text = Sucursal.Sucursal_Domicilio;
            SucursalId = Sucursal.Sucursal_Id;
        }

        partial void btnSucursal_Touch(UIButton sender)
        {
            if (SucursalSeleccionada != null)
            {
                SucursalSeleccionada(SucursalId, EventArgs.Empty);
            }
        }
    }
}