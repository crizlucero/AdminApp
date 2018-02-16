using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class CeldaIntereses : UICollectionViewCell
    {
        public CeldaIntereses (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(EtiquetaModel Etiqueta)
        {
            this.lblInteres.Text = Etiqueta.Etiqueta_Nombre;
        }
    }
}