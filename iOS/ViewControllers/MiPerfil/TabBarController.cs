using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class TabBarController : UITabBarController
    {
        public TabBarController(IntPtr handle) : base(handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if (PerpetualEngine.Storage.SimpleStorage.EditGroup("Login").Get("Usuario_Tipo") == "1")
                NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_create"), UIBarButtonItemStyle.Plain, HandleEventHandler), true);
        }

        void HandleEventHandler(object sender, EventArgs e)
        {
            UIViewController controller;
            switch (TabBar.SelectedItem.Title)
            {
                case "Mi Perfil":
                    controller = Storyboard.InstantiateViewController("AboutMeModificaController");
                    break;
                default: 
                    controller = Storyboard.InstantiateViewController("EmpresaMiembroModificaController");
                    break;
            }
			controller.Title = "Actualizar datos";
			this.NavigationController.PushViewController(controller, true);
        }
        public override void ViewWillAppear(bool animated) =>
            TabBar.Hidden |= PerpetualEngine.Storage.SimpleStorage.EditGroup("Login").Get("Usuario_Tipo") == "2";
    }
}
