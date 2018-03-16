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




    public partial class ReservarSalaJuntasViewTableController : UITableViewController
    {

        float CreditosAcumulados = 0;

        public string SucursalId;
        NSDateFormatter dateFormat = new NSDateFormatter();
        bool FlagView2324 = false, FlagView2324_2 = false, FlagView2223 = false, FlagView2223_2 = false, FlagView2122 = false, FlagView2122_2 = false, FlagView2021 = false, FlagView2021_2 = false, FlagView1920 = false, FlagView1920_2 = false, FlagView1819 = false, FlagView1819_2 = false, FlagView1718 = false, FlagView1718_2 = false, FlagView1617 = false,


        FlagView1617_2 = false, Flag1516 = false, Flag1516_2 = false, Flag1415 = false, Flag1415_2 = false, Flag1314 = false, Flag1314_2 = false, Flag1213 = false, Flag1213_2 = false, Flag1112 = false, Flag1112_2 = false, Flag1011 = false, Flag1011_2 = false, Flag0910 = false, Flag0910_2 = false, Flag0809 = false, Flag0809_2 = false, Flag0708 = false, Flag0708_2 = false, Flag0607 = false, Flag0607_2 = false, Flag0506 = false, Flag0506_2 = false, Flag0405 = false, Flag0405_2 = false, Flag0304 = false, Flag0304_2 = false, Flag0203 = false, Flag0203_2 = false, Flag0102 = false, Flag0102_2 = false, Flag0124 = false, Flag0124_2 = false;

        List<SalaJuntasReservacionModel> HorasNoDisponibles = new List<SalaJuntasReservacionModel>();
        List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
        SalaJuntasModel SalaActual = new SalaJuntasModel();
        List<UIView> VistasHorarios = new List<UIView>();

        List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();
        List<SalaJuntasReservacionModel> ReservacionesConcat = new List<SalaJuntasReservacionModel>();

        float HorasReservadas = 0;

        string DiaSeleccionado;

        string SalaId = "";

        int Nivel = 7;

        float withImage;

        public ReservarSalaJuntasViewTableController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            nfloat aux = this.vwSalasJuntas.Frame.Width;
            this.lblCreditosDisponibles.Text = new SalasJuntasController().GetCreditosDisponibles(KeyChainHelper.GetKey("Usuario_Id")).ToString();
            this.lblCreditosPorUsar.Text = "0";
            withImage = float.Parse(UIScreen.MainScreen.Bounds.Width.ToString());
            base.ViewDidLoad();
            this.GenerateRecornizes();
            this.LimpiarInfo();
            this.GetSalas(this.Nivel);
            this.btnNivel.SetTitle("NIVEL 7", UIControlState.Normal);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        private void UpdateInfo()
        {
            this.scvSalasJuntas.Frame = new CGRect(this.scvSalasJuntas.Frame.X, this.scvSalasJuntas.Frame.Y, withImage, this.scvSalasJuntas.Frame.Height);
            if (this.SalasJuntas.Count > 0)
            {
                this.SalaActual = this.SalasJuntas[0];

                this.GetHorasNoDisponibles(SalaActual.Sala_Id);
                this.lblPiso.Text = "NIVEL " + this.SalaActual.Sala_Nivel;
                this.lblNombre.Text = this.SalaActual.Sala_Descripcion;
                this.lblCapacidad.Text = this.SalaActual.Sala_Capacidad + " PERSONAS";
            }

            nfloat WidthView = 0;

            for (int indice = 0; indice < this.SalasJuntas.Count; indice++)
            {
                WidthView = WidthView + withImage;
            }
            this.pcSucursales.Pages = this.SalasJuntas.Count;
            CGRect newFrame = new CGRect(this.vwSalasJuntas.Frame.X, this.vwSalasJuntas.Frame.Y, WidthView, this.vwSalasJuntas.Frame.Height);

            this.vwSalasJuntas.Frame = newFrame;
            nfloat XImageView = 0;
            for (int indice = 0; indice < this.SalasJuntas.Count ; indice++)
            {
                UIImageView ImagenSalaJuntas = new UIImageView();
                ImagenSalaJuntas.Frame = new CGRect(XImageView, this.imgSalasJuntas.Frame.Y, withImage, this.imgSalasJuntas.Frame.Height);
                if (this.SalasJuntas[indice].Sala_Capacidad == "6")
                {
                    ImagenSalaJuntas.Image = UIImage.FromBundle("Sala6");
                }
                else if (this.SalasJuntas[indice].Sala_Capacidad == "10")
                {
                    ImagenSalaJuntas.Image = UIImage.FromBundle("Sala10");
                }

                this.vwSalasJuntas.Add(ImagenSalaJuntas);
                XImageView += withImage;

            }
            this.scvSalasJuntas.ContentSize = vwSalasJuntas.Frame.Size;
            this.scvSalasJuntas.Scrolled += (sender, e) =>
            {
                SalaId = SalaActual.Sala_Id;
                this.pcSucursales.CurrentPage = (nint)(scvSalasJuntas.ContentOffset.X / scvSalasJuntas.Frame.Width);
                this.SalaActual = this.SalasJuntas[int.Parse(this.pcSucursales.CurrentPage.ToString())];
                this.lblPiso.Text = "NIVEL " + SalaActual.Sala_Nivel;
                this.lblNombre.Text = SalaActual.Sala_Descripcion;
                this.lblCapacidad.Text = SalaActual.Sala_Capacidad + " PERSONAS";

                if (InternetConectionHelper.VerificarConexion())
                {
                    this.GetHorasNoDisponibles(this.SalaActual.Sala_Id);
                }
                this.ValidateHour();

            };

            CGRect FrameHorarios = new CGRect(this.vwHorarios.Frame.X, this.vwHorarios.Frame.Y, this.vwHorarios.Frame.Width + 50, this.vwHorarios.Frame.Height);
            this.scvScrollHorarios.ContentSize = FrameHorarios.Size;
            StyleHelper.Style(this.vwBotonFecha.Layer);
            StyleHelper.Style(this.vwInfoReservacion.Layer);
            StyleHelper.Style(this.vwNivel.Layer);
            this.ValidateHour();
        }

        private void PintarMinutos()
        {
            int date = DateTime.Now.Hour - 1;
            if (date >= 0)
            {
                view2324_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 1)
            {
                vw2223_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 2)
            {
                vw2122_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 3)
            {
                vw2021_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 4)
            {
                vw1920_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 5)
            {
                vw1819_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 6)
            {
                vw1718_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 7)
            {
                vw1617_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 8)
            {
                vw1516_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 9)
            {
                vw1415_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 10)
            {
                vw1314_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 11)
            {
                vw1213_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 12)
            {
                vw1112_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 13)
            {
                vw1011_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 14)
            {
                vw0910_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 15)
            {
                vw0809_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 16)
            {
                vw0708_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 17)
            {
                vw0607_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 18)
            {
                vw0506_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 19)
            {
                vw0405_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 20)
            {
                vw0304_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 21)
            {
                vw0203_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 22)
            {
                vw0102_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 23)
            {
                vw2401_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
          /* if (date >= 24)
            {
                vw2401_2.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }*/

        }

        private void ValidateHour()
        {
            int date = DateTime.Now.Hour - 1;
            int minutes = DateTime.Now.Minute;

            var BanderaMin = false;
            var BanderaHoras = false;

            if (date >= 0)
            {
                CGPoint recta = new CGPoint(view2324.Frame.X, view2324.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                view2324.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
                BanderaHoras = true;

            }
            if (date >= 1)
            {
                CGPoint recta = new CGPoint(vw2223.Frame.X, vw2223.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw2223.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 2)
            {
                CGPoint recta = new CGPoint(vw2122.Frame.X, vw2122.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw2122.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 3)
            {
                CGPoint recta = new CGPoint(vw2021.Frame.X, vw2021.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw2021.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 4)
            {
                CGPoint recta = new CGPoint(vw1920.Frame.X, vw1920.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1920.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 5)
            {
                CGPoint recta = new CGPoint(vw1819.Frame.X, vw1819.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1819.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 6)
            {
                CGPoint recta = new CGPoint(vw1718.Frame.X, vw1718.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1718.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                //vw1819.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 7)
            {
                CGPoint recta = new CGPoint(vw1617.Frame.X, vw1617.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1617.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                //vw1718.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date > 8)
            {
                CGPoint recta = new CGPoint(vw1516.Frame.X, vw1516.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1516.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                //vw1617.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 9)
            {
                CGPoint recta = new CGPoint(vw1415.Frame.X, vw1415.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1415.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 10)
            {
                CGPoint recta = new CGPoint(vw1314.Frame.X, vw1314.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1314.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 11)
            {
                CGPoint recta = new CGPoint(vw1213.Frame.X, vw1213.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1213.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 12)
            {
                CGPoint recta = new CGPoint(vw1112.Frame.X, vw1112.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1112.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 13)
            {
                CGPoint recta = new CGPoint(vw1011.Frame.X, vw1011.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw1011.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 14)
            {
                CGPoint recta = new CGPoint(vw0910.Frame.X, vw0910.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0910.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 15)
            {
                CGPoint recta = new CGPoint(vw0809.Frame.X, vw0809.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0809.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 16)
            {
                CGPoint recta = new CGPoint(vw0708.Frame.X, vw0708.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0708.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 17)
            {
                CGPoint recta = new CGPoint(vw0607.Frame.X, vw0607.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0607.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 18)
            {
                CGPoint recta = new CGPoint(vw0506.Frame.X, vw0506.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0506.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 19)
            {
                CGPoint recta = new CGPoint(vw0405.Frame.X, vw0405.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0405.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 20)
            {
                CGPoint recta = new CGPoint(vw0304.Frame.X, vw0304.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0304.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }


            if (date >= 21)
            {
                CGPoint recta = new CGPoint(vw0203.Frame.X, vw0203.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0203.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 22)
            {
                CGPoint recta = new CGPoint(vw0102.Frame.X, vw0102.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw0102.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            if (date >= 23)
            {
                CGPoint recta = new CGPoint(vw2401.Frame.X, vw2401.Frame.Y);
                this.scvScrollHorarios.SetContentOffset(recta, true);
                vw2401.BackgroundColor = UIColor.Clear.FromHex(0x404040);
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }
            /*if (date >= 24)
            {
                BanderaHoras = true;
                if (minutes >= 30 || (BanderaMin == false && BanderaHoras == false))
                {
                    this.PintarMinutos();
                    BanderaMin = true;
                }
            }*/

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


        private void GetHorasNoDisponibles(string SalaId)
        {
            for (int indice = 0; indice < 48; indice++)
            {
                this.VistasHorarios[indice].BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
            }
            FlagView2324 = false; FlagView2324_2 = false; FlagView2223 = false; FlagView2223_2 = false; FlagView2122_2 = false; FlagView2122 = false; FlagView2021 = false; FlagView2021_2 = false; FlagView1920 = false; FlagView1920_2 = false; FlagView1819 = false; FlagView1819_2 = false; FlagView1718 = false; FlagView1718_2 = false; FlagView1617 = false; FlagView1617_2 = false; Flag1516 = false; Flag1516_2 = false; Flag1415 = false; Flag1415_2 = false; Flag1314 = false; Flag1314_2 = false; Flag1213 = false; Flag1213_2 = false; Flag1112 = false; Flag1112_2 = false; Flag1011 = false; Flag1011_2 = false; Flag0910 = false; Flag0910_2 = false; Flag0809 = false; Flag0809_2 = false; Flag0708 = false; Flag0708_2 = false; Flag0607 = false; Flag0607_2 = false; Flag0506 = false; Flag0506_2 = false; Flag0405 = false; Flag0405_2 = false; Flag0304 = false; Flag0304_2 = false; Flag0203 = false; Flag0203_2 = false; Flag0102 = false; Flag0102_2 = false; Flag0124 = false; Flag0124_2 = false;


            for (int indice = 0; indice < HorasNoDisponibles.Count; indice++)
            {
                var HoraInicio = HorasNoDisponibles[indice].Sala_Hora_Inicio;
                if (HoraInicio.Substring(3,1) == "3")
                {
                    this.VistasHorarios[int.Parse(HoraInicio.Replace(":30:00.0000000", "")) - 1].BackgroundColor = UIColor.Clear.FromHex(0x404040);
                }
                else
                {
                    this.VistasHorarios[int.Parse(HoraInicio.Replace(":00:00.0000000", "")) - 1].BackgroundColor = UIColor.Clear.FromHex(0x404040);
                }
            }
        }

        private void LimpiarInfo()
        {
            this.HorasReservadas = 0;
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.FormatoDiaSeleccionado(NSDate.Now);
        }

        private void GenerateRecornizes()
        {
            UITapGestureRecognizer tapGesture2324 = new UITapGestureRecognizer(vw2324Touch);
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
            this.vw2401_2.AddGestureRecognizer(tapGesture2401_2);

            VistasHorarios.Add(this.vw0102);
            VistasHorarios.Add(this.vw0102_2);
            VistasHorarios.Add(this.vw0203);
            VistasHorarios.Add(this.vw0203_2);
            VistasHorarios.Add(this.vw0304);
            VistasHorarios.Add(this.vw0304_2);
            VistasHorarios.Add(this.vw0405);
            VistasHorarios.Add(this.vw0405_2);
            VistasHorarios.Add(this.vw0506);
            VistasHorarios.Add(this.vw0506_2);
            VistasHorarios.Add(this.vw0607);
            VistasHorarios.Add(this.vw0607_2);
            VistasHorarios.Add(this.vw0708);
            VistasHorarios.Add(this.vw0708_2);
            VistasHorarios.Add(this.vw0809);
            VistasHorarios.Add(this.vw0809_2);
            VistasHorarios.Add(this.vw0910);
            VistasHorarios.Add(this.vw0910_2);
            VistasHorarios.Add(this.vw1011);
            VistasHorarios.Add(this.vw1011_2);
            VistasHorarios.Add(this.vw1112);
            VistasHorarios.Add(this.vw1112_2);
            VistasHorarios.Add(this.vw1213);
            VistasHorarios.Add(this.vw1213_2);
            VistasHorarios.Add(this.vw1314);
            VistasHorarios.Add(this.vw1314_2);
            VistasHorarios.Add(this.vw1415);
            VistasHorarios.Add(this.vw1415_2);
            VistasHorarios.Add(this.vw1516);
            VistasHorarios.Add(this.vw1516_2);
            VistasHorarios.Add(this.vw1617);
            VistasHorarios.Add(this.vw1617_2);
            VistasHorarios.Add(this.vw1718);
            VistasHorarios.Add(this.vw1718_2);
            VistasHorarios.Add(this.vw1819);
            VistasHorarios.Add(this.vw1819_2);
            VistasHorarios.Add(this.vw1920);
            VistasHorarios.Add(this.vw1920_2);
            VistasHorarios.Add(this.vw2021);
            VistasHorarios.Add(this.vw2021_2);
            VistasHorarios.Add(this.vw2122);
            VistasHorarios.Add(this.vw2122_2);
            VistasHorarios.Add(this.vw2223);
            VistasHorarios.Add(this.vw2223_2);
            VistasHorarios.Add(this.view2324);
            VistasHorarios.Add(this.view2324_2);
            VistasHorarios.Add(this.vw2401);
            VistasHorarios.Add(this.vw2401_2);
        }


        //Touch Views
        private void vw2324Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.view2324.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2324 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.view2324.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2324 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;

                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "24", "24:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.view2324.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2324 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "24:30");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        CreditosAcumulados = CreditosAcumulados - 1;
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }



        private void vw2324Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.view2324_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2324_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.view2324_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2324_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;

                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "24:30", "01:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.view2324_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2324_2 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "01");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        CreditosAcumulados = CreditosAcumulados - 1;
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();
        }


        private void vw2223Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2223.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2223 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if ( this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw2223.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2223 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "01:00", "01:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw2223.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2223 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "01:30");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                    }
                   
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();
        }


        private void vw2223Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2223_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2223_2 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw2223_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2223_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "01:30", "02:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw2223_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2223_2 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "02:00");
                    if (itemToRemove != null)
                    {
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw2122Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2122.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2122 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw2122.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2122 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "02:00", "02:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw2122.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2122 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "02:30");
                    if (itemToRemove != null)
                    {
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();
        }


        private void vw2122Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2122_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2122_2 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw2122_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2122_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "02:30", "03:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw2122_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2122_2 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "03:00");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw2021Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2021.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2021 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw2021.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2021 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "03:00", "03:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw2021.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2021 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "03:30");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw2021Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2021_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2021_2 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw2021.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2021_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "03:30", "04:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw2021_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2021_2 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "04:00");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1920Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1920.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1920 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw1920.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1920 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "04:00", "04:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1920.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1920 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "04:30");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw1920Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1920_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1920_2 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw1920.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1920_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "04:30", "05:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1920_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1920_2 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "05:00");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1819Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1819.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1819 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw1819.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1819 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "05", "05:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw1819.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1819 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "05:30");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1819Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1819_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1819_2 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw1819_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1819_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "05:30", "06:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw1819_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1819_2 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "06:00");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1718Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1718.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1718 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw1718.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1718 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "06:00", "06:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw1718.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1718 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "06:30");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);                    
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1718Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1718_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1718_2 == false)
                {
                    if (this.SalaActual.Sala_Capacidad == "6")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1;
                    }
                    else if (this.SalaActual.Sala_Capacidad == "10")
                    {
                        CreditosAcumulados = CreditosAcumulados + 1.5f;
                    }
                    this.vw1718_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1718_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "06:30", "07:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw1718_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1718_2 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "07:00");
                    if (itemToRemove != null)
                    {
                        if (this.SalaActual.Sala_Capacidad == "6")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1;
                        }
                        else if (this.SalaActual.Sala_Capacidad == "10")
                        {
                            CreditosAcumulados = CreditosAcumulados - 1.5f;
                        }
                        this.HorasReservadas = this.HorasReservadas - 0.5f;
                        Reservaciones.Remove(itemToRemove);  
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw1617Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1617.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1617 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1617.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1617 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "07:00", "07:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1617.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1617 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "07:30");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                        CreditosAcumulados = CreditosAcumulados - 1;
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1617Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1617_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1617_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1617_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1617_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "07:30", "08:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1617_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1617_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "08:00");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                        CreditosAcumulados = CreditosAcumulados - 1;

                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1516Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1516.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1516 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1516.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1516 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "08:00", "08:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1516.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1516 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "08:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1516Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1516_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1516_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1516_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1516_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "08:30", "09:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1516_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1516_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "09:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1415Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1415.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1415 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1415.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1415 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "09:00", "09:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                   
                }
                else
                {
                    this.vw1415.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1415 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "09:30");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                        CreditosAcumulados = CreditosAcumulados - 1;
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1415Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1415_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1415_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1415_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1415_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "09:30", "10:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1415_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1415_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "10:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1314Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1314.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1314 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1314.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1314 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "10:00", "10:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1314.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1314 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "10:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1314Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1314_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1314_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1314_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1314_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "10:30", "11", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw1314_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1314_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "11");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1213Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1213.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1213 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1213.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1213 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "11:00", "11:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1213.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1213 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "11:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1213Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1213_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1213_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1213_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1213_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "11:30", "12:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1213_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1213_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "12:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1112Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1112.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1112 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1112.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1112 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "12:00", "12:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1112.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1112 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "12:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw1112Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1112_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1112_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1112_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1112_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "12:30", "01:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw1112_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1112_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "01:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1011Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1011.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1011 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1011.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1011 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "13:00","13:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw1011.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1011 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "13:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw1011Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1011_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1011_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw1011_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1011_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "13:30", "14:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw1011_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1011_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "14");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0910Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0910.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0910 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0910.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0910 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "14:00", "14:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0910.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0910 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "14:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0910Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0910_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0910_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0910_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0910_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "14:30", "15:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0910_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0910_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "15:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw0809Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0809.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0809 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0809.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0809 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "15:00", "15:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw0809.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0809 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "15:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw0809Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0809_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0809_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0809_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0809_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "15:30", "16:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw0809_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0809_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "16:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0708Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0708.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0708 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0708.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0708 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "16:00", "16:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0708.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0708 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "16:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0708Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0708_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0708_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0708_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0708_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "16:30", "17:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0708_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0708_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "17:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0607Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0607.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0607 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0607.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0607 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "17:00", "17:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0607.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0607 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "17:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0607Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0607_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0607_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0607_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0607_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "17:30", "18:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0607_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0607_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "18:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw0506Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0506.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0506 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0506.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0607 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "18:00", "18:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0506.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0607 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "19:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw0506Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0506_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0506_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0506_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0607_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "18:30", "19:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0506_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0607_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "19:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0405Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0405.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0405 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0405.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0405 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "19:00", "19:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0405.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0405 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "19:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0405Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0405_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0405_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0405_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0405_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "19:30", "20:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0405_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0405_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "20:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0304Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0304.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0304 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0304.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0304 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "20:00", "20:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0304.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0304 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "20:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0304Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0304_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0304_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0304_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0304_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "20:30", "21:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0304_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0304_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "21:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0203Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0203.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0203 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0203.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0203 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "21:00", "21:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw0203.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0203 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "21:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw0203Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0203_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0203_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0203_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0203_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "21:30", "22:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw0203_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0203_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "22:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw0102Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0102.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0102 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0102.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0102 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "22:00", "22:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));

                }
                else
                {
                    this.vw0102.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0102 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "22:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }



        private void vw0102Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0102_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0102_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw0102_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0102_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "22:30", "23:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw0102_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0102_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "23:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        private void vw0124Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2401.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0124 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw2401.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0124 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "23:00", "23:30", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw2401.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0124 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "23:30");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }


        private void vw0124Touch_2(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2401_2.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0124_2 == false)
                {
                    CreditosAcumulados = CreditosAcumulados + 1;
                    this.vw2401_2.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0124_2 = true;
                    this.HorasReservadas = this.HorasReservadas + 0.5f;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "23:30", "24:00", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 0.5f));
                }
                else
                {
                    this.vw2401_2.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0124_2 = false;
                    this.HorasReservadas = this.HorasReservadas - 0.5f;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "24:00");
                    if (itemToRemove != null)
                    {
                        CreditosAcumulados = CreditosAcumulados - 1;
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
            this.lblCreditosPorUsar.Text = CreditosAcumulados.ToString();

        }

        partial void btnSeleccionarFecha_Touch(UIButton sender)
        {
            this.PerformSegue("SelectDate", null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SelectDate")
            {
                var GenderView = (FechaReservacionPickerViewController)segue.DestinationViewController;
                GenderView.FechaSeleccionDelegate = this;
            }
            else if(segue.Identifier == "confirmarCompra")
            {
                var VistaConfirmacion = (ConfirmarSalaJuntasController)segue.DestinationViewController;
                VistaConfirmacion.Reservaciones = this.Reservaciones;
                VistaConfirmacion.EventosReservacionesDelegate = this;
            }
            else if(segue.Identifier == "DetalleReservacion")
            {
                var VistaInfoReservacion = (InfoConfirmacionViewController)segue.DestinationViewController;
                VistaInfoReservacion.Reservaciones = this.ReservacionesConcat;
                VistaInfoReservacion.ConfirmacionRealizadaDel = this;
            }

            else if (segue.Identifier == "SeleccionarNivel")
            {
                var VistaNivel = (NivelesViewController)segue.DestinationViewController;
                VistaNivel.NivelSeleccionadoDel = this;
            }
        }

        partial void btnAgendar_Touch(UIButton sender)
        {
            if (CreditosAcumulados <= float.Parse(this.lblCreditosDisponibles.Text))
            {
                if (this.Reservaciones.Count > 0)
                {
                    this.PerformSegue("confirmarCompra", null);
                }
                else
                {
                    new MessageDialog().SendToast("No has seleccionado un horario");
                }
            }
            else
            {
                new MessageDialog().SendToast("No tienes suficientes créditos");
            }

        }

        partial void btnNivel_Touch(UIButton sender)
        {
            this.PerformSegue("SeleccionarNivel", null);
        }

        public void GetSalas(int Nivel)
        {

            if (InternetConectionHelper.VerificarConexion())
            {
                this.SalasJuntas = new SalasJuntasController().GetSalaJuntas(SucursalId, Nivel.ToString());

                this.UpdateInfo();
            }

        }
    }


    partial class ReservarSalaJuntasViewTableController : FechaReservacion
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            this.btnSeleccionFecha.SetTitle(FechaReservacion, UIControlState.Normal);
            this.GetHorasNoDisponibles(this.SalaActual.Sala_Id);
           
            if(InternetConectionHelper.VerificarConexion())
            {
                this.HorasNoDisponibles = new SalasJuntasController().GetHorasNoDisponibles(this.btnSeleccionFecha.TitleLabel.Text, SalaId);
            }

            if(FechaReservacion == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                this.ValidateHour();
            }

            dateFormat.DateFormat = "dd/MM/yyyy";
            NSDate newFormatDate = dateFormat.Parse(FechaReservacion);
            this.FormatoDiaSeleccionado(newFormatDate);
        }
    }

    partial class ReservarSalaJuntasViewTableController: NivelSeleccionado
    {
        public void NivelSeleccionado(string Nivel)
        {
            this.lblPiso.Text = Nivel;
            this.btnNivel.SetTitle(Nivel, UIControlState.Normal);
            this.Nivel = int.Parse(Nivel.Replace("NIVEL ", ""));
            this.GetSalas(this.Nivel);
        }
    }

    partial class ReservarSalaJuntasViewTableController: EventosReservaciones
    {
        public async void ReservacionConfirmada(List<SalaJuntasReservacionModel> ReservacionesConcat)
        {
            await Task.Delay(100);
            this.ReservacionesConcat = ReservacionesConcat;
            this.PerformSegue("DetalleReservacion", null);
        }

        public void ReservacionCancelada(List<SalaJuntasReservacionModel> Reservciones)
        {
            this.Reservaciones = Reservciones;
        }
    }


    partial class ReservarSalaJuntasViewTableController : ConfirmacionRealizada
    {
        public void ConfirmacionRealizada()
        {
            this.NavigationController.PopViewController(true);
        }
    }


}