using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using System.Text.RegularExpressions;

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
        List<UsuarioModel> invitadosLocal;

        public EventosDetalleInvitacion EventosDetalleInvitacionDel;

        NSIndexPath indexPathLocal;

        List<SucursalModel> sucursales = new SucursalController().GetSucursales();

        public CeldaDetalleInvitacion (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(List<UsuarioModel> invitados, string FechaReservacion, string Sucursal, NSIndexPath indexPath)
        {
            this.lblFecha.Text = FechaReservacion;
            this.lblUbicacion.Text = Sucursal;
            invitadosLocal = invitados;
            indexPathLocal = indexPath;
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

        partial void btnInvitar_Touch(UIButton sender)
        {
            var ErrorInvitar = false;
            var EmailValido = true;
            foreach (UsuarioModel invitado in invitadosLocal)
            {

                if (invitado.Usuario_Apellidos != "" && invitado.Usuario_Apellidos != null && invitado.Usuario_Nombre != "" && invitado.Usuario_Nombre != null && invitado.Usuario_Correo_Electronico != "" && invitado.Usuario_Correo_Electronico != null)
                {
                    String EmailRegex = "";
                    EmailRegex = KeyChainHelper.GetKey("EmailRegex");
                    bool EmailEsValido = false;
                    if (invitado.Usuario_Correo_Electronico != null)
                    {
                        EmailEsValido = this.ElTextoEsValido(invitado.Usuario_Correo_Electronico, EmailRegex);
                    }
                    if (EmailEsValido)
                    {
                        var Sucursal = sucursales.Find(x => x.Sucursal_Descripcion == lblUbicacion.Text);
                        if (InternetConectionHelper.VerificarConexion())
                        {
                            if (new InvitadosController().RegistraInvitado(invitado.Usuario_Nombre, invitado.Usuario_Apellidos, invitado.Usuario_Correo_Electronico, txtAsunto.Text, DateTime.Parse(lblFecha.Text), Sucursal.Sucursal_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo")) != -1)
                            {
                                ErrorInvitar = false;
                                this.DomicilioInvitacion = Sucursal.Sucursal_Descripcion + " " + Sucursal.Sucursal_Domicilio;
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
                    else
                    {
                        EmailValido = false;
                        break;
                    }


                }
                else
                {
                    new MessageDialog().SendToast("Algunos campos estan vacíos");
                    break;
                }
            }
            if (ErrorInvitar)
            {
                new MessageDialog().SendToast("No se pudieron enviar las invitaciones, intente de nuevo");
            }
            else if (EmailValido == false)
            {
                new MessageDialog().SendToast("El Email no es válido");
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

        partial void btnQuitar_Touch(UIButton sender)
        {
            EventosDetalleInvitacionDel.QuitarCelda(indexPathLocal);
        }
    }
}