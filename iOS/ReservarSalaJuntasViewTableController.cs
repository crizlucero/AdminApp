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

        public string SucursalId;
        NSDateFormatter dateFormat = new NSDateFormatter();
        bool FlagView2324 = false, FlagView2223 = false, FlagView2122 = false, FlagView2021 = false, FlagView1920 = false, FlagView1819 = false, FlagView1718 = false, FlagView1617 = false, Flag1516 = false, Flag1415 = false, Flag1314 = false, Flag1213 = false, Flag1112 = false, Flag1011 = false, Flag0910 = false, Flag0809 = false, Flag0708 = false, Flag0607 = false, Flag0506 = false, Flag0405 = false, Flag0304 = false, Flag0203 = false, Flag0102 = false, Flag0124 = false;

        List<SalaJuntasReservacionModel> HorasNoDisponibles = new List<SalaJuntasReservacionModel>();
        List<SalaJuntasModel> SalasJuntas = new List<SalaJuntasModel>();
        SalaJuntasModel SalaActual = new SalaJuntasModel();
        List<UIView> VistasHorarios = new List<UIView>();

        List<SalaJuntasReservacionModel> Reservaciones = new List<SalaJuntasReservacionModel>();
        List<SalaJuntasReservacionModel> ReservacionesConcat = new List<SalaJuntasReservacionModel>();

        int HorasReservadas = 0;

        string DiaSeleccionado;



        public ReservarSalaJuntasViewTableController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.GenerateRecornizes();
            this.LimpiarInfo();

            if(InternetConectionHelper.VerificarConexion())
            {
                this.SalasJuntas = new SalasJuntasController().GetSalaJuntas(SucursalId);
                if(this.SalasJuntas.Count > 0)
                {
                    this.SalaActual = this.SalasJuntas[0];

                    this.GetHorasNoDisponibles(SalaActual.Sala_Id);
                    this.lblPiso.Text = "NIVEL " +  this.SalaActual.Sala_Nivel;
                    this.lblNombre.Text = this.SalaActual.Sala_Descripcion;
                    this.lblCapacidad.Text = this.SalaActual.Sala_Capacidad + " PERSONAS";
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

                if (InternetConectionHelper.VerificarConexion())
                {
                    this.GetHorasNoDisponibles(this.SalaActual.Sala_Id);
                }
               
            };

           
            CGRect FrameHorarios = new CGRect(this.vwHorarios.Frame.X, this.vwHorarios.Frame.Y, this.vwHorarios.Frame.Width + 50, this.vwHorarios.Frame.Height);
            this.scvScrollHorarios.ContentSize = FrameHorarios.Size;
            StyleHelper.Style(this.vwBotonFecha.Layer);
            StyleHelper.Style(this.vwInfoReservacion.Layer);
            this.ValidateHour();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }


        private void ValidateHour()
        {
            int date = DateTime.Now.Hour;

            if (date >= 0)
            {
                vw2401.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 1)
            {
                vw0102.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 2)
            {
                vw0203.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 3)
            {
                vw0304.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 4)
            {
                vw0405.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 5)
            {
                vw0506.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 6)
            {
                vw0607.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 7)
            {
                vw0708.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 8)
            {
                vw0809.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 9)
            {
                vw0910.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 10)
            {
                vw1011.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 11)
            {
                vw1112.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 12)
            {
                vw1213.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 13)
            {
                vw1314.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 14)
            {
                vw1415.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 15)
            {
                vw1516.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }


            if (date >= 16)
            {
                vw1617.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 17)
            {
                vw1718.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 18)
            {
                vw1819.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 19)
            {
                vw1920.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 20)
            {
                vw2021.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }


            if (date >= 21)
            {
                vw2122.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 22)
            {
                vw2223.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 23)
            {
                view2324.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }
            if (date >= 24)
            {
                vw2401.BackgroundColor = UIColor.Clear.FromHex(0x404040);
            }

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
            for (int indice = 0; indice < 24; indice++)
            {
                this.VistasHorarios[indice].BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
            }
            FlagView2324 = false; FlagView2223 = false; FlagView2122 = false; FlagView2021 = false; FlagView1920 = false; FlagView1819 = false; FlagView1718 = false; FlagView1617 = false; Flag1516 = false; Flag1415 = false; Flag1314 = false; Flag1213 = false; Flag1112 = false; Flag1011 = false; Flag0910 = false; Flag0809 = false; Flag0708 = false; Flag0607 = false; Flag0506 = false; Flag0405 = false; Flag0304 = false; Flag0203 = false; Flag0102 = false; Flag0124 = false;

            this.HorasNoDisponibles = new SalasJuntasController().GetHorasNoDisponibles(this.btnSeleccionFecha.TitleLabel.Text, SalaId);
            for (int indice = 0; indice < HorasNoDisponibles.Count; indice++)
            {
                var HoraInicio = HorasNoDisponibles[indice].Sala_Hora_Inicio;
                this.VistasHorarios[int.Parse(HoraInicio.Replace(":00:00.0000000","")) - 1].BackgroundColor = UIColor.Clear.FromHex(0x404040);
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
            if (this.view2324.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2324 == false)
                {
                    this.view2324.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2324 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;

                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "23", "24", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));
                }
                else
                {
                    this.view2324.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2324 = false;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "24");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                        this.HorasReservadas = this.HorasReservadas - 1;
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();

        }

        private void vw2223Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2223.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2223 == false)
                {
                    this.vw2223.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2223 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "22", "23", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw2223.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2223 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "23");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();

        }

        private void vw2122Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2122.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2122 == false)
                {
                    this.vw2122.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2122 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "21", "22", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw2122.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2122 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "22");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw2021Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2021.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView2021 == false)
                {
                    this.vw2021.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView2021 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "20", "21", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw2021.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView2021 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "21");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1920Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1920.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1920 == false)
                {
                    this.vw1920.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1920 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "19", "20", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw1920.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1920 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "20");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1819Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1819.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1819 == false)
                {
                    this.vw1819.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1819 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "18", "19", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));
                }
                else
                {
                    this.vw1819.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1819 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "19");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1718Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1718.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1718 == false)
                {
                    this.vw1718.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1718 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "17", "18", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));
                }
                else
                {
                    this.vw1718.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1718 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "18");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }

                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1617Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1617.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.FlagView1617 == false)
                {
                    this.vw1617.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.FlagView1617 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "16", "17", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw1617.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.FlagView1617 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "17");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1516Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1516.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1516 == false)
                {
                    this.vw1516.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1516 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "15", "16", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw1516.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1516 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "16");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1415Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1415.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1415 == false)
                {
                    this.vw1415.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1415 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "14", "15", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw1415.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1415 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "15");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1314Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1314.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1314 == false)
                {
                    this.vw1314.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1314 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "13", "14", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw1314.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1314 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "14");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1213Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1213.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1213 == false)
                {
                    this.vw1213.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1213 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "12", "13", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw1213.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1213 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "13");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1112Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1112.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1112 == false)
                {
                    this.vw1112.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1112 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "11", "12", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw1112.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1112 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "12");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw1011Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw1011.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag1011 == false)
                {
                    this.vw1011.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag1011 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "10", "11", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw1011.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag1011 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "11");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0910Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0910.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0910 == false)
                {
                    this.vw0910.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0910 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "09", "10", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw0910.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0910 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "10");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0809Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0809.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0809 == false)
                {
                    this.vw0809.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0809 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "08", "09", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw0809.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0809 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "10");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0708Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0708.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0708 == false)
                {
                    this.vw0708.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0708 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "07", "08", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw0708.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0708 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "08");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0607Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0607.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0607 == false)
                {
                    this.vw0607.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0607 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "06", "07", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw0607.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0607 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "07");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0506Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0506.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0506 == false)
                {
                    this.vw0506.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0607 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "05", "06", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw0506.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0607 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "06");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0405Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0405.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0405 == false)
                {
                    this.vw0405.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0405 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "04", "05", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw0405.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0405 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "05");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0304Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0304.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0304 == false)
                {
                    this.vw0304.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0304 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "03", "04", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw0304.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0304 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "03");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0203Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0203.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0203 == false)
                {
                    this.vw0203.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0203 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "02", "03", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));
                }
                else
                {
                    this.vw0203.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0203 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "03");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0102Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw0102.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0102 == false)
                {
                    this.vw0102.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0102 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "01", "02", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw0102.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0102 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "02");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
        }

        private void vw0124Touch(UITapGestureRecognizer Recognizer)
        {
            if (this.vw2401.BackgroundColor.ToString() != UIColor.Clear.FromHex(0x404040).ToString())
            {
                if (this.Flag0124 == false)
                {
                    this.vw2401.BackgroundColor = UIColor.Clear.FromHex(0xA2DBFF);
                    this.Flag0124 = true;
                    this.HorasReservadas = this.HorasReservadas + 1;
                    this.Reservaciones.Add(new SalaJuntasReservacionModel(SalaActual.Sala_Id, "24", "01", this.btnSeleccionFecha.Title(UIControlState.Normal), "1", KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), this.SalaActual.Sala_Descripcion, this.SalaActual.Sala_Capacidad, this.SalaActual.Sala_Nivel, this.SalaActual.Sucursal_Descripcion, this.SalaActual.Sucursal_Id, this.SalaActual.Sala_Id, 1));

                }
                else
                {
                    this.vw2401.BackgroundColor = UIColor.Clear.FromHex(0xE1FCC3);
                    this.Flag0124 = false;
                    this.HorasReservadas = this.HorasReservadas - 1;
                    var itemToRemove = Reservaciones.Find(x => x.Sala_Hora_Fin == "01");
                    if (itemToRemove != null)
                    {
                        Reservaciones.Remove(itemToRemove);
                    }
                }
            }
            this.lblHorasReservadas.Text = this.HorasReservadas.ToString();
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
        }

        partial void btnAgendar_Touch(UIButton sender)
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
    }


    partial class ReservarSalaJuntasViewTableController : FechaReservacion
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            this.btnSeleccionFecha.SetTitle(FechaReservacion, UIControlState.Normal);
            if(InternetConectionHelper.VerificarConexion())
            {
                this.GetHorasNoDisponibles(this.SalaActual.Sala_Id);
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