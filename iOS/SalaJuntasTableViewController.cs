using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class SalaJuntasTableViewController : UITableViewController
    {
        public SalaJuntasTableViewController (IntPtr handle) : base (handle)
        {
            
        }

        partial void btnEditar_TouchUpInside(UIButton sender)
        {
            
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "MostrarSucursales")
            {
                var SucursalesView = (SucursalesViewController)segue.DestinationViewController;
                SucursalesView.SucursalSeleccionadaDel = this;

            }
        }
    }


    partial class SalaJuntasTableViewController: SucursalSeleccionada
    {
        public void SucursalSeleccionada(string Sucursal)
        {
            this.lblSucursal.Text = Sucursal;
        }
    }
}