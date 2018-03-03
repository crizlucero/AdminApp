using Foundation;
using System;
using UIKit;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using BigTed;

namespace WorklabsMx.iOS
{

    public interface EventosDetalleInvitacion
    {
        void AgregarCeldas();
        void QuitarCelda(NSIndexPath indexPath);
        void ConfirmarInvitaciones(List<UsuarioModel> invitadosLocal);
        void FechaSeleccionada();
        void SucursalSeleccionada();
        void Asunto(string Asunto);
    }

    public partial class CeldaDetalleInvitacion : UITableViewCell
    {
        string DomicilioInvitacion = "";
        List<UsuarioModel> invitadosLocal = new List<UsuarioModel>();

        public EventosDetalleInvitacion EventosDetalleInvitacionDel;

        NSIndexPath indexPathLocal;

        List<SucursalModel> sucursales = new List<SucursalModel>();

        string correoInvitacion;

        public CeldaDetalleInvitacion (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(List<UsuarioModel> invitados, string FechaReservacion, string Sucursal, NSIndexPath indexPath)
        {
            sucursales = MenuHelper.ListaSucursales;
            this.lblFecha.Text = FechaReservacion;
            this.lblUbicacion.Text = Sucursal;
            invitadosLocal = new List<UsuarioModel>();
            invitadosLocal = invitados;
            indexPathLocal = indexPath;
            correoInvitacion = System.IO.File.ReadAllText("HTML/Invitacion.html");
            if (invitados.Count == 0)
            {
                this.btnQuitar.Enabled = false;
                this.btnQuitar.Hidden = true;
            }
            else
            {
                this.btnQuitar.Enabled = true;
                this.btnQuitar.Hidden = false; 
            }
        }


        partial void btnAgregar_Touch(UIButton sender)
        {
            EventosDetalleInvitacionDel.AgregarCeldas();
        }

        partial void btnFecha_Touch(UIButton sender)
        {
            EventosDetalleInvitacionDel.FechaSeleccionada();
        }

        partial void btnUbicacion_Touch(UIButton sender)
        {
            EventosDetalleInvitacionDel.SucursalSeleccionada();
        }

        async partial void btnInvitar_Touch(UIButton sender)
        {
            var ErrorInvitar = false;
            foreach (UsuarioModel invitado in invitadosLocal)
            {
                
                var Sucursal = sucursales.Find(x => x.Sucursal_Descripcion == lblUbicacion.Text);
                if (InternetConectionHelper.VerificarConexion())
                {
                    if (new InvitadosController().RegistraInvitado(invitado.Usuario_Nombre, invitado.Usuario_Apellidos, invitado.Usuario_Correo_Electronico, txtAsunto.Text, DateTime.Parse(lblFecha.Text), Sucursal.Sucursal_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo")) != -1)
                    {
                        ErrorInvitar = false;
                        this.DomicilioInvitacion = Sucursal.Sucursal_Descripcion + " " + Sucursal.Sucursal_Domicilio;
                        BTProgressHUD.Show(status: "Enviando Correo de Invitación");
                        await EnviarMail(invitado, Sucursal);
                    }
                    else
                    {
                        ErrorInvitar = true;
                        break;
                    }
                }
                else
                {
                    ErrorInvitar = true;
                    break;
                }

            }
            BTProgressHUD.Dismiss();
            if (ErrorInvitar)
            {
                new MessageDialog().SendToast("No se pudieron enviar las invitaciones, intente de nuevo");
            }
            else
            {
                EventosDetalleInvitacionDel.Asunto(txtAsunto.Text);
                EventosDetalleInvitacionDel.ConfirmarInvitaciones(invitadosLocal);

            }
        }

        private Boolean ElTextoEsValido(string TextField, String RegularExpr)
        {
            bool EsValido = Regex.IsMatch(TextField, RegularExpr);
            return EsValido;
        }

        async Task EnviarMail(UsuarioModel invitado, SucursalModel sucursal)
        {
            Emails email = new Emails();
            await email.SendMail(invitado.Usuario_Correo_Electronico, invitado.Usuario_Nombre + " " + invitado.Usuario_Apellidos,
                                       correoInvitacion.Replace("{{NOMBRE}}", invitado.Usuario_Nombre + " " + invitado.Usuario_Apellidos)
                                       .Replace("{{FECHA}}", lblFecha.Text)
                                       .Replace("{{SUCURSAL}}", sucursal.Sucursal_Descripcion)
                                       .Replace("{{CALLE}}", sucursal.Sucursal_Domicilio)
                                       .Replace("{{COLONIA}}", sucursal.Territorio.Colonia)
                                 .Replace("{{QR}}", "INVITADO"), "Sala de juntas");

        }

        partial void btnQuitar_Touch(UIButton sender)
        {
            EventosDetalleInvitacionDel.QuitarCelda(indexPathLocal);

        }
    }
}