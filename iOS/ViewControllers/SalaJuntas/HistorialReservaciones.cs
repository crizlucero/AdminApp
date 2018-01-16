using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using System.Threading.Tasks;
using Foundation;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class HistorialReservaciones : UITableViewController
    {

        const string IdentificadorCeldaHeader = "Header";
        const string IdentificadorCeldaPost = "Contenido";
        const string IdentificadorCeldaNoInfo = "NoInfo";

        const int TamañoReservacion = 94;
        const int TamañoHeader = 42;
        const int TamañoMensajeNoInfo = 400;

        bool isShowInformation = false;
        bool existeConeccion = true;

        List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();

        int SeccionSeleccionada = 0;

        List<UIImageView> ImagesViews = new List<UIImageView>();


        public HistorialReservaciones(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.GetReservaciones((int)TiposReservacion.Activo);

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }


        private void GetReservaciones(int TipoResrvacion)
        {
            if (InternetConectionHelper.VerificarConexion())
            {
                this.Reservaciones = new SalasJuntasController().GetReservaciones(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), TipoResrvacion);
                this.Reservaciones.Sort((p, q) => int.Parse(p.Sala_Hora_Inicio.Replace(":00:00.0000000","")).CompareTo(int.Parse(q.Sala_Hora_Inicio.Replace(":00:00.0000000", ""))));
            }
        }

        void MostrarTipoReservacion(object sender, EventArgs e)
        {
            var TipoReservaciones = int.Parse(sender.ToString());
            this.Reservaciones = new List<SalaJuntasReservacionModel>();

            if(TipoReservaciones == 0)
            {
                this.GetReservaciones((int)TiposReservacion.Activo);
            }
            else
            {
                this.GetReservaciones((int)TiposReservacion.Cancelada);
                var Terminadas = new SalasJuntasController().GetReservaciones(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), (int)TiposReservacion.Terminada);
                foreach(SalaJuntasReservacionModel terminada in Terminadas)
                {
                    this.Reservaciones.Add(terminada);
                }

            }
            this.ActualizarTabla(TipoReservaciones);
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (HeaderReservaciones)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell(this.SeccionSeleccionada);
            headerCell.MostrarTipoReservacion += MostrarTipoReservacion;
            return headerCell;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (Reservaciones.Count > 0)
            {
                isShowInformation = true;
                return Reservaciones.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                return TamañoReservacion;
            }
            else
            {
                return TamañoMensajeNoInfo;
            }
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var current = Reservaciones[indexPath.Row];
                var currentPostCell = (ReservacionesSalaCell)tableView.DequeueReusableCell(IdentificadorCeldaPost, indexPath);
                currentPostCell.UpdateCell(current, this.SeccionSeleccionada);
                this.WillDisplay(indexPath.Row);
                return currentPostCell;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (NoInfoReservacionesCell)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }

        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
        {
            switch (editingStyle)
            {
                case UITableViewCellEditingStyle.Delete:
                    bool eliminado = false;
                    if(InternetConectionHelper.VerificarConexion())
                    {
                        eliminado = new SalasJuntasController().CancelarSalaJuntas("BAJA", this.Reservaciones[indexPath.Row].Sala_Junta_Reservacion_Id);
                    }
                    if (eliminado)
                    {
                        Reservaciones.RemoveAt(indexPath.Row);
                        this.TableView.ReloadData();
                    }
                    break;
                case UITableViewCellEditingStyle.None:
                    Console.WriteLine("CommitEditingStyle:None called");
                    break;
            }
        }

        public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (this.SeccionSeleccionada == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }

        public override string TitleForDeleteConfirmation(UITableView tableView, NSIndexPath indexPath)
        {
            return "Cancelar";
        }

        private void WillDisplay(int Row)
        {
            BTProgressHUD.Dismiss();
        }


        private async void ActualizarTabla(int CampoSeleccionado)
        {
            BTProgressHUD.Show();
            await Task.Delay(2000);
            this.SeccionSeleccionada = CampoSeleccionado;
            this.TableView.ReloadData();
        }

        partial void btnBack_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }
    }

}