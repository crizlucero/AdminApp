using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.ViewElements;

namespace WorklabsMx.iOS
{
    public partial class PerfilController : UIViewController
    {
        MiembroModel miembro;
        public PerfilController(IntPtr handle) : base(handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            miembro = new MiembrosController().GetMemberData(storageLocal.Get("Miembro_Id"));


            new InfoPersonaCard(miembro, View, 60);
        }
    }
}