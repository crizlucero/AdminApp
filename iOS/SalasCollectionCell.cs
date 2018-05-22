using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class SalasCollectionCell : UICollectionViewCell
    {
        public SalasCollectionCell (IntPtr handle) : base (handle)
        {
        }
       
		public void UpdateCell(SalaJuntasModel SalaJuntas)
        {
			this.lblSalaNivel.Text = SalaJuntas.Sala_Nivel;
			this.lblSalaNombre.Text = SalaJuntas.Sala_Descripcion;
			this.lblSalaCreditos.Text = "1.0";
        }
    }
}