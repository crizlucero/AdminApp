using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.ViewElements;

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
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            empresa = new EmpresaController().GetEmpresaMiembro(storageLocal.Get("Usuario_Id"));

            new InfoEmpresaCard(empresa, View, 60);
        }
    }
}