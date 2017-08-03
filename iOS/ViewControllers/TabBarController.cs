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
            this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Editar", UIBarButtonItemStyle.Plain, HandleEventHandler), true);
        }

        void HandleEventHandler(object sender, EventArgs e)
        {
            UIViewController controller;
            switch (TabBar.SelectedItem.Title)
            {
                case "Mi Perfil":
                    controller = this.Storyboard.InstantiateViewController("AboutMeModificaController");
                    controller.Title = "Edición de campos";
                    this.NavigationController.PushViewController(controller, true);
                    break;
                case "Mi Empresa":
                    controller = this.Storyboard.InstantiateViewController("EmpresaMiembroModificaController");
                    controller.Title = "Edición de campos";
                    this.NavigationController.PushViewController(controller, true); break;
            }
        }
    }
}
