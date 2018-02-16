using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class CeldaNoIntereses : UICollectionViewCell
    {
        public CeldaNoIntereses (IntPtr handle) : base (handle)
        {
        }

        public void UpdateInfo()
        {
            this.lblNoInteres.Text = "No hay intereses";
        }
    }
}