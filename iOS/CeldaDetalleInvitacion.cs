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
    public partial class CeldaDetalleInvitacion : UITableViewCell
    {

        public event EventHandler AgregarCeldas;
        string DomicilioInvitacion = "";
        List<MiembroModel> invitadosLocal;

        public event EventHandler ConfirmarInvitaciones;
        public event EventHandler FechaSeleccionada;
        public event EventHandler SucursalSeleccionada;

        List<SucursalModel> sucursales = new SucursalController().GetSucursales();

        public CeldaDetalleInvitacion (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(bool HideButton, List<MiembroModel> invitados, string FechaReservacion, string Sucursal)
        {
            this.lblFecha.Text = FechaReservacion;
            this.lblUbicacion.Text = Sucursal;
            if(HideButton)
            {
                this.btnAgregar.Hidden = true;
                this.btnAgregar.Enabled = false;
            }
            else
            {
                this.btnAgregar.Hidden = false;
                this.btnAgregar.Enabled = true;
            }
            invitadosLocal = invitados;
        }

        partial void btnAgregar_Touch(UIButton sender)
        {
            var contadorEventos = 0;
            if (AgregarCeldas != null)
            {
                AgregarCeldas(contadorEventos, EventArgs.Empty);
            }
        }

        partial void btnFecha_Touch(UIButton sender)
        {
            if (FechaSeleccionada != null)
            {
                FechaSeleccionada(null, EventArgs.Empty);
            }
        }

        partial void btnUbicacion_Touch(UIButton sender)
        {
            if (SucursalSeleccionada != null)
            {
                SucursalSeleccionada(null, EventArgs.Empty);
            }
        }

        partial void btnInvitar_Touch(UIButton sender)
        {
            var ErrorInvitar = false;

            foreach (MiembroModel invitado in invitadosLocal)
            {
                if ((invitado.Miembro_Nombre != "" && invitado.Miembro_Apellidos != "" && invitado.Miembro_Correo_Electronico != ""))
                {
                    var Sucursal = sucursales.Find(x => x.Sucursal_Descripcion == lblUbicacion.Text);
                    if (InternetConectionHelper.VerificarConexion())
                    {
                        if (new InvitadosController().RegistraInvitado(invitado.Miembro_Nombre, invitado.Miembro_Apellidos, invitado.Miembro_Correo_Electronico, txtAsunto.Text, DateTime.Parse(lblFecha.Text), Sucursal.Sucursal_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo")) != -1)
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
                    new MessageDialog().SendToast("Algunos campos estan vacíos");
                    break;
                }
            }
            if (ErrorInvitar)
            {
                new MessageDialog().SendToast("No se pudieron enviar las invitaciones, intente de nuevo");
            }
            else
            {
                if (ConfirmarInvitaciones != null)
                {
                    ConfirmarInvitaciones(invitadosLocal, EventArgs.Empty);
                }
            }
        }
    }
}