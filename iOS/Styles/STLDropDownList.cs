using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS.Styles
{
    public class STLDropDownList : UITableView
    {
        public STLDropDownList(int position, List<string> items, UITextField field)
        {
            Frame = new CGRect(20, position, UIScreen.MainScreen.Bounds.Width / 2, UIScreen.MainScreen.Bounds.Height / 5);
            Source = new DropDownListSource(items, field, this);
        }
    }
}
