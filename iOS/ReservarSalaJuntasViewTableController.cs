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

    public class ListaViews
    {
        public UIView Horarios { get; set; }
        public string HoraInicio { get; set; }
    }

    public partial class ReservarSalaJuntasViewTableController : UITableViewController
    {

        UIStoryboardSegue segueSalasJuntas;


        public string SucursalId;
        NSDateFormatter dateFormat = new NSDateFormatter();
        List<SalaJuntasReservacionModel> HorasNoDisponibles = new List<SalaJuntasReservacionModel>();
        List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
        SalaJuntasModel SalaActual = new SalaJuntasModel();

        List<ListaViews> VistasHorarios = new List<ListaViews>();
        

        float HorasReservadas = 0;
        float CreditosAcumulados = 0;

        string DiaSeleccionado;

        //string SalaId = "";

        float withImage;

        string CantidadPersonas = null;

        string fechaSeleccionada = DateTime.Now.ToString("yyyy-MM-dd");

        const int TamañoCeldaSalas = 230;

        //bool seisPersonasSeleccionado = false, diezPersonasSeleccionado = false;


        SalaJuntasReservacionModel Reservacion = new SalaJuntasReservacionModel();
        string HoraInicio = "";
        string HoraFin = "";

        string HoraFinFormat = "";

        nfloat Size;
        CGRect newFrame;

        DateTime MinDateHoraFin;
        DateTime MinDateHoraInicio;

        public ReservarSalaJuntasViewTableController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            StyleHelper.Style(btnDiezPersonas.Layer);
            StyleHelper.Style(btnSeisPersonas.Layer);
            StyleHelper.Style(this.vwBotonFecha.Layer);
            StyleHelper.Style(this.vwInfoReservacion.Layer);
            StyleHelper.Style(this.vwFechaFin.Layer);
            StyleHelper.Style(this.vwFechaInicio.Layer);
            if (InternetConectionHelper.VerificarConexion())
            {
                this.lblCreditosDisponibles.Text = new SalasJuntasController().GetCreditosDisponibles(KeyChainHelper.GetKey("Usuario_Id")).ToString();
                this.lblCreditosPorUsar.Text = "0";
                withImage = float.Parse(UIScreen.MainScreen.Bounds.Width.ToString());
                NSDateFormatter dateFormate = new NSDateFormatter();
                dateFormate.DateFormat = "yyyy-MM-dd";
                dateFormate.ToString(NSDate.Now);
                this.fechaSeleccionada = dateFormate.ToString(NSDate.Now);
                dateFormate.DateFormat = "dd/MM/yyyy";
                dateFormate.ToString(NSDate.Now);
                this.btnSeleccionFecha.SetTitle(dateFormate.ToString(NSDate.Now), UIControlState.Normal);
                this.UpdateInfo();
            }
            else
            {
                new MessageDialog().SendToast("Se perdió la conexión a internet, intenta mas tarde");
                NavigationController.PopViewController(true);
            }

        }


        private DateTime HoraFinMinima(string Date, string HoraFechaInicio)
        {
            var fecha = Date + " " + HoraFechaInicio;
            DateTime myDate = DateTime.ParseExact(fecha, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.CurrentCulture);
            return myDate;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }


        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                return 361;
            }
            else if (indexPath.Row == 1)
            {
                return Size;
            }
            else
            {
                return 117;
            }

        }

        private void CreditosSeleccionados(string HInicio, string HFin)
        {

            var intHoraInicio = float.Parse(HInicio.Split(':')[0]);
            var intHoraFin = float.Parse(HFin.Split(':')[0]);

            var minutosInicio = int.Parse(HInicio.Split(':')[1]);
            var minutosFin = int.Parse(HFin.Split(':')[1]);

            this.HorasReservadas = intHoraFin - intHoraInicio;
            if (minutosInicio == 30)
            {
                intHoraInicio = intHoraInicio + 0.5f;
                this.HorasReservadas = this.HorasReservadas - 0.5f;
            }
            if (minutosFin == 30)
            {
                intHoraFin = intHoraFin + 0.5f;
                this.HorasReservadas = this.HorasReservadas + 0.5f;
            }

            if (this.SalaActual.Sala_Id != null && this.SalaActual.Sala_Id != "")
            {
                for (float Hora = intHoraInicio; Hora < intHoraFin; Hora = Hora + 0.5f)
                {
                    if (Hora >= 11 && Hora <= 17 && this.SalaActual.Sala_Capacidad == "10")
                    {
                        this.CreditosAcumulados = this.CreditosAcumulados + 1.5f;
                    }
                    else
                    {
                        this.CreditosAcumulados = this.CreditosAcumulados + 1;
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = this.CreditosAcumulados.ToString();
        }

        private void UpdateInfo()
        {

         
            var HoraActual = DateTime.Now.Hour;
            var MinutosActuales = DateTime.Now.Minute;
            string strMinutosActuales;

            int HorasFin;
            string MinutosFin;

            if (MinutosActuales > 30)
            {
                strMinutosActuales = "00";
                HoraActual = HoraActual + 1;
                MinutosFin = "30";
                HorasFin = HoraActual;
            }
            else
            {
                strMinutosActuales = "30";
                HorasFin = HoraActual + 1;
                MinutosFin = "00";
            }

            this.HoraInicio = HoraActual.ToString() + ":" + strMinutosActuales;
            this.HoraFin = HorasFin.ToString() + ":" + MinutosFin;

            MinDateHoraFin = this.HoraFinMinima(this.fechaSeleccionada, this.HoraInicio);



            //this.Reservacion = new SalaJuntasReservacionModel(SalaActual.Sala_Id, HoraInicio, HoraFin, this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f);
            var horaInicioFormato = this.ChangeFormat(HoraActual.ToString(), strMinutosActuales);

            this.btnHoraInicio.SetTitle(horaInicioFormato, UIControlState.Normal);

            var horaFinFormato = this.ChangeFormat(HorasFin.ToString(), MinutosFin);

            this.btnHoraFin.SetTitle(horaFinFormato, UIControlState.Normal);

            this.PrepareForSegue(this.segueSalasJuntas, null);

            HorasReservadas = 0.5f;
            this.lblHorasReservadas.Text = HorasReservadas.ToString();

        }

        private string ChangeFormat(string Hora, string Minutos)
        {
            int HoraInt = int.Parse(Hora);
            int MinutosInt = int.Parse(Minutos);
            string NewHora = Hora;
            string Meridianos;
            if (HoraInt > 12)
            {
                NewHora = (HoraInt - 12).ToString();
                Meridianos = "PM";
            }
            else
            {
                Meridianos = "AM";
            }

            if (NewHora.Length == 1)
            {
                NewHora = NewHora.Insert(0, "0");
            }

            return NewHora + ":" + Minutos + " " + Meridianos;
        }
  
        private void FormatoDiaSeleccionado(NSDate Day)
        {
            dateFormat.DateFormat = "dd";
            DiaSeleccionado = dateFormat.ToString(Day);
            this.lblDiaNumero.Text = DiaSeleccionado;

            dateFormat.DateFormat = "EEEE";
            DiaSeleccionado = dateFormat.ToString(Day);

            this.lblDiaLetra.Text = DiaSeleccionado.Substring(0, 3);

            dateFormat.DateFormat = "dd/MM/yyyy";
            this.btnSeleccionFecha.SetTitle(dateFormat.ToString(Day), UIControlState.Normal);
        }

       

        private void LimpiarInfo()
        {
            this.HorasReservadas = 0;
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.FormatoDiaSeleccionado(NSDate.Now);
        }
      

        partial void btnSeleccionarFecha_Touch(UIButton sender)
        {
            this.PerformSegue("SelectDate", null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "HoraInicio")
            {
                var HoraInicioView = (HoraInicioView)segue.DestinationViewController;
                //HoraInicioView.HoraPreseleccionada = MinDateHoraInicio;
                HoraInicioView.HoraSeleccionadadaDelegate = this;
            }
            else if (segue.Identifier == "HoraFin")
            {
                var HoraFinView = (HoraFinView)segue.DestinationViewController;
                HoraFinView.MiniDate = MinDateHoraFin;
                HoraFinView.HoraSeleccionadadaDelegate = this;
            }
            else if (segue.Identifier == "SelectDate")
            {
                var GenderView = (FechaReservacionPickerViewController)segue.DestinationViewController;
                GenderView.FechaSeleccionDelegate = this;
                GenderView.FromSalaJuntas = true;
            }
            else if (segue.Identifier == "confirmarCompra")
            {
                var VistaConfirmacion = (ConfirmarSalaJuntasController)segue.DestinationViewController;
                VistaConfirmacion.Reservacion = this.Reservacion;
                VistaConfirmacion.SalaActual = this.SalaActual;
                VistaConfirmacion.FechaReservacion = this.fechaSeleccionada;
                VistaConfirmacion.EventosReservacionesDelegate = this;
            }
            else if (segue.Identifier == "DetalleReservacion")
            {
                var VistaInfoReservacion = (InfoConfirmacionViewController)segue.DestinationViewController;
                VistaInfoReservacion.Reservaciones = this.Reservacion;
                VistaInfoReservacion.ConfirmacionRealizadaDel = this;
            }
            else if (segue.Identifier == "SalasJuntas")
            {
                this.segueSalasJuntas = segue;
                if (!(this.HoraInicio == "" || this.HoraFin == ""))
                {
                    MenuHelper.GetSalas(SucursalId, this.fechaSeleccionada, this.HoraInicio, this.HoraFin, this.CantidadPersonas);
                    this.SalasJuntas = MenuHelper.SalasJuntas;
                    this.pintarSalas();
                    this.TableView.ReloadData();
                }
                var VistaTablaSalas = (SalasJuntassTableview)segue.DestinationViewController;
                VistaTablaSalas.SalaJuntasDelegate = this;
                VistaTablaSalas.SalasJuntas = this.SalasJuntas;
                VistaTablaSalas.FechaSeleccionada = fechaSeleccionada;
                VistaTablaSalas.SucursalId = this.SucursalId;
                VistaTablaSalas.ViewDidLoad();
            }

        }

        partial void btnDiezPersonas_Touch(UIButton sender)
        {
            this.btnDiezPersonas.BackgroundColor = UIColor.Red;
            this.btnSeisPersonas.BackgroundColor = UIColor.Clear.FromHex(0x95D6FF);
            this.CantidadPersonas = "10";
            this.PrepareForSegue(this.segueSalasJuntas, null);
        }

        partial void btnSeisPersonas_Touch(UIButton sender)
        {
            this.btnDiezPersonas.BackgroundColor = UIColor.Clear.FromHex(0x95D6FF);
            this.btnSeisPersonas.BackgroundColor = UIColor.Red;
            this.CantidadPersonas = "6";
            this.PrepareForSegue(this.segueSalasJuntas, null);
        }

        partial void btnAgendar_Touch(UIButton sender)
        {
            if (this.Reservacion.Sala_Id != "")
            {
                if (this.Reservacion.Creditos_Usados <= float.Parse(this.lblCreditosDisponibles.Text))
                {
                    this.PerformSegue("confirmarCompra", null);
                }
                else
                {
                    new MessageDialog().SendToast("No tienes suficientes créditos");
                }
            }
            else
            {
                new MessageDialog().SendToast("No has seleccionado una sala");
            }
        }

        partial void btnHoraInicio_Touch(UIButton sender)
        {
            this.PerformSegue("HoraInicio", null);
        }

        partial void btnHoraFin_Touch(UIButton sender)
        {
            this.PerformSegue("HoraFin", null);
        }

        void pintarSalas()
        {
            var SizeViewX = this.SalasJuntas.Count * TamañoCeldaSalas + 20;
            Size = SizeViewX;
            newFrame = new CGRect(this.cvwSalasJuntas.Frame.X, this.cvwSalasJuntas.Frame.Y, this.cvwSalasJuntas.Frame.Width, SizeViewX);
            this.cvwSalasJuntas.Frame = newFrame;
        }

        private string CambiarFormato(NSDate Date)
        {
            NSDateFormatter dateFormati = new NSDateFormatter();
            dateFormati.DateFormat = "hh:mm a";
            return dateFormat.ToString(Date);
        }

        private string Formato24(string fecha)
        {
            string NewDate = fecha;
            int Hora = int.Parse(fecha.Split(':')[0]);
            if (Hora > 12)
            {
                NewDate = "";
                var NewHora = (Hora - 12).ToString();
                if (NewHora.Length == 1)
                {
                    NewHora = "0" + NewHora;
                }

                NewDate = NewHora + ":" + fecha.Split(':')[1] + " PM";

            }
            return NewDate;

        }

    }


    partial class ReservarSalaJuntasViewTableController : FechaReservacion
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            fechaSeleccionada = FechaReservacion;
            this.btnSeleccionFecha.SetTitle(FechaReservacion, UIControlState.Normal);
            if (InternetConectionHelper.VerificarConexion())
            {
                this.HorasNoDisponibles = new SalasJuntasController().GetHorasNoDisponibles(FechaReservacion, MenuHelper.SalasJuntas[0].Sala_Id);
            }

            dateFormat.DateFormat = "yyyy-MM-dd";
            NSDate newFormatDate = dateFormat.Parse(FechaReservacion);
            this.FormatoDiaSeleccionado(newFormatDate);
            dateFormat.DateFormat = "dd/MM/yyyy";
            dateFormat.ToString(NSDate.Now);
            this.btnSeleccionFecha.SetTitle(dateFormat.ToString(NSDate.Now), UIControlState.Normal);
            this.PrepareForSegue(this.segueSalasJuntas, null);
        }
    }

    partial class ReservarSalaJuntasViewTableController : EventosReservaciones
    {
        public async void ReservacionConfirmada(SalaJuntasReservacionModel ReservacionesConcat)
        {
            await Task.Delay(100);
            this.Reservacion = ReservacionesConcat;
            this.PerformSegue("DetalleReservacion", null);
        }

        public void ReservacionCancelada(SalaJuntasReservacionModel Reservciones)
        {
            this.Reservacion = Reservciones;
        }
    }


    partial class ReservarSalaJuntasViewTableController : ConfirmacionRealizada
    {
        public void ConfirmacionRealizada()
        {
            this.NavigationController.PopViewController(true);
        }
    }


    partial class ReservarSalaJuntasViewTableController : EventosSalaJuntas
    {
        public void SalaSeleccionada(SalaJuntasModel SalaSeleccionada)
        {
            this.SalaActual = SalaSeleccionada;
            this.CreditosSeleccionados(this.HoraInicio, this.HoraFin);
            this.Reservacion = new SalaJuntasReservacionModel(SalaActual.Sala_Id, HoraInicio, HoraFin, this.fechaSeleccionada, "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, this.HorasReservadas, this.CreditosAcumulados);

        }
    }

    partial class ReservarSalaJuntasViewTableController : EventosHoraFinSeleccionada
    {
        public void HoraFinSeleccionada(string HoraSeleccionada, string HoraFin)
        {
            this.HoraFin = HoraFin;
            this.CreditosSeleccionados(this.HoraInicio, this.HoraFin);
            this.PrepareForSegue(this.segueSalasJuntas, null);
            this.btnHoraFin.SetTitle(HoraSeleccionada, UIControlState.Normal);
            this.HoraFinFormat = HoraSeleccionada;
        }
    }


    partial class ReservarSalaJuntasViewTableController : EventosHoraInicioSeleccionada
    {
        public void HoraInicioSeleccionada(string HoraSeleccionada, string HoraInicio)
        {
            this.HoraInicio = HoraInicio;
            this.CreditosSeleccionados(this.HoraInicio, this.HoraFin);
            var lstHora = HoraSeleccionada.Split(':');
            var hora = int.Parse(lstHora[0]);
            var min = int.Parse(lstHora[1].Remove(2, 3));

            var HoraCompletaFin = HoraInicio.Split(':');
            var HorasFin = int.Parse(HoraCompletaFin[0]);
            var MinutosFin = HoraCompletaFin[1];
            if (HoraCompletaFin[1] == "00")
            {
                MinutosFin = "30";
            }
            if (HoraCompletaFin[1] == "30")
            {
                MinutosFin = "00";
                HorasFin = HorasFin + 1;
            }
            var newHoraFin = HorasFin.ToString();
            if (newHoraFin.Length == 1)
            {
                newHoraFin = newHoraFin.Insert(0, "0");
            }

            var HorarioInicio = HoraInicio.Split(':');

            var HorarioInicioHora = int.Parse(HorarioInicio[0]);
            var HorarioInicioMinutos = HorarioInicio[1];

            var HorarioFin = this.HoraFin.Split(':');
            var HorarioFinHora = int.Parse(HorarioFin[0]);
            var HorarioFinMinutos = HorarioFin[1];

            string horarioFin = this.HoraFinFormat;
            string minutosstr = min.ToString();

            this.HoraFin = newHoraFin + ":" + MinutosFin;

            if (horarioFin == "" || (HorarioInicioHora >= HorarioFinHora))
            {
                horarioFin = this.Formato24(this.HoraFin);
            }

            MinDateHoraFin = this.HoraFinMinima(this.fechaSeleccionada, this.HoraInicio);
            MinDateHoraInicio = this.HoraFinMinima(this.fechaSeleccionada, HoraInicio);

            this.PrepareForSegue(this.segueSalasJuntas, null);
            this.btnHoraInicio.SetTitle(HoraSeleccionada, UIControlState.Normal);
            this.btnHoraFin.SetTitle(horarioFin, UIControlState.Normal);
        }
    }


}