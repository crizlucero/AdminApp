using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class PerfilSocialTableViewController : UIViewController
    {
        public List<RedSocialModel> Redes_Sociales;

        public PerfilSocialTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SobreMi")
            {
                var InfoPeril = (PerfilRedesSociales)segue.DestinationViewController;
                InfoPeril.Redes_Sociales = Redes_Sociales;
            }
           
        }


    }
}