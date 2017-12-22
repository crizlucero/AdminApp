using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class ReservarSalaJuntasViewTableController : UITableViewController
    {

        public string SucursalId;
        NSDateFormatter dateFormat = new NSDateFormatter();
        bool FlagView2324 = false, FlagView2223 = false, FlagView2122 = false, FlagView2021 = false, FlagView1920 = false, FlagView1819 = false, FlagView1718 = false, FlagView1617 = false, Flag1516 = false, Flag1415 = false, Flag1314 = false, Flag1213 = false, Flag1112 = false, Flag1011 = false, Flag0910 = false, Flag0809 = false, Flag0708 = false, Flag0607 = false, Flag0506 = false, Flag0405 = false, Flag0304 = false, Flag0203 = false, Flag0102 = false, Flag0124 = false;

        List<SalaJuntasReservacionModel> HorasNoDisponibles = new List<SalaJuntasReservacionModel>();
        List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
        SalaJuntasModel SalaActual = new SalaJuntasModel();
        List<UIView> VistasHorarios = new List<UIView>();

        int HorasReservadas = 0;

        string DiaSeleccionado;

        public ReservarSalaJuntasViewTableController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.lblHorasReservadas.Text = "0";

            dateFormat.DateFormat = "dd";
            DiaSeleccionado = dateFormat.ToString(NSDate.Now);
            this.lblDiaNumero.Text = DiaSeleccionado;

            dateFormat.DateFormat = "EEEE";
            DiaSeleccionado = dateFormat.ToString(NSDate.Now);

            this.lblDiaLetra.Text = DiaSeleccionado;

            if(InternetConectionHelper.VerificarConexion())
            {
                this.SalasJuntas = new SalasJuntasController().GetSalaJuntas(SucursalId);
                if(this.SalasJuntas.Count >= 0)
                {
                    this.SalaActual = this.SalasJuntas[0];
                    this.HorasNoDisponibles = new SalasJuntasController().GetHorasNoDisponibles(this.btnSeleccionFecha.TitleLabel.Text, this.SalaActual.Sala_Id);
                    for (int indice = 0; indice < HorasNoDisponibles.Count; indice ++)
                    {
                        var HoraInicio = HorasNoDisponibles[indice].Sala_Hora_Inicio;
                        this.VistasHorarios[int.Parse(HoraInicio) - 1].BackgroundColor = UIColor.Black;
                    }
                }
            }

            nfloat WidthView = 0;
            nfloat XImageView = 0;

            for (int indice = 0; indice < this.SalasJuntas.Count; indice ++)
            {
                WidthView = WidthView + this.vwSalasJuntas.Frame.Width;
            }
            this.pcSucursales.Pages = this.SalasJuntas.Count;
            CGRect newFrame = new CGRect(this.vwSalasJuntas.Frame.X, this.vwSalasJuntas.Frame.Y, WidthView, this.vwSalasJuntas.Frame.Height);

            this.vwSalasJuntas.Frame = newFrame;

            for (int indice = 1; indice < this.SalasJuntas.Count; indice++)
            {
                XImageView = XImageView + this.imgSalasJuntas.Frame.Width;
                UIImageView ImagenSalaJuntas = new UIImageView();
                ImagenSalaJuntas.Frame = new CGRect(XImageView, this.imgSalasJuntas.Frame.Y, this.imgSalasJuntas.Frame.Width, this.imgSalasJuntas.Frame.Height);
                ImagenSalaJuntas.Image = UIImage.FromBundle("SalaJuntas");
                this.vwSalasJuntas.Add(ImagenSalaJuntas);
            }

            this.scvSalasJuntas.ContentSize = vwSalasJuntas.Frame.Size;
            this.scvSalasJuntas.Scrolled += (sender, e) =>
            {
                this.pcSucursales.CurrentPage = (nint)(scvSalasJuntas.ContentOffset.X / scvSalasJuntas.Frame.Width);
                this.SalaActual = this.SalasJuntas[int.Parse(this.pcSucursales.CurrentPage.ToString())];
                this.lblPiso.Text = "NIVEL " + SalaActual.Sala_Nivel;
                this.lblNombre.Text = SalaActual.Sala_Descripcion;
                this.lblCapacidad.Text = SalaActual.Sala_Capacidad + " PERSONAS";
                this.HorasNoDisponibles = new SalasJuntasController().GetHorasNoDisponibles(this.btnSeleccionFecha.TitleLabel.Text, this.SalaActual.Sala_Id);
                for (int indice = 0; indice < HorasNoDisponibles.Count; indice++)
                {
                    var HoraInicio = HorasNoDisponibles[indice].Sala_Hora_Inicio;
                    this.VistasHorarios[int.Parse(HoraInicio) - 1].BackgroundColor = UIColor.Black;
                }
            };

            this.GenerateRecornizes();
            CGRect FrameHorarios = new CGRect(this.vwHorarios.Frame.X, this.vwHorarios.Frame.Y, this.vwHorarios.Frame.Width + 50, this.vwHorarios.Frame.Height);
            this.scvScrollHorarios.ContentSize = FrameHorarios.Size;
            StyleHelper.Style(this.vwBotonFecha.Layer);
            StyleHelper.Style(this.vwInfoReservacion.Layer);
            dateFormat.DateFormat = "dd/MM/yyyy";
            this.btnSeleccionFecha.SetTitle(dateFormat.ToString(NSDate.Now), UIControlState.Normal);
        }


        private void FormatoDiaSeleccionado(NSDate Day)
        {
            dateFormat.DateFormat = "dd";
            DiaSeleccionado = dateFormat.ToString(Day);
            this.lblDiaNumero.Text = DiaSeleccionado;

            dateFormat.DateFormat = "EEEE";
            DiaSeleccionado = dateFormat.ToString(Day);

            this.lblDiaLetra.Text = DiaSeleccionado;
        }

        private void GenerateRecornizes()
        {

            UITapGestureRecognizer tapGesture2324 = new UITapGestureRecognizer(vw2324Touch);
            UITapGestureRecognizer tapGesture2223 = new UITapGestureRecognizer(vw2223Touch);
            UITapGestureRecognizer tapGesture2122 = new UITapGestureRecognizer(vw2122Touch);
            UITapGestureRecognizer tapGesture2021 = new UITapGestureRecognizer(vw2021Touch);
            UITapGestureRecognizer tapGesture1920 = new UITapGestureRecognizer(vw1920Touch);
            UITapGestureRecognizer tapGesture1819 = new UITapGestureRecognizer(vw1819Touch);
            UITapGestureRecognizer tapGesture1718 = new UITapGestureRecognizer(vw1718Touch);
            UITapGestureRecognizer tapGesture1617 = new UITapGestureRecognizer(vw1617Touch);
            UITapGestureRecognizer tapGesture1516 = new UITapGestureRecognizer(vw1516Touch);
            UITapGestureRecognizer tapGesture1415 = new UITapGestureRecognizer(vw1415Touch);
            UITapGestureRecognizer tapGesture1314 = new UITapGestureRecognizer(vw1314Touch);
            UITapGestureRecognizer tapGesture1213 = new UITapGestureRecognizer(vw1213Touch);
            UITapGestureRecognizer tapGesture1112 = new UITapGestureRecognizer(vw1112Touch);
            UITapGestureRecognizer tapGesture1011 = new UITapGestureRecognizer(vw1011Touch);
            UITapGestureRecognizer tapGesture0910 = new UITapGestureRecognizer(vw0910Touch);
            UITapGestureRecognizer tapGesture0809 = new UITapGestureRecognizer(vw0809Touch);
            UITapGestureRecognizer tapGesture0708 = new UITapGestureRecognizer(vw0708Touch);
            UITapGestureRecognizer tapGesture0607 = new UITapGestureRecognizer(vw0607Touch);
            UITapGestureRecognizer tapGesture0506 = new UITapGestureRecognizer(vw0506Touch);
            UITapGestureRecognizer tapGesture0405 = new UITapGestureRecognizer(vw0405Touch);
            UITapGestureRecognizer tapGesture0304 = new UITapGestureRecognizer(vw0304Touch);
            UITapGestureRecognizer tapGesture0203 = new UITapGestureRecognizer(vw0203Touch);
            UITapGestureRecognizer tapGesture0102 = new UITapGestureRecognizer(vw0102Touch);
            UITapGestureRecognizer tapGesture2401 = new UITapGestureRecognizer(vw0124Touch);

            this.view2324.UserInteractionEnabled = true;
            this.view2324.AddGestureRecognizer(tapGesture2324);
            this.view2324.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);


            this.vw0102.UserInteractionEnabled = true;
            this.vw0102.AddGestureRecognizer(tapGesture0102);

            this.vw0203.UserInteractionEnabled = true;
            this.vw0203.AddGestureRecognizer(tapGesture0203);

            this.vw0304.UserInteractionEnabled = true;
            this.vw0304.AddGestureRecognizer(tapGesture0304);

            this.vw0405.UserInteractionEnabled = true;
            this.vw0405.AddGestureRecognizer(tapGesture0405);

            this.vw0506.UserInteractionEnabled = true;
            this.vw0506.AddGestureRecognizer(tapGesture0506);

            this.vw0607.UserInteractionEnabled = true;
            this.vw0607.AddGestureRecognizer(tapGesture0607);

            this.vw0708.UserInteractionEnabled = true;
            this.vw0708.AddGestureRecognizer(tapGesture0708);

            this.vw0809.UserInteractionEnabled = true;
            this.vw0809.AddGestureRecognizer(tapGesture0809);

            this.vw0910.UserInteractionEnabled = true;
            this.vw0910.AddGestureRecognizer(tapGesture0910);

            this.vw1011.UserInteractionEnabled = true;
            this.vw1011.AddGestureRecognizer(tapGesture1011);

            this.vw1112.UserInteractionEnabled = true;
            this.vw1112.AddGestureRecognizer(tapGesture1112);

            this.vw1213.UserInteractionEnabled = true;
            this.vw1213.AddGestureRecognizer(tapGesture1213);

            this.vw1314.UserInteractionEnabled = true;
            this.vw1314.AddGestureRecognizer(tapGesture1314);

            this.vw1415.UserInteractionEnabled = true;
            this.vw1415.AddGestureRecognizer(tapGesture1415);

            this.vw1516.UserInteractionEnabled = true;
            this.vw1516.AddGestureRecognizer(tapGesture1516);

            this.vw1617.UserInteractionEnabled = true;
            this.vw1617.AddGestureRecognizer(tapGesture1617);

            this.vw1718.UserInteractionEnabled = true;
            this.vw1718.AddGestureRecognizer(tapGesture1718);

            this.vw1819.UserInteractionEnabled = true;
            this.vw1819.AddGestureRecognizer(tapGesture1819);

            this.vw1920.UserInteractionEnabled = true;
            this.vw1920.AddGestureRecognizer(tapGesture1920);

            this.vw2021.UserInteractionEnabled = true;
            this.vw2021.AddGestureRecognizer(tapGesture2021);

            this.vw2122.UserInteractionEnabled = true;
            this.vw2122.AddGestureRecognizer(tapGesture2122);

            this.vw2223.UserInteractionEnabled = true;
            this.vw2223.AddGestureRecognizer(tapGesture2223);

            this.vw2401.UserInteractionEnabled = true;
            this.vw2401.AddGestureRecognizer(tapGesture2401);

            VistasHorarios.Add(this.vw0102);
            VistasHorarios.Add(this.vw0203);
            VistasHorarios.Add(this.vw0304);
            VistasHorarios.Add(this.vw0405);
            VistasHorarios.Add(this.vw0506);
            VistasHorarios.Add(this.vw0607);
            VistasHorarios.Add(this.vw0708);
            VistasHorarios.Add(this.vw0809);
            VistasHorarios.Add(this.vw0910);
            VistasHorarios.Add(this.vw1011);
            VistasHorarios.Add(this.vw1112);
            VistasHorarios.Add(this.vw1213);
            VistasHorarios.Add(this.vw1314);
            VistasHorarios.Add(this.vw1415);
            VistasHorarios.Add(this.vw1516);
            VistasHorarios.Add(this.vw1617);
            VistasHorarios.Add(this.vw1718);
            VistasHorarios.Add(this.vw1819);
            VistasHorarios.Add(this.vw1920);
            VistasHorarios.Add(this.vw2021);
            VistasHorarios.Add(this.vw2122);
            VistasHorarios.Add(this.vw2223);
            VistasHorarios.Add(this.view2324);
            VistasHorarios.Add(this.vw2401);
        }


        //Touch Views
        private void vw2324Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.view2324.BackgroundColor != UIColor.Black)
            {
                if (this.FlagView2324 == false)
                {
                    this.view2324.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2324 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.view2324.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2324 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();

        }

        private void vw2223Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2223.BackgroundColor != UIColor.Black)
            {
                if (this.FlagView2223 == false)
                {
                    this.vw2223.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2223 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw2223.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2223 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();

        }

        private void vw2122Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2122.BackgroundColor != UIColor.Black)
            {
                if (this.FlagView2122 == false)
                {
                    this.vw2122.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2122 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw2122.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2122 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw2021Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2021.BackgroundColor != UIColor.Black)
            {
                if (this.FlagView2021 == false)
                {
                    this.vw2021.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2021 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw2021.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2021 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1920Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1920.BackgroundColor != UIColor.Black)
            {
                if (this.FlagView1920 == false)
                {
                    this.vw1920.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1920 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1920.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1920 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1819Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1819.BackgroundColor != UIColor.Black)
            {
                if (this.FlagView1819 == false)
                {
                    this.vw1819.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1819 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1819.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1819 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1718Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1718.BackgroundColor != UIColor.Black)
            {
                if (this.FlagView1718 == false)
                {
                    this.vw1718.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1718 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1718.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1718 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1617Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1617.BackgroundColor != UIColor.Black)
            {
                if (this.FlagView1617 == false)
                {
                    this.vw1617.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1617 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1617.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1617 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1516Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1516.BackgroundColor != UIColor.Black)
            {
                if (this.Flag1516 == false)
                {
                    this.vw1516.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1516 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1516.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1516 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1415Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1415.BackgroundColor != UIColor.Black)
            {
                if (this.Flag1415 == false)
                {
                    this.vw1415.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1415 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1415.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1415 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1314Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1314.BackgroundColor != UIColor.Black)
            {
                if (this.Flag1314 == false)
                {
                    this.vw1314.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1314 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1314.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1314 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1213Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1213.BackgroundColor != UIColor.Black)
            {
                if (this.Flag1213 == false)
                {
                    this.vw1213.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1213 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1213.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1213 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1112Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1112.BackgroundColor != UIColor.Black)
            {
                if (this.Flag1112 == false)
                {
                    this.vw1213.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1112 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1213.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1112 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1011Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1011.BackgroundColor != UIColor.Black)
            {
                if (this.Flag1011 == false)
                {
                    this.vw1011.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1011 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw1011.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1011 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0910Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0910.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0910 == false)
                {
                    this.vw0910.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0910 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0910.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0910 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0809Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0809.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0809 == false)
                {
                    this.vw0809.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0809 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0809.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0809 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0708Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0708.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0708 == false)
                {
                    this.vw0708.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0708 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0708.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0708 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0607Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0607.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0607 == false)
                {
                    this.vw0607.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0607 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0607.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0607 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0506Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0506.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0506 == false)
                {
                    this.vw0506.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0607 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0506.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0607 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0405Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0405.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0405 == false)
                {
                    this.vw0405.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0405 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0405.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0405 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0304Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0304.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0304 == false)
                {
                    this.vw0304.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0304 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0304.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0304 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0203Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0203.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0203 == false)
                {
                    this.vw0203.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0203 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0203.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0203 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0102Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0102.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0102 == false)
                {
                    this.vw0102.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0102 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw0102.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0102 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0124Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2401.BackgroundColor != UIColor.Black)
            {
                if (this.Flag0124 == false)
                {
                    this.vw2401.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0124 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                }
                else
                {
                    this.vw2401.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0124 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
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
                GenderView.FechaSeleccionadaDelegate = this;
            }
        }

    }


    partial class ReservarSalaJuntasViewTableController : FechaReservaSeleccionada
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            this.btnSeleccionFecha.SetTitle(FechaReservacion, UIControlState.Normal);
            this.HorasNoDisponibles = new SalasJuntasController().GetHorasNoDisponibles(FechaReservacion, this.SalaActual.Sala_Id);
            for (int indice = 0; indice < HorasNoDisponibles.Count; indice++)
            {
                var HoraInicio = HorasNoDisponibles[indice].Sala_Hora_Inicio;
                this.VistasHorarios[int.Parse(HoraInicio) - 1].BackgroundColor = UIColor.Black;
            }
            var NewDate = DateTime.ParseExact(FechaReservacion, "dd/MM/yyyy", null);
            NSDate newFormatDate = (NSDate)NewDate;
            this.FormatoDiaSeleccionado(newFormatDate);
        }
    }


}