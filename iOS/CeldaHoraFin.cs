using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class CeldaHoraFin : UICollectionViewCell
    {
        public CeldaHoraFin (IntPtr handle) : base (handle)
        {
        }


        public void UpdateCell(string Hora)
		{
			this.btnHoraFin.SetTitle(Hora, UIControlState.Normal);
		}

		partial void btnHoraFin_Touch(UIButton sender)
		{
			this.btnHoraFin.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnHoraFin.SetTitleColor(UIColor.White, UIControlState.Normal);
		}
	}
}