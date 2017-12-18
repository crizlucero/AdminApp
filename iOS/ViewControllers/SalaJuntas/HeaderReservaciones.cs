using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class HeaderReservaciones : UITableViewCell
    {
        
        public event EventHandler MostrarTipoReservacion;

        public HeaderReservaciones (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(int CampoSeleccionado)
        {
            this.sgcReservacion.SelectedSegment = CampoSeleccionado;
            sgcReservacion.ValueChanged += (sender, e) => {
                this.sgcReservacionTouch();
            };
        }

        private void sgcReservacionTouch()
        {
            if(MostrarTipoReservacion != null)
            {
                MostrarTipoReservacion(sgcReservacion.SelectedSegment, EventArgs.Empty);
            }
        }



    }
}