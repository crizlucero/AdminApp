using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class CeldaImagenSala : UICollectionViewCell
    {
        public CeldaImagenSala (IntPtr handle) : base (handle)
        {
        }

		public void UpdateCell(UIImage ImagenSala)
		{
			this.imgSala.Image = ImagenSala;
		}
    }
}