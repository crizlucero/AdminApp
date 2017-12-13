using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class TableViewCell : UITableViewCell
    {
        public static readonly UINib Nib = UINib.FromName("MenuTableViewCell", NSBundle.MainBundle);

        public static readonly NSString Key = new NSString("MenuTableViewCell");

        public TableViewCell(IntPtr handle) : base ( handle )
        {
        }

        public static TableViewCell Create()
        {
            return (TableViewCell)Nib.Instantiate(null, null)[0];
        }
        internal void BindData(string strLabel, string strIconPath)
        {
            lblMenu.Text = strLabel;
            imgViewMenu.Image = UIImage.FromBundle(strIconPath);
        }
    }
}