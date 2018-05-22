using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface PersonasSeleccionadas
	{
		void SeleccionarPersonas(string Personas, int SelectedCell);
	}
    
    public partial class CeldaCantidadPersonas : UICollectionViewCell
    {

		public PersonasSeleccionadas PersonasSeleccionadasDelegate;
		private string Personas;
		private int Cell;
        public CeldaCantidadPersonas (IntPtr handle) : base (handle)
        {
			
        }
        

		public void UpdateCell(string CantidadPersonas, int Selectedcell)
		{
			this.Cell = Selectedcell;

			this.btnCantidadPersonas.SetTitle(CantidadPersonas, UIControlState.Normal);
			this.Personas = CantidadPersonas;
		}

        public void ReloadCells()
		{
			this.btnCantidadPersonas.BackgroundColor = UIColor.White;
            this.btnCantidadPersonas.SetTitleColor(UIColor.Black, UIControlState.Normal);
            this.vwCantidadPersonas.BackgroundColor = UIColor.Clear.FromHex(0xEFEFEF);
		}

        public void PintarCeldas()
		{
			this.btnCantidadPersonas.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
            this.btnCantidadPersonas.SetTitleColor(UIColor.White, UIControlState.Normal);
            this.vwCantidadPersonas.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
		}
       

		partial void btnCantidadPersonas_Touch(UIButton sender)
		{
   
			PersonasSeleccionadasDelegate.SeleccionarPersonas(this.Personas, this.Cell);
		}
        
	}
}