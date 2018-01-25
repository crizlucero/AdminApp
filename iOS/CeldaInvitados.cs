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
using System.Text.RegularExpressions;

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

            this.txtNombre.ShouldReturn += (textField) => {
                this.txtApellido.BecomeFirstResponder();
                return true;
            };

            this.txtApellido.ShouldReturn += (textField) => {
                this.txtEmail.BecomeFirstResponder();
                return true;
            };


            this.txtEmail.ShouldReturn += (textField) => {
                textField.ResignFirstResponder();
                return true;
            };

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

        private Boolean ElTextoEsValido(string TextField, String RegularExpr)
        {
            bool EsValido = Regex.IsMatch(TextField, RegularExpr);
            return EsValido;
        }
    }
}