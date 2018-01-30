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

    public interface EventosCeldaInvitados
    {
        void EventTextFiled(UsuarioModel invitado);
    }

    public partial class CeldaInvitados : UITableViewCell
    {
        
        public CeldaInvitados (IntPtr handle) : base (handle)
        {
            
        }

        public EventosCeldaInvitados EventosCeldaInvitadosDelegate;
        List<bool> TextFilled = new List<bool> { false, false, false };
        UsuarioModel invitado = new UsuarioModel();

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
                invitado.Usuario_Apellidos = txtApellido.Text;
                this.SendTextStatus();
            };

            txtNombre.EditingChanged += (sender, e) =>
            {
                invitado.Usuario_Nombre = txtNombre.Text;
                this.SendTextStatus();
            };

            txtEmail.EditingChanged += (sender, e) =>
            {
                invitado.Usuario_Correo_Electronico = txtEmail.Text;
                this.SendTextStatus();
            };

            txtApellido.AttributedPlaceholder = new NSAttributedString("APELLIDO", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
            txtNombre.AttributedPlaceholder = new NSAttributedString("NOMBRE", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
            txtEmail.AttributedPlaceholder = new NSAttributedString("EMAIL", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
        }

        private void SendTextStatus()
        {
            EventosCeldaInvitadosDelegate.EventTextFiled(invitado);
        }

        private Boolean ElTextoEsValido(string TextField, String RegularExpr)
        {
            bool EsValido = Regex.IsMatch(TextField, RegularExpr);
            return EsValido;
        }
    }
}