using System.Threading.Tasks;
using CoreGraphics;
using UIKit;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS.Styles
{
    public class STLImageView : UIImageView
    {
        public STLImageView(int posY, string imageSource)
        {
            Frame = new CGRect(40, posY, 50, 50);
            //GetImage(imageSource);
            Image = ImageGallery.LoadImage(imageSource);
        }

        async void GetImage(string imageSource)
        {
            this.Image = await Task.Run(() => ImageGallery.LoadImage(imageSource));
        }
    }
}
