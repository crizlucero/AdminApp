using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class TabBarColaboradorController : UITabBarController
    {
        public TabBarColaboradorController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_person_add"), UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                PerpetualEngine.Storage.SimpleStorage.EditGroup("Login").Delete("Colaborador_Id");
                UIViewController controller = this.Storyboard.InstantiateViewController("MisColaboradoresCambiosController");
				controller.Title = "Modifica Colaborador";
				NavigationController.PushViewController(controller, true);
			}), true);
        }
    }
}