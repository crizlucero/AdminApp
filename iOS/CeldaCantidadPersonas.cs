using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class CeldaCantidadPersonas : UICollectionViewCell
    {
        public CeldaCantidadPersonas (IntPtr handle) : base (handle)
        {
        }


		public void UpdateCell(string CantidadPersonas)
		{
			this.btnCantidadPersonas.SetTitle(CantidadPersonas, UIControlState.Normal);
		}

		partial void btnCantidadPersonas_Touch(UIButton sender)
		{
			this.btnCantidadPersonas.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnCantidadPersonas.SetTitleColor(UIColor.White, UIControlState.Normal);
			this.vwCantidadPersonas.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
		}
	}
}