using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using System.Text.RegularExpressions;

namespace WorklabsMx.iOS
{
    public partial class RegistrarTableViewController : UITableViewController
    {
        const string IdentificadorInvitadosAgregados = "InvitadosAgregados";
        const string IdentificadorCeldaCampos = "Invitados";
        const string IdentificadorCeldaDetalle = "DetalleInvitacion";
        List<int> NumeroCeldas = new List<int>();

        List<UsuarioModel> invitados; 
        //List<SucursalModel> sucursales = new SucursalController().GetSucursales();
        string FechaReservacion = "", Sucursal = "", AsuntoInv = "";
        UsuarioModel invitadoGeneral = new UsuarioModel();
        int CantidadInvitadosAgregados;

        bool fromAgregar = false;

        public RegistrarTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            invitados = new List<UsuarioModel>();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            NumeroCeldas.Add(-1);
            NumeroCeldas.Add(1);
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "E, d MMM yyyy HH:mm";
            FechaReservacion = dateFormat.ToString((NSDate)DateTime.Now);
            if (MenuHelper.ListaSucursales != null)
            {
                if(MenuHelper.ListaSucursales.Count > 0)
                {
                    Sucursal = MenuHelper.ListaSucursales[0].Sucursal_Descripcion;
                }
                else
                {
                    Sucursal = "";
                }
            }
            else 
            {
                Sucursal = "";
            }
             //sucursales[0].Sucursal_Descripcion;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            CantidadInvitadosAgregados = -1;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        partial void btnAtras(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            var current = NumeroCeldas[indexPath.Row];
            if (current == - 1)
            {
                return 142;
            }
            else if (current == 0)
            {
                return 93;
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
            if (current == 0)
            {
                var CeldaInvitados = (CeldaInvitadosAgregados)tableView.DequeueReusableCell(IdentificadorInvitadosAgregados, indexPath);
                UsuarioModel invitado = new UsuarioModel();

                if (fromAgregar)
                {
                    invitado = this.invitados[0];
                    fromAgregar = false;
                }
                else
                {
                    invitado = this.invitados[indexPath.Row - 1];
                }
                CeldaInvitados.UpdateCell(invitado);
                invitado = null;
                return CeldaInvitados;
            }
            else if (current == -1)
            {
                var CeldaInvitados = (CeldaInvitados)tableView.DequeueReusableCell(IdentificadorCeldaCampos, indexPath);
                CeldaInvitados.UpdateCell();
                CeldaInvitados.EventosCeldaInvitadosDelegate = this;
                return CeldaInvitados;
            }
            else
            {
                var CeldaDetalleInvitacion = (CeldaDetalleInvitacion)tableView.DequeueReusableCell(IdentificadorCeldaDetalle, indexPath);
                CeldaDetalleInvitacion.UpdateCell(this.invitados, FechaReservacion, Sucursal, indexPath);
                CeldaDetalleInvitacion.EventosDetalleInvitacionDel = this;
                return CeldaDetalleInvitacion;
            }
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SeleccionarFecha")
            {
                var GenderView = (FechaReservacionPickerViewController)segue.DestinationViewController;
                GenderView.FechaSeleccionDelegate = this;
                GenderView.FromRegister = true;
            }
            else if (segue.Identifier == "sucursales")
            {
                var GenderView = (SucursalesViewController)segue.DestinationViewController;
                GenderView.SucursalDelegate = this;
            }
            else if (segue.Identifier == "DetalleInvitacion")
            {
                var GenderView = (DetalleInvitacionViewController)segue.DestinationViewController;
                GenderView.Invitados = this.invitados;
                var ObjSucursal = MenuHelper.ListaSucursales.Find(x => x.Sucursal_Descripcion == Sucursal);
                GenderView.SucursalModel = ObjSucursal;
                GenderView.Asunto = AsuntoInv;
                GenderView.FechaReservacion = this.FechaReservacion;
            }
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }

        private Boolean ElTextoEsValido(string TextField, String RegularExpr)
        {
            bool EsValido = Regex.IsMatch(TextField, RegularExpr);
            return EsValido;
        }

    }

    partial class RegistrarTableViewController : FechaReservacion
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            this.FechaReservacion = FechaReservacion;
            this.TableView.ReloadData();
        }
    }

    partial class RegistrarTableViewController : Sucursal
    {
        public void SucursalSeleccionada(String Sucursal)
        {
            this.Sucursal = Sucursal;
            this.TableView.ReloadData();
        }
    }


    partial class RegistrarTableViewController : EventosDetalleInvitacion
    {
        public void AgregarCeldas()
        {
                  
            if (!((invitadoGeneral.Usuario_Nombre == "" || invitadoGeneral.Usuario_Nombre == null) || (invitadoGeneral.Usuario_Apellidos == "" || invitadoGeneral.Usuario_Apellidos == null) || (invitadoGeneral.Usuario_Correo_Electronico == "" || invitadoGeneral.Usuario_Correo_Electronico == null)))
            {
                String EmailRegex = "";
                EmailRegex = KeyChainHelper.GetKey("EmailRegex");
                if (this.ElTextoEsValido(invitadoGeneral.Usuario_Correo_Electronico, EmailRegex))
                {
                    if (invitados.FindAll(x => x.Usuario_Correo_Electronico.Contains(invitadoGeneral.Usuario_Correo_Electronico)).Count > 0)
                    {
                        new MessageDialog().SendToast("Ya agregaste ese correo");
                    }
                    else
                    {
                        NumeroCeldas.Add(0);
                        //this.invitados.Add(invitadoGeneral);
                        this.invitados.Insert(0, invitadoGeneral);
                        NumeroCeldas.Sort((x, y) => x.CompareTo(y));
                        CantidadInvitadosAgregados++;
                        fromAgregar = true;
                        TableView.BeginUpdates();
                        TableView.InsertRows(new[] { NSIndexPath.Create(0, 1) }, UITableViewRowAnimation.Top);
                        TableView.EndUpdates();
                    }

                }
                else
                {
                    new MessageDialog().SendToast("Formato de correo invalido");
                }

            }
            else 
            {
                new MessageDialog().SendToast("Por favor llena todos los campos");
            }
          
        }
        public void QuitarCelda(NSIndexPath indexPath)
        {
            if (NumeroCeldas.Count > 2)
            {
                TableView.BeginUpdates();
                NumeroCeldas.RemoveAt(1);
                this.invitados.RemoveAt(CantidadInvitadosAgregados);
                CantidadInvitadosAgregados--;
                TableView.DeleteRows(new NSIndexPath[] { NSIndexPath.Create(0, 1) }, UITableViewRowAnimation.Left);
                TableView.EndUpdates();
            }
           
        }

        public void ConfirmarInvitaciones(List<UsuarioModel> invitadosLocal)
        {
            this.PerformSegue("DetalleInvitacion", null);
        }

        public void FechaSeleccionada()
        {
            this.PerformSegue("SeleccionarFecha", null);
        }

        public void SucursalSeleccionada()
        {
            this.PerformSegue("sucursales", null);
        }

        public void Asunto(string Asunto)
        {
            this.AsuntoInv = Asunto;
        }
    }

    public partial class RegistrarTableViewController : EventosCeldaInvitados
    {
        public void EventTextFiled(UsuarioModel invitado)
        {
            invitadoGeneral = null;
            invitadoGeneral = new UsuarioModel();
            invitadoGeneral.Usuario_Nombre = invitado.Usuario_Nombre;
            invitadoGeneral.Usuario_Correo_Electronico = invitado.Usuario_Correo_Electronico;
            invitadoGeneral.Usuario_Apellidos = invitado.Usuario_Apellidos;
            invitado = null;
        }
    }

}