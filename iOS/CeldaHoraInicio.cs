using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class CeldaHoraInicio : UICollectionViewCell
    {
        public CeldaHoraInicio (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(string Hora)
		{
			this.btnHoraInicio.SetTitle(Hora, UIControlState.Normal);
		} 
       
		partial void HoraInicio_Touch(UIButton sender)
		{
			this.btnHoraInicio.BackgroundColor = UIColor.Clear.FromHex(0x3BDBD5);
			this.btnHoraInicio.SetTitleColor(UIColor.White, UIControlState.Normal);
		}
	}
}