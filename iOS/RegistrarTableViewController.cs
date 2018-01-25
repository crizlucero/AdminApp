using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using EventKit;
using CoreLocation;
using System.Text.RegularExpressions;

namespace WorklabsMx.iOS
{
    public partial class RegistrarTableViewController : UITableViewController
    {
        const string IdentificadorCeldaCampos = "Invitados";
        const string IdentificadorCeldaDetalle = "DetalleInvitacion";
        List<int> NumeroCeldas = new List<int>();

        int ContadorEventos;
        int contadorFechas;
        int contadorConfirmar;
        int ContadorSucursales;

        bool HideButton = true;
        List<MiembroModel> invitados = new List<MiembroModel>();
        List<SucursalModel> sucursales = new SucursalController().GetSucursales();
        string FechaReservacion = "", Sucursal = "";

        public RegistrarTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ContadorEventos = 0;
            contadorFechas = 0;
            contadorConfirmar = 0;
            ContadorSucursales = 0;

            NumeroCeldas.Add(0);
            NumeroCeldas.Add(1);
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "E, d MMM yyyy HH:mm";
            FechaReservacion = dateFormat.ToString((NSDate)DateTime.Now);
            Sucursal = sucursales[0].Sucursal_Descripcion;
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }


        void AgregarCeldas(object sender, EventArgs e)
        {
            ContadorEventos = ContadorEventos + 1;
            if (ContadorEventos <= 1)
            {
                NumeroCeldas.Add(0);
                NumeroCeldas.Sort((x, y) => x.CompareTo(y));
                this.TableView.ReloadData();
            }
        }

        void EventTextFiled(object sender, EventArgs e)
        {
            var invitado = (MiembroModel)sender;
            String EmailRegex = "";
            EmailRegex = KeyChainHelper.GetKey("EmailRegex");
            bool EmailEsValido = this.ElTextoEsValido(invitado.Miembro_Correo_Electronico, EmailRegex);
            if ((invitado.Miembro_Apellidos == "" || invitado.Miembro_Apellidos == null) || (invitado.Miembro_Nombre == "" || invitado.Miembro_Nombre == null) || (invitado.Miembro_Correo_Electronico == "" || invitado.Miembro_Correo_Electronico == null) || EmailEsValido == false)
            {
                HideButton = true;
                this.TableView.ReloadData();
            }
            else
            {
                if (invitados.Contains(invitado) == false)
                {
                    invitados.Add(invitado);
                }
                HideButton = false;
                this.TableView.ReloadData();
            }

        }

        partial void btnAtras(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            var current = NumeroCeldas[indexPath.Row];
            if (current == 0)
            {
                return 142;
            }
            else
            {
                return 503;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return NumeroCeldas.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var current = NumeroCeldas[indexPath.Row];
            if(current == 0)
            {
                var CeldaInvitados = (CeldaInvitados)tableView.DequeueReusableCell(IdentificadorCeldaCampos, indexPath);
                CeldaInvitados.UpdateCell();
                CeldaInvitados.EventTextFiled += EventTextFiled;
                return CeldaInvitados;
            }
            else
            {
                ContadorEventos = 0;
                var CeldaDetalleInvitacion = (CeldaDetalleInvitacion)tableView.DequeueReusableCell(IdentificadorCeldaDetalle, indexPath);
                CeldaDetalleInvitacion.UpdateCell(HideButton, invitados, FechaReservacion, Sucursal);
                CeldaDetalleInvitacion.AgregarCeldas += AgregarCeldas;
                CeldaDetalleInvitacion.ConfirmarInvitaciones += ConfirmarInvitaciones;
                CeldaDetalleInvitacion.FechaSeleccionada += FechaSeleccionada;
                CeldaDetalleInvitacion.SucursalSeleccionada += SucursalSeleccionada;
                HideButton = true;
                return CeldaDetalleInvitacion;
            }
        }

        void ConfirmarInvitaciones(object sender, EventArgs e)
        {
            contadorConfirmar = contadorConfirmar + 1;
            if(contadorConfirmar <= 1)
            {
                this.PerformSegue("DetalleInvitacion", null);
            }

        }

        void FechaSeleccionada(object sender, EventArgs e)
        {
            contadorFechas = contadorFechas + 1;
            if(contadorFechas <= 1)
            {
                this.PerformSegue("SeleccionarFecha", null);
            }

        }

        void SucursalSeleccionada(object sender, EventArgs e)
        {
            ContadorSucursales = ContadorSucursales + 1;
            if(ContadorSucursales <= 1)
            {
                this.PerformSegue("sucursales", null);
            }

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SeleccionarFecha")
            {
                var GenderView = (FechaReservacionPickerViewController)segue.DestinationViewController;
                GenderView.FechaSeleccionadaDelegate = this;
                GenderView.FromRegister = true;
            }
            else if (segue.Identifier == "sucursales")
            {
                var GenderView = (SucursalesViewController)segue.DestinationViewController;
                GenderView.SucursalSeleccionadaDel = this;
            }
            else if (segue.Identifier == "DetalleInvitacion")
            {
                var GenderView = (DetalleInvitacionViewController)segue.DestinationViewController;
                GenderView.Invitados = this.invitados;
            }
        }


        private Boolean ElTextoEsValido(string TextField, String RegularExpr)
        {
            bool EsValido = Regex.IsMatch(TextField, RegularExpr);
            return EsValido;
        }
    }

    partial class RegistrarTableViewController : FechaReservaSeleccionada
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            this.FechaReservacion = FechaReservacion;
            this.TableView.ReloadData();
        }
    }

    partial class RegistrarTableViewController : SucursalSeleccionada
    {
        public void SucursalSeleccionada(String Sucursal)
        {
            this.Sucursal = Sucursal;
            this.TableView.ReloadData();
        }
    }
}