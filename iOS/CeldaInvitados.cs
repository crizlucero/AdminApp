using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using System.Threading.Tasks;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class CeldaInvitados : UITableViewCell
    {
        
        public CeldaInvitados (IntPtr handle) : base (handle)
        {
            
        }

        List<bool> TextFilled = new List<bool> { false, false, false };
        public event EventHandler EventTextFiled;

        MiembroModel invitado = new MiembroModel();

        public void UpdateCell()
        {
            txtApellido.EditingChanged += (sender, e) =>
            {
                invitado.Miembro_Apellidos = txtApellido.Text;
                this.SendTextStatus();
            };

            txtNombre.EditingChanged += (sender, e) =>
            {
                invitado.Miembro_Nombre = txtNombre.Text;
                this.SendTextStatus();
            };

            txtEmail.EditingChanged += (sender, e) =>
            {
                invitado.Miembro_Correo_Electronico = txtEmail.Text;
                this.SendTextStatus();
            };

            txtApellido.AttributedPlaceholder = new NSAttributedString("APELLIDO", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
            txtNombre.AttributedPlaceholder = new NSAttributedString("NOMBRE", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
            txtEmail.AttributedPlaceholder = new NSAttributedString("EMAIL", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
        }

        private void SendTextStatus()
        {
            if (EventTextFiled != null)
            {
                EventTextFiled(invitado, EventArgs.Empty);
            }

        }
    }
}