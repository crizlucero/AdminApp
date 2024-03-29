
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

        private void PintarMinutos()
        {
            int date = DateTime.Now.Hour - 1;
            if (date >= 23)
            {
                view2324_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 0)
            {
                vw2223_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 1)
            {
                vw2122_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 2)
            {
                vw2021_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 3)
            {
                vw1920_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 4)
            {
                vw1819_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 5)
            {
                vw1718_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 6)
            {
                vw1617_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 7)
            {
                vw1516_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 8)
            {
                vw1415_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 9)
            {
                vw1314_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 10)
            {
                vw1213_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 11)
            {
                vw1112_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 12)
            {
                vw1011_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 13)
            {
                vw0910_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 14)
            {
                vw0809_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 15)
            {
                vw0708_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 16)
            {
                vw0607_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 17)
            {
                vw0506_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 18)
            {
                vw0405_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 19)
            {
                vw0304_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 20)
            {
                vw0203_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 21)
            {
                vw0102_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 22)
            {
                vw2401_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
          /* if (date >= 24)
            {
                vw2401_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }*/

        }

        /*private void ValidateHour()
        {
            int date = DateTime.Now.Hour - 1;
            int minutes = DateTime.Now.Minute;
            if (date >= 23)
            {
                CGPoint recta = new CGPoint(view2324.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                view2324.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 23)
                {
                    view2324_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
 
            }
            if (date >= 0)
            {
                CGPoint recta = new CGPoint(vw2223.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw2223.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 0)
                {
                    vw2223_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 1)
            {
                CGPoint recta = new CGPoint(vw2122.Frame.X,0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw2122.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 1)
                {
                    vw2122_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 2)
            {
                CGPoint recta = new CGPoint(vw2021.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw2021.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 2)
                {
                    vw2021_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 3)
            {
                CGPoint recta = new CGPoint(vw1920.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1920.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 3)
                {
                    vw1920_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }

            }
            if (date >= 4)
            {
                CGPoint recta = new CGPoint(vw1819.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1819.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 4)
                {
                    vw1819_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 5)
            {
                CGPoint recta = new CGPoint(vw1718.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1718.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 5)
                {
                    vw1718_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 6)
            {
                CGPoint recta = new CGPoint(vw1617.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1617.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 6)
                {
                    vw1617_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 7)
            {
                CGPoint recta = new CGPoint(vw1516.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1516.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 7)
                {
                    vw1516_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 8)
            {
                CGPoint recta = new CGPoint(vw1415.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1415.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 8)
                {
                    vw1415_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 9)
            {
                CGPoint recta = new CGPoint(vw1314.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1314.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 9)
                {
                    vw1314_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 10)
            {
                CGPoint recta = new CGPoint(vw1213.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1213.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 10)
                {
                    vw1213_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 11)
            {
                CGPoint recta = new CGPoint(vw1112.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1112.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 11)
                {
                    vw1112_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 12)
            {
                CGPoint recta = new CGPoint(vw1011.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1011.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 12)
                {
                    vw1011_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 13)
            {
                CGPoint recta = new CGPoint(vw0910.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0910.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 13)
                {
                    vw0910_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 14)
            {
                CGPoint recta = new CGPoint(vw0809.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0809.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 14)
                {
                    vw0809_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 15)
            {
                CGPoint recta = new CGPoint(vw0708.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0708.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 15)
                {
                    vw0708_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 16)
            {
                CGPoint recta = new CGPoint(vw0607.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0607.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 16)
                {
                    vw0607_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }

            }
            if (date >= 17)
            {
                CGPoint recta = new CGPoint(vw0506.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0506.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 17)
                {
                    vw0506_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 18)
            {
                CGPoint recta = new CGPoint(vw0405.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0405.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 18)
                {
                    vw0405_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 19)
            {
                CGPoint recta = new CGPoint(vw0304.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0304.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 19)
                {
                    vw0304_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }


            if (date >= 20)
            {
                CGPoint recta = new CGPoint(vw0203.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0203.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 20)
                {
                    vw0203_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 21)
            {
                CGPoint recta = new CGPoint(vw0102.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0102.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 21)
                {
                    vw0102_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 22)
            {
                CGPoint recta = new CGPoint(vw2401.Frame.X, 0);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw2401.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                this.PintarMinutos();
                if (minutes < 30 && date == 22)
                {
                    vw2401_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                }
            }
            if (date >= 24)
            {
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }

        }*/



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
            /*UITapGestureRecognizer tapGesture2324 = new UITapGestureRecognizer(vw2324Touch);
            UITapGestureRecognizer tapGesture2324_2 = new UITapGestureRecognizer(vw2324Touch_2);

            UITapGestureRecognizer tapGesture2223 = new UITapGestureRecognizer(vw2223Touch);
            UITapGestureRecognizer tapGesture2223_2 = new UITapGestureRecognizer(vw2223Touch_2);

            UITapGestureRecognizer tapGesture2122 = new UITapGestureRecognizer(vw2122Touch);
            UITapGestureRecognizer tapGesture2122_2 = new UITapGestureRecognizer(vw2122Touch_2);

            UITapGestureRecognizer tapGesture2021 = new UITapGestureRecognizer(vw2021Touch);
            UITapGestureRecognizer tapGesture2021_2 = new UITapGestureRecognizer(vw2021Touch_2);

            UITapGestureRecognizer tapGesture1920 = new UITapGestureRecognizer(vw1920Touch);
            UITapGestureRecognizer tapGesture1920_2 = new UITapGestureRecognizer(vw1920Touch_2);

            UITapGestureRecognizer tapGesture1819 = new UITapGestureRecognizer(vw1819Touch);
            UITapGestureRecognizer tapGesture1819_2 = new UITapGestureRecognizer(vw1819Touch_2);

            UITapGestureRecognizer tapGesture1718 = new UITapGestureRecognizer(vw1718Touch);
            UITapGestureRecognizer tapGesture1718_2 = new UITapGestureRecognizer(vw1718Touch_2);

            UITapGestureRecognizer tapGesture1617 = new UITapGestureRecognizer(vw1617Touch);
            UITapGestureRecognizer tapGesture1617_2 = new UITapGestureRecognizer(vw1617Touch_2);

            UITapGestureRecognizer tapGesture1516 = new UITapGestureRecognizer(vw1516Touch);
            UITapGestureRecognizer tapGesture1516_2 = new UITapGestureRecognizer(vw1516Touch_2);

            UITapGestureRecognizer tapGesture1415 = new UITapGestureRecognizer(vw1415Touch);
            UITapGestureRecognizer tapGesture1415_2 = new UITapGestureRecognizer(vw1415Touch_2);

            UITapGestureRecognizer tapGesture1314 = new UITapGestureRecognizer(vw1314Touch);
            UITapGestureRecognizer tapGesture1314_2 = new UITapGestureRecognizer(vw1314Touch_2);

            UITapGestureRecognizer tapGesture1213 = new UITapGestureRecognizer(vw1213Touch);
            UITapGestureRecognizer tapGesture1213_2 = new UITapGestureRecognizer(vw1213Touch_2);

            UITapGestureRecognizer tapGesture1112 = new UITapGestureRecognizer(vw1112Touch);
            UITapGestureRecognizer tapGesture1112_2 = new UITapGestureRecognizer(vw1112Touch_2);

            UITapGestureRecognizer tapGesture1011 = new UITapGestureRecognizer(vw1011Touch);
            UITapGestureRecognizer tapGesture1011_2 = new UITapGestureRecognizer(vw1011Touch_2);

            UITapGestureRecognizer tapGesture0910 = new UITapGestureRecognizer(vw0910Touch);
            UITapGestureRecognizer tapGesture0910_2 = new UITapGestureRecognizer(vw0910Touch_2);

            UITapGestureRecognizer tapGesture0809 = new UITapGestureRecognizer(vw0809Touch);
            UITapGestureRecognizer tapGesture0809_2 = new UITapGestureRecognizer(vw0809Touch_2);

            UITapGestureRecognizer tapGesture0708 = new UITapGestureRecognizer(vw0708Touch);
            UITapGestureRecognizer tapGesture0708_2 = new UITapGestureRecognizer(vw0708Touch_2);

            UITapGestureRecognizer tapGesture0607 = new UITapGestureRecognizer(vw0607Touch);
            UITapGestureRecognizer tapGesture0607_2 = new UITapGestureRecognizer(vw0607Touch_2);

            UITapGestureRecognizer tapGesture0506 = new UITapGestureRecognizer(vw0506Touch);
            UITapGestureRecognizer tapGesture0506_2 = new UITapGestureRecognizer(vw0506Touch_2);

            UITapGestureRecognizer tapGesture0405 = new UITapGestureRecognizer(vw0405Touch);
            UITapGestureRecognizer tapGesture0405_2 = new UITapGestureRecognizer(vw0405Touch_2);

            UITapGestureRecognizer tapGesture0304 = new UITapGestureRecognizer(vw0304Touch);
            UITapGestureRecognizer tapGesture0304_2 = new UITapGestureRecognizer(vw0304Touch_2);

            UITapGestureRecognizer tapGesture0203 = new UITapGestureRecognizer(vw0203Touch);
            UITapGestureRecognizer tapGesture0203_2 = new UITapGestureRecognizer(vw0203Touch_2);

            UITapGestureRecognizer tapGesture0102 = new UITapGestureRecognizer(vw0102Touch);
            UITapGestureRecognizer tapGesture0102_2 = new UITapGestureRecognizer(vw0102Touch_2);

            UITapGestureRecognizer tapGesture2401 = new UITapGestureRecognizer(vw0124Touch);
            UITapGestureRecognizer tapGesture2401_2 = new UITapGestureRecognizer(vw0124Touch_2);

            this.view2324.UserInteractionEnabled = true;
            this.view2324.AddGestureRecognizer(tapGesture2324);

            this.view2324_2.UserInteractionEnabled = true;
            this.view2324_2.AddGestureRecognizer(tapGesture2324_2);

            this.vw0102.UserInteractionEnabled = true;
            this.vw0102.AddGestureRecognizer(tapGesture0102);

            this.vw0102_2.UserInteractionEnabled = true;
            this.vw0102_2.AddGestureRecognizer(tapGesture0102_2);

            this.vw0203.UserInteractionEnabled = true;
            this.vw0203.AddGestureRecognizer(tapGesture0203);

            this.vw0203_2.UserInteractionEnabled = true;
            this.vw0203_2.AddGestureRecognizer(tapGesture0203_2);

            this.vw0304.UserInteractionEnabled = true;
            this.vw0304.AddGestureRecognizer(tapGesture0304);

            this.vw0304_2.UserInteractionEnabled = true;
            this.vw0304_2.AddGestureRecognizer(tapGesture0304_2);

            this.vw0405.UserInteractionEnabled = true;
            this.vw0405.AddGestureRecognizer(tapGesture0405);

            this.vw0405_2.UserInteractionEnabled = true;
            this.vw0405_2.AddGestureRecognizer(tapGesture0405_2);

            this.vw0506.UserInteractionEnabled = true;
            this.vw0506.AddGestureRecognizer(tapGesture0506);

            this.vw0506_2.UserInteractionEnabled = true;
            this.vw0506_2.AddGestureRecognizer(tapGesture0506_2);

            this.vw0607.UserInteractionEnabled = true;
            this.vw0607.AddGestureRecognizer(tapGesture0607);

            this.vw0607_2.UserInteractionEnabled = true;
            this.vw0607_2.AddGestureRecognizer(tapGesture0607_2);

            this.vw0708.UserInteractionEnabled = true;
            this.vw0708.AddGestureRecognizer(tapGesture0708);

            this.vw0708_2.UserInteractionEnabled = true;
            this.vw0708_2.AddGestureRecognizer(tapGesture0708_2);

            this.vw0809.UserInteractionEnabled = true;
            this.vw0809.AddGestureRecognizer(tapGesture0809);

            this.vw0809_2.UserInteractionEnabled = true;
            this.vw0809_2.AddGestureRecognizer(tapGesture0809_2);

            this.vw0910.UserInteractionEnabled = true;
            this.vw0910.AddGestureRecognizer(tapGesture0910);

            this.vw0910_2.UserInteractionEnabled = true;
            this.vw0910_2.AddGestureRecognizer(tapGesture0910_2);

            this.vw1011.UserInteractionEnabled = true;
            this.vw1011.AddGestureRecognizer(tapGesture1011);

            this.vw1011_2.UserInteractionEnabled = true;
            this.vw1011_2.AddGestureRecognizer(tapGesture1011_2);

            this.vw1112.UserInteractionEnabled = true;
            this.vw1112.AddGestureRecognizer(tapGesture1112);

            this.vw1112_2.UserInteractionEnabled = true;
            this.vw1112_2.AddGestureRecognizer(tapGesture1112_2);

            this.vw1213.UserInteractionEnabled = true;
            this.vw1213.AddGestureRecognizer(tapGesture1213);

            this.vw1213_2.UserInteractionEnabled = true;
            this.vw1213_2.AddGestureRecognizer(tapGesture1213_2);

            this.vw1314.UserInteractionEnabled = true;
            this.vw1314.AddGestureRecognizer(tapGesture1314);

            this.vw1314_2.UserInteractionEnabled = true;
            this.vw1314_2.AddGestureRecognizer(tapGesture1314_2);

            this.vw1415.UserInteractionEnabled = true;
            this.vw1415.AddGestureRecognizer(tapGesture1415);

            this.vw1415_2.UserInteractionEnabled = true;
            this.vw1415_2.AddGestureRecognizer(tapGesture1415_2);

            this.vw1516.UserInteractionEnabled = true;
            this.vw1516.AddGestureRecognizer(tapGesture1516);

            this.vw1516_2.UserInteractionEnabled = true;
            this.vw1516_2.AddGestureRecognizer(tapGesture1516_2);

            this.vw1617.UserInteractionEnabled = true;
            this.vw1617.AddGestureRecognizer(tapGesture1617);

            this.vw1617_2.UserInteractionEnabled = true;
            this.vw1617_2.AddGestureRecognizer(tapGesture1617_2);

            this.vw1718.UserInteractionEnabled = true;
            this.vw1718.AddGestureRecognizer(tapGesture1718);

            this.vw1718_2.UserInteractionEnabled = true;
            this.vw1718_2.AddGestureRecognizer(tapGesture1718_2);

            this.vw1819.UserInteractionEnabled = true;
            this.vw1819.AddGestureRecognizer(tapGesture1819);

            this.vw1819_2.UserInteractionEnabled = true;
            this.vw1819_2.AddGestureRecognizer(tapGesture1819_2);

            this.vw1920.UserInteractionEnabled = true;
            this.vw1920.AddGestureRecognizer(tapGesture1920);

            this.vw1920_2.UserInteractionEnabled = true;
            this.vw1920_2.AddGestureRecognizer(tapGesture1920_2);

            this.vw2021.UserInteractionEnabled = true;
            this.vw2021.AddGestureRecognizer(tapGesture2021);

            this.vw2021_2.UserInteractionEnabled = true;
            this.vw2021_2.AddGestureRecognizer(tapGesture2021_2);

            this.vw2122.UserInteractionEnabled = true;
            this.vw2122.AddGestureRecognizer(tapGesture2122);

            this.vw2122_2.UserInteractionEnabled = true;
            this.vw2122_2.AddGestureRecognizer(tapGesture2122_2);

            this.vw2223.UserInteractionEnabled = true;
            this.vw2223.AddGestureRecognizer(tapGesture2223);

            this.vw2223_2.UserInteractionEnabled = true;
            this.vw2223_2.AddGestureRecognizer(tapGesture2223_2);

            this.vw2401.UserInteractionEnabled = true;
            this.vw2401.AddGestureRecognizer(tapGesture2401);

            this.vw2401_2.UserInteractionEnabled = true;
            this.vw2401_2.AddGestureRecognizer(tapGesture2401_2);*/


            ListaViews ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0102;
            ObjLista.HoraInicio = "22:00";
            VistasHorarios.Add(ObjLista);   //0
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0102_2;
            ObjLista.HoraInicio = "22:30";
            VistasHorarios.Add(ObjLista); //1
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0203;
            ObjLista.HoraInicio = "21:00";
            VistasHorarios.Add(ObjLista);   //2
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0203_2;
            ObjLista.HoraInicio = "21:30";
            VistasHorarios.Add(ObjLista); //3
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0304;
            ObjLista.HoraInicio = "20:00";
            VistasHorarios.Add(ObjLista);   //4
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0304_2;
            ObjLista.HoraInicio = "20:30";
            VistasHorarios.Add(ObjLista); //5
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0405;
            ObjLista.HoraInicio = "19:00";
            VistasHorarios.Add(ObjLista);   //6
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0405_2;
            ObjLista.HoraInicio = "19:30";
            VistasHorarios.Add(ObjLista); //7
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0506;
            ObjLista.HoraInicio = "18:00";
            VistasHorarios.Add(ObjLista);   //8
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0506_2;
            ObjLista.HoraInicio = "18:30";
            VistasHorarios.Add(ObjLista); //9
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0607;
            ObjLista.HoraInicio = "17:00";
            VistasHorarios.Add(ObjLista);   //10
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0607_2;
            ObjLista.HoraInicio = "17:30";
            VistasHorarios.Add(ObjLista); //11
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0708;
            ObjLista.HoraInicio = "16:00";
            VistasHorarios.Add(ObjLista);   //12
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0708_2;
            ObjLista.HoraInicio = "16:30";
            VistasHorarios.Add(ObjLista); //13
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0809;
            ObjLista.HoraInicio = "15:00";
            VistasHorarios.Add(ObjLista);   //14
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0809_2;
            ObjLista.HoraInicio = "15:30";
            VistasHorarios.Add(ObjLista); //15
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0910;
            ObjLista.HoraInicio = "14:00";
            VistasHorarios.Add(ObjLista);   //16
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw0910_2;
            ObjLista.HoraInicio = "14:30";
            VistasHorarios.Add(ObjLista); //17
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1011;
            ObjLista.HoraInicio = "13:00";
            VistasHorarios.Add(ObjLista);   //18
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1011_2;
            ObjLista.HoraInicio = "13:30";
            VistasHorarios.Add(ObjLista); //19
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1112;
            ObjLista.HoraInicio = "12:00";
            VistasHorarios.Add(ObjLista);   //20
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1112_2;
            ObjLista.HoraInicio = "12:30";
            VistasHorarios.Add(ObjLista); //21
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1213;
            ObjLista.HoraInicio = "11:00";
            VistasHorarios.Add(ObjLista);   //22
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1213_2;
            ObjLista.HoraInicio = "11:30";
            VistasHorarios.Add(ObjLista); //23
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1314;
            ObjLista.HoraInicio = "10:00";
            VistasHorarios.Add(ObjLista);   //24
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1314_2;
            ObjLista.HoraInicio = "10:30";
            VistasHorarios.Add(ObjLista); //25
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1415;
            ObjLista.HoraInicio = "09:00";
            VistasHorarios.Add(ObjLista);   //26
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1415_2;
            ObjLista.HoraInicio = "09:30";
            VistasHorarios.Add(ObjLista); //27
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1516;
            ObjLista.HoraInicio = "08:00";
            VistasHorarios.Add(ObjLista);   //28
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1516_2;
            ObjLista.HoraInicio = "08:30";
            VistasHorarios.Add(ObjLista); //29
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1617;
            ObjLista.HoraInicio = "07:00";
            VistasHorarios.Add(ObjLista);   //30
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1617_2;
            ObjLista.HoraInicio = "07:30";
            VistasHorarios.Add(ObjLista); //31
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1718;
            ObjLista.HoraInicio = "06:00";
            VistasHorarios.Add(ObjLista);   //32
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1718_2;
            ObjLista.HoraInicio = "06:30";
            VistasHorarios.Add(ObjLista); //33
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1819;
            ObjLista.HoraInicio = "05:00";
            VistasHorarios.Add(ObjLista);   //34
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1819_2;
            ObjLista.HoraInicio = "05:30";
            VistasHorarios.Add(ObjLista); //35
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1920;
            ObjLista.HoraInicio = "04:00";
            VistasHorarios.Add(ObjLista);   //36
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw1920_2;
            ObjLista.HoraInicio = "04:30";
            VistasHorarios.Add(ObjLista); //37
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw2021;
            ObjLista.HoraInicio= "03:00";
            VistasHorarios.Add(ObjLista);   //38
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw2021_2;
            ObjLista.HoraInicio = "03:30";
            VistasHorarios.Add(ObjLista); //39
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw2122;
            ObjLista.HoraInicio = "02:00";
            VistasHorarios.Add(ObjLista);   //40
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw2122_2;
            ObjLista.HoraInicio = "02:30";
            VistasHorarios.Add(ObjLista); //41
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw2223;
            ObjLista.HoraInicio = "01:00";
            VistasHorarios.Add(ObjLista);   //42
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw2223_2;
            ObjLista.HoraInicio = "01:30";
            VistasHorarios.Add(ObjLista); //43
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.view2324;
            ObjLista.HoraInicio = "24:00";
            VistasHorarios.Add(ObjLista); //44
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.view2324_2;
            ObjLista.HoraInicio = "24:30";
            VistasHorarios.Add(ObjLista);//45
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw2401;
            ObjLista.HoraInicio = "23:00";
            VistasHorarios.Add(ObjLista);    //46
            ObjLista = new ListaViews();
            ObjLista.Horarios = this.vw2401_2;
            ObjLista.HoraInicio = "23:30";
            VistasHorarios.Add(ObjLista);  //47
        }


        //Touch Views
       /* private void vw2324Touch(UITapGestureRecognizer Recognizer)
        {
            if ( VistasHorarios[44].Horarios.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2324 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    VistasHorarios[44].Horarios.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2324 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "24:00", "24:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    VistasHorarios[44].Horarios.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2324 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "24:30");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        CreditosAcumulados = CreditosAcumulados - 1;
                    }
                }
                this.PrepareForSegue(this.segueSalasJuntas, null);
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "HoraInicio")
            {
                var HoraInicioView = (HoraInicioView)segue.DestinationViewController;
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
            //this.GetHorasNoDisponibles(MenuHelper.SalasJuntas[0].Sala_Id);
            if (FechaReservacion == DateTime.Now.ToString("yyyy-MM-dd"))
            {
                //this.ValidateHour();
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

            if(HorarioInicioHora >= HorarioFinHora)
            {
                if( (HorarioFinMinutos == "00" && HorarioInicioMinutos == "00") || HorarioInicioMinutos == "30")
                {
                    this.HoraFin = newHoraFin + ":" + MinutosFin;
                    string minutosstr = min.ToString();

                    if (min >= 30)
                    {
                        minutosstr = "00";
                        hora = hora + 1;
                    }
                    if (min <= 30)
                    {
                        minutosstr = "30";
                    }

                    var Meridiano = HoraSeleccionada.Substring(6);
                    var newHorarioFin = hora.ToString();
                    if (hora.ToString().Length == 1)
                    {
                        newHorarioFin = newHorarioFin.Insert(0, "0");
                    }

                    horarioFin = newHorarioFin + ":" + minutosstr + " " + Meridiano;
                }
            }

            MinDateHoraFin = this.HoraFinMinima(this.fechaSeleccionada, this.HoraInicio);
            MinDateHoraInicio = this.HoraFinMinima(this.fechaSeleccionada, HoraInicio);

            this.PrepareForSegue(this.segueSalasJuntas, null);
            this.btnHoraInicio.SetTitle(HoraSeleccionada, UIControlState.Normal);
            this.btnHoraFin.SetTitle(horarioFin, UIControlState.Normal);
        }
    }


}