using Foundation;
using System;
using UIKit;
using System.Drawing;
using System.Collections.Generic;
using CoreGraphics;
using WorklabsMx;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class RegistroInvitadosController : UIViewController
    {
        UIDatePicker dpFecha;

        public RegistroInvitadosController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //this.DefineMinMaxDate();
            var scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
            UITextField txtNombre = new STLTextField("Nombre", 20);
            scrollView.Add(txtNombre);

            UITextField txtAsunto = new STLTextField("Asunto", 60);
            scrollView.Add(txtAsunto);

            UITextField txtEmail = new STLTextField("Correo Electrónico", 100);
            scrollView.Add(txtEmail);

            UITextField txtCC = new STLTextField("CC", 140);
            scrollView.Add(txtCC);

            scrollView.Add(new STLLabel("Hora de Entrada", 180));

            UIDatePicker dpHoraEntrada = new UIDatePicker { Mode = UIDatePickerMode.Time, Frame = new CGRect(40, 200, UIScreen.MainScreen.Bounds.Width - 40, 100) };
            scrollView.Add(dpHoraEntrada);

            scrollView.Add(new UILabel { Text = "Hora de Salida", Frame = new CGRect(40, 310, UIScreen.MainScreen.Bounds.Width, 30) });

            UIDatePicker dpHoraSalida = new UIDatePicker { Mode = UIDatePickerMode.Time, Frame = new CGRect(40, 330, UIScreen.MainScreen.Bounds.Width - 40, 100) };
            scrollView.Add(dpHoraSalida);

            scrollView.Add(new UILabel { Text = "Fecha", Frame = new CGRect(40, 440, UIScreen.MainScreen.Bounds.Width, 30) });

            dpFecha = new UIDatePicker { Mode = UIDatePickerMode.Date, Frame = new CGRect(40, 450, UIScreen.MainScreen.Bounds.Width - 40, 100), MinimumDate = (NSDate)DateTime.Today };
            scrollView.Add(dpFecha);

            this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Registrar", UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                new InvitadosController().RegistraInvitado(txtNombre.Text, txtAsunto.Text, txtEmail.Text, txtCC.Text, (DateTime)dpHoraEntrada.Date, (DateTime)dpHoraSalida.Date, (DateTime)dpFecha.Date);
            }), true);

            scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 580);
            Add(scrollView);
        }

        private void DefineMinMaxDate()
        {
            dpFecha.MinimumDate = (NSDate)DateTime.Today;
            dpFecha.MaximumDate = (NSDate)DateTime.Now.AddMonths(1).AddDays(-1);
        }
    }
}