using Foundation;
using System;
using UIKit;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using System.Threading.Tasks;
using EventKit;
using CoreLocation;

namespace WorklabsMx.iOS
{

    public partial class DetalleInvitacionViewController : UIViewController
    {

        public List<MiembroModel> Invitados = new List<MiembroModel>();
        public List<MiembroModel> InvitadosCalendar = new List<MiembroModel>();
        public SucursalModel SucursalModel;
        string strAcceso = string.Empty;
        public string FechaReservacion, Asunto;

        public DetalleInvitacionViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.GenerarEvento();
            this.LlenarInfo();
        }

        public void LlenarInfo()
        {

            nfloat WidthView = 0;

            nfloat XLabelNombre = 0;
            nfloat XViewQR = 106;
            nfloat XImageQR = 0;

            for (int indice = 0; indice < this.Invitados.Count; indice++)
            {
                WidthView = WidthView + this.vwQR.Frame.Width;
            }

            if (this.Invitados.Count == 1)
            {
                this.btnAtras.Hidden = true;
                this.btnAtras.Enabled = false;

                this.btnAdelante.Hidden = true;
                this.btnAdelante.Enabled = false;
            }

            CGRect newFrame = new CGRect(this.vwQR.Frame.X, this.vwQR.Frame.Y, WidthView, this.vwQR.Frame.Height);

            this.vwQR.Frame = newFrame;

            var PrimerInvitado = Invitados[0];

            this.lblFecha.Text = this.FechaReservacion;
            this.lblDomicilio.Text = SucursalModel.Sucursal_Descripcion + " " + SucursalModel.Sucursal_Domicilio;
            this.lblNombreInvitado.Text = PrimerInvitado.Miembro_Nombre + " " + PrimerInvitado.Miembro_Apellidos;
            string newAcceso = new MiembrosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
            //LoadingView loadPop = new LoadingView(UIScreen.MainScreen.Bounds);
            //View.Add(loadPop);
            //strAcceso = newAcceso;
            imgQR.Image = ImageGallery.LoadImageUrl(newAcceso);
            //loadPop.Hide();
            Invitados.Remove(PrimerInvitado);
            foreach(MiembroModel Invitado in Invitados)
            {
                XLabelNombre = XLabelNombre + this.lblNombreInvitado.Frame.Width;
                UILabel LabelNombre = new UILabel();
                LabelNombre.Frame = new CGRect(XLabelNombre, this.lblNombreInvitado.Frame.Y, this.lblNombreInvitado.Frame.Width, this.lblNombreInvitado.Frame.Height);
                LabelNombre.Text = Invitado.Miembro_Nombre + " " + Invitado.Miembro_Apellidos;
                LabelNombre.Font = lblNombreInvitado.Font;
                LabelNombre.TextColor = UIColor.White;
                LabelNombre.TextAlignment = UITextAlignment.Left;

                XViewQR = XViewQR + vwContentQR.Frame.Width;
                UIView VistaQR = new UIView();
                VistaQR.Frame = new CGRect(XViewQR, this.vwContentQR.Frame.Y, this.vwContentQR.Frame.Width, this.vwContentQR.Frame.Height);

                UIImageView ImagenQr = new UIImageView();
                ImagenQr.Frame = this.imgQR.Frame;
                newAcceso = new MiembrosController().GetLlaveAcceso(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
                ImagenQr.Image = ImageGallery.LoadImageUrl(newAcceso);

                VistaQR.Add(ImagenQr);
                VistaQR.BackgroundColor = UIColor.White;
                VistaQR.Layer.MasksToBounds = true;
                VistaQR.Layer.CornerRadius = 7f;

                this.vwQR.Add(LabelNombre);
                this.vwQR.Add(VistaQR);

            }

            this.scvQR.ContentSize = this.vwQR.Frame.Size;
        }

        partial void btnCerrar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnAtras_Touch(UIButton sender)
        {
        }

        partial void btnAdelante_Touch(UIButton sender)
        {
        }

        private void GenerarEvento()
        {
            RequestAccess(EKEntityType.Event, () =>
            {
                
                CLLocation location = new CLLocation();
                if (SucursalModel.Sucursal_Id == "1")
                {
                    location = new CLLocation(20.6766, -103.3812);
                }
                else
                {
                    location = new CLLocation(20.6766, -103.3812);
                }
                var structuredLocation = new EKStructuredLocation();
                structuredLocation.Title = SucursalModel.Sucursal_Domicilio;
                structuredLocation.GeoLocation = location;

                NSDateFormatter dateFormat = new NSDateFormatter();
                dateFormat.DateFormat = "E, d MMM yyyy HH:mm";
                NSDate newFormatDate = dateFormat.Parse(this.FechaReservacion);
                EKEvent newEvent = EKEvent.FromStore(AppHelper.Current.EventStore);

                DateTime myDate = ((DateTime)newFormatDate).ToLocalTime();
                var HoraAntesReunion = myDate.AddHours(1 * - 1);
                newEvent.AddAlarm(EKAlarm.FromDate(DateTimeToNSDate(HoraAntesReunion.AddMinutes(30))));
                newEvent.AddAlarm(EKAlarm.FromDate(DateTimeToNSDate(HoraAntesReunion.AddMinutes(45))));
                if (myDate != null)
                {
                    newEvent.StartDate = DateTimeToNSDate(myDate);
                    newEvent.EndDate = DateTimeToNSDate(myDate.AddHours(1));
                }
                newEvent.Title = "Visita de invitados en " + SucursalModel.Sucursal_Descripcion;
                newEvent.Notes = "Invitados: ";
                foreach (MiembroModel Invitado in InvitadosCalendar)
                {
                    newEvent.Notes = newEvent.Notes + Invitado.Miembro_Nombre + " " + Invitado.Miembro_Apellidos + ". ";
                }
                newEvent.Notes = newEvent.Notes + " Asunto: " + Asunto;
                newEvent.Calendar = AppHelper.Current.EventStore.DefaultCalendarForNewEvents;
                newEvent.Location = SucursalModel.Sucursal_Domicilio;
                newEvent.StructuredLocation = structuredLocation;
                NSError e;
                AppHelper.Current.EventStore.SaveEvent(newEvent, EKSpan.ThisEvent, out e);
            });

        }

        protected void RequestAccess(EKEntityType type, Action completion)
        {
            AppHelper.Current.EventStore.RequestAccess(type,
                (bool granted, NSError e) => {
                    InvokeOnMainThread(() =>
                    {
                        if (granted)
                        {
                            completion.Invoke();
                        }
                        else
                        {
                            new MessageDialog().SendToast("Acceso denegado, no tienes acceso a el calendario");
                        }

                    });
                });
        }


        public NSDate DateTimeToNSDate(DateTime date)
        {
            if (date.Kind == DateTimeKind.Unspecified)
                date = DateTime.SpecifyKind(date, DateTimeKind.Local);
            return (NSDate)date;
        }
    }
}