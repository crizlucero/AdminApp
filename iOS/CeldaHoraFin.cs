using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

	public interface HoraFinSeleccionada
    {
        void SeleccionarHoraFin(string HoraFin, int SelectedCell);
    }

    public partial class CeldaHoraFin : UICollectionViewCell
    {

		public HoraFinSeleccionada HoraFinDelegate;
		private string Hora;
		private int Cell;

        public CeldaHoraFin (IntPtr handle) : base (handle)
        {
        }
       
		public void UpdateCell(string Hora, int Selectedcell)
		{
			this.Cell = Selectedcell;
			this.Hora = Hora;
			this.btnHoraFin.SetTitle(Hora, UIControlState.Normal);
		}


        public void ReloadCells()
		{
			this.btnHoraFin.BackgroundColor = UIColor.White;
			this.btnHoraFin.SetTitleColor(UIColor.Black, UIControlState.Normal);
		}


        public void PintarCeldas()
		{
			this.btnHoraFin.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnHoraFin.SetTitleColor(UIColor.White, UIControlState.Normal);
		}

		partial void btnHoraFin_Touch(UIButton sender)
		{
			HoraFinDelegate.SeleccionarHoraFin(Hora, Cell);
		}
	}
}