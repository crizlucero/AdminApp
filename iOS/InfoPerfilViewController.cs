using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
//using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using AVFoundation;
using Photos;
using WorklabsMx.Helpers;
using System.Globalization;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class InfoPerfilViewController : UITableViewController
    {

       public List<string> ListUser = new List<string>();

        public InfoPerfilViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            StyleHelper.StyleBlack(this.vwInfoGeneral.Layer);
            StyleHelper.StyleBlack(this.imgPerfil.Layer);
            var Miembro = new MiembrosController().GetMemberData(ListUser[0] ?? ListUser[1], ListUser[2]);
            this.lblCorreo.Text = Miembro.Miembro_Correo_Electronico;
            this.lblNombre.Text = Miembro.Miembro_Nombre;
            this.lblPuesto.Text = Miembro.Miembro_Puesto;
            this.lblEmpresa.Text = Miembro.Miembro_Empresa;
            this.lblProfesion.Text = Miembro.Miembro_Profesion;
            this.lblTelContacto.Text = Miembro.Miembro_Telefono;
            this.lblFechaNacimiento.Text = Miembro.Miembro_Fecha_Nacimiento;
        }

        partial void btnClose_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}