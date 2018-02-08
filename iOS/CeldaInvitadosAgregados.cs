using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class CeldaInvitadosAgregados : UITableViewCell
    {
        public CeldaInvitadosAgregados(IntPtr handle) : base(handle)
        {
        }
        public void UpdateCell(UsuarioModel invitado)
        {
            lblCorreo.Text = invitado.Usuario_Correo_Electronico;
            lblNombre.Text = invitado.Usuario_Nombre + " " + invitado.Usuario_Apellidos;
        }
    }
}