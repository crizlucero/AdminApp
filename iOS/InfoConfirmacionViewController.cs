using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using CoreGraphics;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{

    public interface ConfirmacionRealizada
    {
        void ConfirmacionRealizada();
    }

    public partial class InfoConfirmacionViewController : UIViewController
    {
        public ConfirmacionRealizada ConfirmacionRealizadaDel;

        public List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();
        NSDateFormatter dateFormat = new NSDateFormatter();

        public InfoConfirmacionViewController (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            nfloat WidthView = 0;

            nfloat XLabelDia = 0;
            nfloat XLabelDiaNumero = 0;
            nfloat XLabekNivel = 0;
            nfloat XLabelNombreSala = 0;
            nfloat XLabelHoraInicioFin = 0;
            nfloat XVistaDianNumero = 0;

            for (int indice = 0; indice < this.Reservaciones.Count; indice++)
            {
                WidthView = WidthView + this.vwVistaInfoReservacion.Frame.Width;
            }

            if (this.Reservaciones.Count == 1)
            {
                this.btnAtras.Hidden = true;
                this.btnAtras.Enabled = false;
                this.btnAdelante.Hidden = true;
                this.btnAdelante.Enabled = false;
            }

            CGRect newFrame = new CGRect(this.vwInfoConfirmacion.Frame.X, this.vwInfoConfirmacion.Frame.Y, WidthView, this.vwInfoConfirmacion.Frame.Height);

            this.vwInfoConfirmacion.Frame = newFrame;

            var PrimeraReservacion = Reservaciones[0];
            dateFormat.DateFormat = "dd/MM/yyyy";
            NSDate newFormatDate = dateFormat.Parse(PrimeraReservacion.Sala_Fecha);
            this.lblDia.Text = this.FormatoDiaSeleccionado(newFormatDate);
            this.lblNivel.Text = "NIVEL " + PrimeraReservacion.Sala_Nivel;

            dateFormat.DateFormat = "dd";
            var DiaSeleccionado = dateFormat.ToString(newFormatDate);
            this.lblDiaNumero.Text = DiaSeleccionado;
            this.lblNombreSala.Text = "SALA " + PrimeraReservacion.Sala_Descripcion;
            this.lblHoraInicioFin.Text = PrimeraReservacion.Sala_Hora_Inicio + ":00" + " - " + PrimeraReservacion.Sala_Hora_Fin + ":00";

            Reservaciones.Remove(PrimeraReservacion);

            foreach (SalaJuntasReservacionModel Reservacion in Reservaciones)
            {
                XLabelDia = XLabelDia + this.lblDia.Frame.Width;
                UILabel LabelDia = new UILabel();
                LabelDia.Frame = new CGRect(XLabelDia, this.lblDia.Frame.Y, this.lblDia.Frame.Width, this.lblDia.Frame.Height);
                dateFormat.DateFormat = "dd/MM/yyyy";
                newFormatDate = dateFormat.Parse(Reservacion.Sala_Fecha);
                LabelDia.Text = this.FormatoDiaSeleccionado(newFormatDate);
                LabelDia.Font = lblDia.Font;
                LabelDia.TextAlignment = UITextAlignment.Center;
                 
                XLabekNivel = XLabekNivel + this.lblNivel.Frame.Width;
                UILabel LabelNivel = new UILabel();
                LabelNivel.Frame = new CGRect(XLabekNivel, this.lblNivel.Frame.Y, this.lblNivel.Frame.Width, this.lblNivel.Frame.Height);
                LabelNivel.Text = "NIVEL " + Reservacion.Sala_Nivel;
                LabelNivel.Font = lblNivel.Font;
                LabelNivel.TextAlignment = UITextAlignment.Center;
                LabelNivel.TextColor = lblNivel.TextColor;

                XLabelNombreSala = XLabelNombreSala + this.lblNombreSala.Frame.Width;
                UILabel LabelNombreSala = new UILabel();
                LabelNombreSala.Frame = new CGRect(XLabelNombreSala, this.lblNombreSala.Frame.Y, this.lblNombreSala.Frame.Width, this.lblNombreSala.Frame.Height);
                LabelNombreSala.Text = "SALA " + Reservacion.Sala_Descripcion;
                LabelNombreSala.Font = lblNombreSala.Font;
                LabelNombreSala.TextAlignment = UITextAlignment.Center;

                XLabelHoraInicioFin = XLabelHoraInicioFin + this.lblHoraInicioFin.Frame.Width;
                UILabel LabelHoraInicoFin = new UILabel();
                LabelHoraInicoFin.Frame = new CGRect(XLabelHoraInicioFin, this.lblHoraInicioFin.Frame.Y, this.lblHoraInicioFin.Frame.Width, this.lblHoraInicioFin.Frame.Height);
                LabelHoraInicoFin.Text = Reservacion.Sala_Hora_Inicio + ":00" + " - " + Reservacion.Sala_Hora_Fin+ ":00";
                LabelHoraInicoFin.Font = lblHoraInicioFin.Font;
                LabelHoraInicoFin.TextAlignment = UITextAlignment.Center;
                LabelHoraInicoFin.TextColor = lblHoraInicioFin.TextColor;

                XVistaDianNumero = XVistaDianNumero + this.vwDiaNumero.Frame.Width;
                UIView ViewVistaDiaNumero = new UIView();
                ViewVistaDiaNumero.Frame = new CGRect(XVistaDianNumero, this.vwDiaNumero.Frame.Y, this.vwDiaNumero.Frame.Width, this.vwDiaNumero.Frame.Height);

                XLabelDiaNumero = XLabelDiaNumero + this.lblDiaNumero.Frame.Width;
                UILabel LabelDiaNumero = new UILabel(); ;
                LabelDiaNumero.Frame = this.lblDiaNumero.Frame;//new CGRect(this.lblDiaNumero.Frame.X, this.lblDiaNumero.Frame.Y, this.lblDiaNumero.Frame.Width, this.lblDiaNumero.Frame.Height);
                dateFormat.DateFormat = "dd";
                DiaSeleccionado = dateFormat.ToString(newFormatDate);
                LabelDiaNumero.Text = DiaSeleccionado;
                LabelDiaNumero.Font = lblDiaNumero.Font;
                LabelDiaNumero.TextAlignment = UITextAlignment.Center;
                LabelDiaNumero.TextColor = lblDiaNumero.TextColor;

                ViewVistaDiaNumero.Add(LabelDiaNumero);
                ViewVistaDiaNumero.BackgroundColor = vwDiaNumero.BackgroundColor;
                ViewVistaDiaNumero.Layer.MasksToBounds = true;
                ViewVistaDiaNumero.Layer.CornerRadius = 5f;

                this.vwInfoConfirmacion.Add(LabelDia);
                this.vwInfoConfirmacion.Add(ViewVistaDiaNumero);
                this.vwInfoConfirmacion.Add(LabelNivel);
                this.vwInfoConfirmacion.Add(LabelNombreSala);
                this.vwInfoConfirmacion.Add(LabelHoraInicoFin);
            }

            this.svwInfoConfirmacion.ContentSize = vwInfoConfirmacion.Frame.Size;
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            //StyleHelper.StyleBlack(this.vwVistaInfoReservacion.Layer);
        }

        private string FormatoDiaSeleccionado(NSDate Day)
        {
            dateFormat.DateFormat = "EEEE";
            var DiaSeleccionado = dateFormat.ToString(Day);
            return DiaSeleccionado.Substring(0, 3);
        }


        partial void btnContinuar_Touch(UIButton sender)
        {
            this.DismissViewController(true, () => {
               this.ConfirmacionRealizadaDel.ConfirmacionRealizada();
            });
        }

        partial void btnAdelante_Touch(UIButton sender)
        {
        }

        partial void btnAtras_Touch(UIButton sender)
        {
        }
    }
}