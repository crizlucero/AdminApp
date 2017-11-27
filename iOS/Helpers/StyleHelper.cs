
using CoreGraphics;
using CoreAnimation;
using UIKit;

namespace WorklabsMx.iOS.Helpers
{
    public class StyleHelper
    {
        public static void Style(CALayer layer)
        {
			var frame = new CGSize(0, 5);
			layer.MasksToBounds = false;				
            layer.ShadowColor = UIColor.Gray.CGColor;
			layer.ShadowOpacity = 0.2F;
			layer.ShadowRadius = 2.0F;
			layer.ShadowOffset = frame;		
        }
    }
}
