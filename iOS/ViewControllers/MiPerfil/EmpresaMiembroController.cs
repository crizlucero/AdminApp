using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.ViewElements;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class EmpresaMiembroController : UIViewController
    {
        EmpresaModel empresa;
        public EmpresaMiembroController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            empresa = new EmpresaController().GetEmpresaMiembro(KeyChainHelper.GetKey("Usuario_Id"));

            new InfoEmpresaCard(empresa, View, 60);
        }
    }
}