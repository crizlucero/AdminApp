using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class VistaLikes : UIViewController
    {

        public List<UsuarioModel> UsuariosLikes = new List<UsuarioModel>();

        public VistaLikes (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
            if(segue.Identifier == "ListaLikes")
            {
                var TableLikes = (TableViewLikes)segue.DestinationViewController;
                TableLikes.UsuariosLikes = UsuariosLikes;
            } 
		}

        partial void btnClose_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}