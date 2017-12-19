using System;
using UIKit;
using WorklabsMx.iOS.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using System.Threading.Tasks;
using Foundation;
using CoreGraphics;

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

        List<ReservacionSalaModel> Reservaciones = new List<ReservacionSalaModel>();

        int SeccionSeleccionada = 0;

        UIScrollView scrollView;
        List<UIImageView> ImagesViews = new List<UIImageView>();


        nfloat h = 50.0f;
        nfloat w = 50.0f;
        nfloat padding = 10.0f;
        nint n = 5;

        public HistorialReservaciones(IntPtr handle) : base(handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var reservacion1 = new ReservacionSalaModel();
            this.Reservaciones.Add(reservacion1);
            this.CreateScrollView();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        void MostrarTipoReservacion(object sender, EventArgs e)
        {
            var TipoReservaciones = int.Parse(sender.ToString());
            this.Reservaciones = new List<ReservacionSalaModel>();

            if(TipoReservaciones == 0)
            {
                //this.Reservaciones = //consulta para traer reservaciones con el filtro de pendientes o a realizar
                //simulacion que se tiene una reservacion pendiente
                var reservacion1 = new ReservacionSalaModel();
                this.Reservaciones.Add(reservacion1);
            }
            else
            {
                //this.Reservaciones = //consulta para traer reservaciones con el filtro de canceladas o realizadas

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
                currentPostCell.UpdateCell(current);
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
                    // remove the item from the underlying data source
                    Reservaciones.RemoveAt(indexPath.Row);
                                      // delete the row from the table
                    //tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
                    this.TableView.ReloadData();
                    break;
                case UITableViewCellEditingStyle.None:
                    Console.WriteLine("CommitEditingStyle:None called");
                    break;
            }
        }

        public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
        {
            return true; // return false if you wish to disable editing for a specific indexPath or for all rows
        }

        public override string TitleForDeleteConfirmation(UITableView tableView, NSIndexPath indexPath)
        {   // Optional - default text is 'Delete'
            return "Cancelar";
        }

        partial void btnBack(UIBarButtonItem sender)
        {
            this.NavigationController.PopViewController(true);
        }


        private void WillDisplay(int Row)
        {
            int LastRow = Reservaciones.Count - 1;
            if ((Row == LastRow))
            {
                BTProgressHUD.Dismiss();
            }
        }


        private async void ActualizarTabla(int CampoSeleccionado)
        {
            BTProgressHUD.Show();
            await Task.Delay(2000);
            this.SeccionSeleccionada = CampoSeleccionado;
            this.TableView.ReloadData();
        }


        private void CreateScrollView()
        {
           /* scrollView = new UIScrollView
            {
                Frame = new CGRect(0, 200, View.Frame.Width, h + 2 * padding),
                ContentSize = new CGSize((w + padding) * n, h),
                BackgroundColor = UIColor.White,
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth
            };

            for (int i = 0; i < n; i++)
            {
                var imageView = new UIImageView();
                imageView.Image = UIImage.FromBundle("ImagenSala");
                imageView.Frame = new CGRect(padding * (i + 1) + (i * w), padding, View.Frame.Width, h);
                scrollView.AddSubview(imageView);
                ImagesViews.Add(imageView);
            }

            View.AddSubview(scrollView);*/
        }


    }

}