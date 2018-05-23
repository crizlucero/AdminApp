using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{


	public interface HoraInicioSeleccionada
    {
        void SeleccionarHoraInicio(string HoraInicio, int SelectedCell);
    }

    public partial class CeldaHoraInicio : UICollectionViewCell
    {

		public HoraInicioSeleccionada HoraInicioDelegate;
        private string Hora;
        private int Cell;

        public CeldaHoraInicio (IntPtr handle) : base (handle)
        {
			
        }

		public void UpdateCell(string Hora, int Selectedcell)
		{
			this.Cell = Selectedcell;
            this.Hora = Hora;
			this.btnHoraInicio.SetTitle(Hora, UIControlState.Normal);
		} 
       

		public void ReloadCells()
        {
            this.btnHoraInicio.BackgroundColor = UIColor.White;
			this.btnHoraInicio.SetTitleColor(UIColor.Black, UIControlState.Normal);
        }


        public void PintarCeldas()
        {
			this.btnHoraInicio.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnHoraInicio.SetTitleColor(UIColor.White, UIControlState.Normal);
        }

		partial void HoraInicio_Touch(UIButton sender)
		{
			HoraInicioDelegate.SeleccionarHoraInicio(Hora, Cell);
		}
	}
}