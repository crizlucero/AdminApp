using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
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
            if(InternetConectionHelper.VerificarConexion())
            {
                var Miembro = new MiembrosController().GetMemberData((ListUser[0] != "") ? ListUser[0] : ListUser[1], ListUser[2]);
                this.lblCorreo.Text = (Miembro.Miembro_Correo_Electronico != "") ? Miembro.Miembro_Correo_Electronico : "Sin Info";
                this.lblNombre.Text = (Miembro.Miembro_Nombre != "") ? Miembro.Miembro_Nombre : "Sin Info";
                this.lblPuesto.Text = (Miembro.Miembro_Puesto != "") ? Miembro.Miembro_Puesto : "Sin Info";
                this.lblEmpresa.Text = (Miembro.Miembro_Empresa != null) ? Miembro.Miembro_Empresa : "Sin Info";
                this.lblProfesion.Text = (Miembro.Miembro_Profesion != "") ? Miembro.Miembro_Profesion : "Sin Info";
                this.lblTelContacto.Text = (Miembro.Miembro_Telefono != "") ? Miembro.Miembro_Telefono : "Sin Info";
                if (Miembro.Miembro_Fecha_Nacimiento != "")
                {
                    var arrFecha = Miembro.Miembro_Fecha_Nacimiento.Split('-');
                    this.lblFechaNacimiento.Text = arrFecha[2] + "/" + arrFecha[1] + "/" + arrFecha[2];
                    this.lblFechaNacimiento.TextColor = UIColor.Clear.FromHex(0x95D6FF);
                }
                else
                {
                    this.lblFechaNacimiento.Text = "Sin Info";
                    this.lblFechaNacimiento.TextColor = UIColor.Clear.FromHex(0x444444);
                }

                this.lblCorreo.TextColor = (this.lblCorreo.Text == "Sin Info") ? UIColor.Clear.FromHex(0x444444) : UIColor.Clear.FromHex(0x95D6FF);
                this.lblPuesto.TextColor = (this.lblPuesto.Text == "Sin Info") ? UIColor.Clear.FromHex(0x444444) : UIColor.Clear.FromHex(0x95D6FF);
                this.lblProfesion.TextColor = (this.lblProfesion.Text == "Sin Info") ? UIColor.Clear.FromHex(0x444444) : UIColor.Clear.FromHex(0x95D6FF);
                this.lblTelContacto.TextColor = (this.lblTelContacto.Text == "Sin Info") ? UIColor.Clear.FromHex(0x444444) : UIColor.Clear.FromHex(0x95D6FF);
            }
            else
            {
                new MessageDialog().SendToast("No tienes acceso a una conexión de Internet");
            }
           
        }

        partial void btnClose_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

    }
}