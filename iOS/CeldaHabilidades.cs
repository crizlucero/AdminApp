using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class CeldaHabilidades : UICollectionViewCell
    {
        public CeldaHabilidades (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(EtiquetaModel Etiqueta)
        {
            this.lblHabilidades.Text = (Etiqueta.Etiqueta_Nombre != "") ? Etiqueta.Etiqueta_Nombre : "Sin Info";
        }

    }
}