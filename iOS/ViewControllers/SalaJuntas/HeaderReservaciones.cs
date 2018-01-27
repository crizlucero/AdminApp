using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface EventosHeaderReservaciones
    {
        void MostrarTipoReservacion(nint SelectedSegment);
    }

    public partial class HeaderReservaciones : UITableViewCell
    {

        public EventosHeaderReservaciones EventosHeaderReservacionesDelegate;

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

            EventosHeaderReservacionesDelegate.MostrarTipoReservacion(sgcReservacion.SelectedSegment);
        }

    }
}