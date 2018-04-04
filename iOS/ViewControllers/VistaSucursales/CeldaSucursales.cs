using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{

    public interface EventosCeldasSucursales
    {
        void SucursalSeleccionada(string SucursalId);
    }

    public partial class CeldaSucursales : UICollectionViewCell
    {

        public EventosCeldasSucursales EventosCeldasSucursalesDelegate;
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
            EventosCeldasSucursalesDelegate.SucursalSeleccionada(SucursalId);
            //await MenuHelper.GetSalas(SucursalId);
        }

    }
}