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

        List<MiembroModel> invitados = new List<MiembroModel>();
        List<SucursalModel> sucursales = new SucursalController().GetSucursales();
        string FechaReservacion = "", Sucursal = "";

        public RegistrarTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
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
                TableView.BeginUpdates();
                TableView.InsertRows(new[] { NSIndexPath.Create(0, 0) }, UITableViewRowAnimation.Left);
                TableView.EndUpdates();
                //this.TableView.ReloadData();
            }
        }

        void EventTextFiled(object sender, EventArgs e)
        {
            var invitado = (MiembroModel)sender;
            if (invitados.Contains(invitado) == false)
            {
                invitados.Add(invitado);
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
                CeldaDetalleInvitacion.UpdateCell(invitados, FechaReservacion, Sucursal);
                CeldaDetalleInvitacion.AgregarCeldas += AgregarCeldas;
                CeldaDetalleInvitacion.ConfirmarInvitaciones += ConfirmarInvitaciones;
                CeldaDetalleInvitacion.FechaSeleccionada += FechaSeleccionada;
                CeldaDetalleInvitacion.SucursalSeleccionada += SucursalSeleccionada;
                //HideButton = true;
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
                GenderView.FechaCanceladaDelegate = this;
                GenderView.FromRegister = true;
            }
            else if (segue.Identifier == "sucursales")
            {
                var GenderView = (SucursalesViewController)segue.DestinationViewController;
                GenderView.SucursalSeleccionadaDel = this;
                GenderView.SucursalCanceladaDel = this;
            }
            else if (segue.Identifier == "DetalleInvitacion")
            {
                var GenderView = (DetalleInvitacionViewController)segue.DestinationViewController;
                GenderView.Invitados = this.invitados;
                var ObjSucursal = sucursales.Find(x => x.Sucursal_Descripcion == Sucursal);
                GenderView.DomicilioInvitacion = ObjSucursal.Sucursal_Descripcion + " " + ObjSucursal.Sucursal_Domicilio;
                GenderView.FechaReservacion = this.FechaReservacion;
                GenderView.CerrarVistaDel = this;
            }
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }

    }

    partial class RegistrarTableViewController : FechaReservaSeleccionada
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            this.FechaReservacion = FechaReservacion;
            contadorFechas = 0;
            this.TableView.ReloadData();
        }
    }

    partial class RegistrarTableViewController : FechaReservaCancelada
    {
        public void FechaReservaCancelada()
        {
            contadorFechas = 0;
            this.TableView.ReloadData();
        }
    }

    partial class RegistrarTableViewController : SucursalSeleccionada
    {
        public void SucursalSeleccionada(String Sucursal)
        {
            this.Sucursal = Sucursal;
            ContadorSucursales = 0;
            this.TableView.ReloadData();
        }
    }

    partial class RegistrarTableViewController : SucursalCancelada
    {
        public void SucursalCancelada()
        {
            ContadorSucursales = 0;
            this.TableView.ReloadData();
        }
    }

    partial class RegistrarTableViewController : CerrarVista
    {
        public void CerrarVista()
        {
            contadorConfirmar = 0;
            this.TableView.ReloadData();
        }
    }

}