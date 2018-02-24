using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class CeldaMembresias : UICollectionViewCell
    {
        public CeldaMembresias (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(MembresiaModel Membresia)
        {
            this.lblNombreMembresia.Text = Membresia.Membresia_Descripcion;
        }
    }
}