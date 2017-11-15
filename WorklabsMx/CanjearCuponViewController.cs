using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;
using System.Collections.Generic;
using WorklabsMx.Enum;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using BigTed;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class CanjearCuponViewController : UIViewController
    {
        public CanjearCuponViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            StyleHelper.Style(btnCanjearCupon.Layer);
            StyleHelper.Style(vwCanjearCupon.Layer);
        }

        partial void btnCanjear_TouchUpInside(UIButton sender)
        {
            
        }

        partial void btnBack_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}