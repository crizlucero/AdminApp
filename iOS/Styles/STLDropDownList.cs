using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS.Styles
{
    public class STLDropDownList : UITableView
    {
        public STLDropDownList(List<string> items, UITextField field)
        {
            Frame = new CGRect(0, UIScreen.MainScreen.Bounds.Height * 2 / 3, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height / 3);
            Source = new DropDownListSource(items, field, this);
            Layer.BorderColor = UIColor.LightGray.CGColor;
            Layer.BorderWidth = 1;
        }
    }
}
