using UIKit;

namespace WorklabsMx.iOS.Styles
{
    public class STLButton : UIButton
    {
        public STLButton(string text)
        {
            BackgroundColor = UIColor.FromRGB(101, 216, 250);
            ClipsToBounds = true;
            Layer.CornerRadius = 10;
            TouchDown += (sender, e) =>
            {
                BackgroundColor = UIColor.FromRGB(101, 216, 0);
            };
            TouchUpInside += (sender, e) =>
            {
                BackgroundColor = UIColor.FromRGB(101, 216, 250);
            };
            SetTitleColor(UIColor.Black, UIControlState.Normal);
            SetTitle(text, UIControlState.Normal);
        }

        public STLButton(UIImage image)
        {
            BackgroundColor = UIColor.FromRGB(101, 216, 250);
            ClipsToBounds = true;
            Layer.CornerRadius = 10;
            TouchDown += (sender, e) =>
            {
                BackgroundColor = UIColor.FromRGB(101, 216, 0);
            };
            TouchUpInside += (sender, e) =>
            {
                BackgroundColor = UIColor.FromRGB(101, 216, 250);
            };
            SetImage(image, UIControlState.Normal);
        }

        public STLButton(string text, UIImage image)
        {
            BackgroundColor = UIColor.FromRGB(101, 216, 250);
            ClipsToBounds = true;
            Layer.CornerRadius = 10;
            TouchDown += (sender, e) =>
            {
                BackgroundColor = UIColor.FromRGB(101, 216, 0);
            };
            TouchUpInside += (sender, e) =>
            {
                BackgroundColor = UIColor.FromRGB(101, 216, 250);
            };
            SetTitleColor(UIColor.Black, UIControlState.Normal);
            SetTitle(text, UIControlState.Normal);
            SetImage(image, UIControlState.Normal);
            HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
        }
    }
}