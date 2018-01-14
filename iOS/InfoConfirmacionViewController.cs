using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using EventKit;
using CoreLocation;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class InfoConfirmacionViewController : UIViewController
    {

        public List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();
        NSDateFormatter dateFormat = new NSDateFormatter();

        public InfoConfirmacionViewController (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            nfloat WidthView = 0;

            nfloat XLabelDia = 8;
            nfloat XLabelDiaNumero = 0;
            nfloat XLabekNivel = 8;
            nfloat XLabelNombreSala = 8;
            nfloat XLabelHoraInicioFin = 8;
            nfloat XVistaDianNumero = 67;

            for (int indice = 0; indice < this.Reservaciones.Count; indice++)
            {
                WidthView = WidthView + this.vwInfoConfirmacion.Frame.Width;
            }
            //this.pcSucursales.Pages = this.SalasJuntas.Count;
            CGRect newFrame = new CGRect(this.vwInfoConfirmacion.Frame.X, this.vwInfoConfirmacion.Frame.Y, WidthView, this.vwInfoConfirmacion.Frame.Height);

            this.vwInfoConfirmacion.Frame = newFrame;

            var PrimeraReservacion = Reservaciones[0];
            dateFormat.DateFormat = "dd/MM/yyyy";
            NSDate newFormatDate = dateFormat.Parse(PrimeraReservacion.Sala_Fecha);
            this.lblDia.Text = this.FormatoDiaSeleccionado(newFormatDate);
            this.lblNivel.Text = "NIVEL " + PrimeraReservacion.Sala_Nivel;

            dateFormat.DateFormat = "dd";
            newFormatDate = dateFormat.Parse(PrimeraReservacion.Sala_Fecha);
            var DiaSeleccionado = dateFormat.ToString(newFormatDate);
            this.lblDiaNumero.Text = DiaSeleccionado;
            this.lblNombreSala.Text = "SALA " + PrimeraReservacion.Sala_Descripcion;
            this.lblHoraInicioFin.Text = PrimeraReservacion.Sala_Hora_Inicio + " - " + PrimeraReservacion.Sala_Hora_Fin;

            Reservaciones.Remove(PrimeraReservacion);

            foreach (SalaJuntasReservacionModel Reservacion in Reservaciones)
            {
                XLabelDia = XLabelDia + this.lblDia.Frame.Width;
                UILabel LabelDia = new UILabel();
                LabelDia.Frame = new CGRect(XLabelDia, this.lblDia.Frame.Y, this.lblDia.Frame.Width, this.lblDia.Frame.Height);
                newFormatDate = dateFormat.Parse(Reservacion.Sala_Fecha);
                LabelDia.Text = this.FormatoDiaSeleccionado(newFormatDate);

                XLabelDiaNumero = XLabelDiaNumero + this.lblDiaNumero.Frame.Width;
                UILabel LabelDiaNumero = new UILabel();
                LabelDiaNumero.Frame = new CGRect(XLabelDiaNumero, this.lblDiaNumero.Frame.Y, this.lblDiaNumero.Frame.Width, this.lblDiaNumero.Frame.Height);
                dateFormat.DateFormat = "dd";
                newFormatDate = dateFormat.Parse(Reservacion.Sala_Fecha);
                DiaSeleccionado = dateFormat.ToString(newFormatDate);
                LabelDiaNumero.Text = DiaSeleccionado;
                    
                XLabekNivel = XLabekNivel + this.lblNivel.Frame.Width;
                UILabel LabelNivel = new UILabel();
                LabelNivel.Frame = new CGRect(XLabekNivel, this.lblNivel.Frame.Y, this.lblNivel.Frame.Width, this.lblNivel.Frame.Height);
                LabelNivel.Text = "NIVEL " + Reservacion.Sala_Nivel;


                XLabelNombreSala = XLabelNombreSala + this.lblNombreSala.Frame.Width;
                UILabel LabelNombreSala = new UILabel();
                LabelNombreSala.Frame = new CGRect(XLabelNombreSala, this.lblNombreSala.Frame.Y, this.lblNombreSala.Frame.Width, this.lblNombreSala.Frame.Height);
                LabelNombreSala.Text = "SALA " + Reservacion.Sala_Descripcion;

                XLabelHoraInicioFin = XLabelHoraInicioFin + this.lblHoraInicioFin.Frame.Width;
                UILabel LabelHoraInicoFin = new UILabel();
                LabelHoraInicoFin.Frame = new CGRect(XLabelHoraInicioFin, this.lblHoraInicioFin.Frame.Y, this.lblHoraInicioFin.Frame.Width, this.lblHoraInicioFin.Frame.Height);
                LabelHoraInicoFin.Text = Reservacion.Sala_Hora_Inicio + " - " + Reservacion.Sala_Hora_Fin;

                XVistaDianNumero = XVistaDianNumero + this.vwDiaNumero.Frame.Width;
                UIView ViewVistaDiaNumero = new UIView();
                ViewVistaDiaNumero.Frame = new CGRect(XVistaDianNumero, this.vwDiaNumero.Frame.Y, this.vwDiaNumero.Frame.Width, this.vwDiaNumero.Frame.Height);
                ViewVistaDiaNumero.Add(LabelDiaNumero);

                this.vwInfoConfirmacion.Add(LabelDia);
                this.vwInfoConfirmacion.Add(ViewVistaDiaNumero);
                this.vwInfoConfirmacion.Add(LabelNivel);
                this.vwInfoConfirmacion.Add(LabelNombreSala);
                this.vwInfoConfirmacion.Add(LabelHoraInicoFin);
            }

            this.svwInfoConfirmacion.ContentSize = vwInfoConfirmacion.Frame.Size;
        }

        private string FormatoDiaSeleccionado(NSDate Day)
        {
            dateFormat.DateFormat = "EEEE";
            var DiaSeleccionado = dateFormat.ToString(Day);
            return DiaSeleccionado.Substring(0, 3);
        }


        partial void btnContinuar_Touch(UIButton sender)
        {
            
        }

        partial void btnAdelante_Touch(UIButton sender)
        {
        }

        partial void btnAtras_Touch(UIButton sender)
        {
        }
    }
}