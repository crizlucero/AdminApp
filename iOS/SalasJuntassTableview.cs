using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.Models;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{

    public interface EventosSalaJuntas
    {
        void SalaSeleccionada(SalaJuntasModel SalaSeleccionada);
    }

    public partial class SalasJuntassTableview : UITableViewController
    {
        public List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
        public string SucursalId;
        public string FechaSeleccionada;
        public string CantidadUsuarios;
        public List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();


        public EventosSalaJuntas SalaJuntasDelegate;
        bool isShowInformation = false;
        public bool existeConeccion = true;

        const int TamañoCeldaSalas = 220;
        const int TamañoCeldaNoInfo = 300;

        const string IndentificadorCeldaSalas = "CeldaSalas";
        const string IndentificadorCeldaNoInfo = "NoInfo";

        public SalasJuntassTableview (IntPtr handle) : base (handle)
        {
        }

		public override  void ViewDidLoad()
		{
			base.ViewDidLoad();
           
            TableView.ReloadData();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if(isShowInformation)
            {
                return TamañoCeldaSalas;
            }
            else
            {
                return TamañoCeldaNoInfo;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (SalasJuntas != null)
            {
                if (SalasJuntas.Count == 0)
                {
                    isShowInformation = false;
                    return 1;
                }
                isShowInformation = true;
                return SalasJuntas.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            if(isShowInformation)
            {
                var SalaJuntasSeleccionada = SalasJuntas[indexPath.Row];
                this.SalaJuntasDelegate.SalaSeleccionada(SalaJuntasSeleccionada);   
            }
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var SalaJuntas = SalasJuntas[indexPath.Row];
                var currentSalaCell = (SalasJuntasCelda)tableView.DequeueReusableCell(IndentificadorCeldaSalas, indexPath);
                currentSalaCell.UpdateCell(SalaJuntas);
                return currentSalaCell;
            }
            else
            {
                var CeldaNoInfo = (NoSalasCell)tableView.DequeueReusableCell(IndentificadorCeldaNoInfo, indexPath);
                if (!existeConeccion)
                {
                    CeldaNoInfo.UpdateCell("No hay conexión a internet");
                }
                else
                {
                    CeldaNoInfo.UpdateCell("No hay salas disponibles");
                }
                return CeldaNoInfo;
            }
        }

    }
}