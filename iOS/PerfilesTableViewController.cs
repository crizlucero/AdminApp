using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class PerfilesTableViewController : UITableViewController
    {
        public PerfilesTableViewController (IntPtr handle) : base (handle)
        {
        }

        partial void btnBackGroundImage_Touch(UIButton sender)
        {
        }

        partial void btnImageProfile(UIButton sender)
        {
        }

        partial void btnSeguir_Touch(UIButton sender)
        {
        }

        partial void btnClose_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnEnviarMensaje_Touch(UIButton sender)
        {
        }

        partial void btnVerMas_Touch(UIButton sender)
        {
        }

        partial void btnSobreMi_Touch(UIButton sender)
        {
        }

        partial void btnSocial_Touch(UIButton sender)
        {
        }

        partial void btnTrabajo_Touch(UIButton sender)
        {
        }
    }
}