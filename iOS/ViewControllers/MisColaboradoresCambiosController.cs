using Foundation;
using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class MisColaboradoresCambiosController : UIViewController
    {
        ColaboradorModel colaborador;

        public MisColaboradoresCambiosController(IntPtr handle) : base(handle)
        {
            colaborador = new ColaboradorModel();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Actualizar datos";
            string rightButton = "Agregar";
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            if (!string.IsNullOrEmpty(storageLocal.Get("Colaborador_Id")))
            {
                colaborador = new ColaboradoresController().GetColaborador(storageLocal.Get("Colaborador_Id"));
                rightButton = "Actualizar";
            }
            this.Title = colaborador.Colaborador_Nombre + " " + colaborador.Colaborador_Apellidos;
            using (var scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                scrollView.Add(new STLLabel("Fotografía", 40));

                UIImageView imagen = new STLImageView(65, colaborador.Colaborador_Fotografia);
                imagen.Image.Scale(new CGSize(50, 50), 0);
                scrollView.Add(imagen);

                UIButton btnPhoto = ImageGallery.SelectPhoto(this, imagen);
                btnPhoto.Frame = new CGRect(20, 130, 220, 40);
                scrollView.Add(btnPhoto);

                scrollView.Add(new STLLabel("Nombre", 170));
                UITextField txtNombre = new STLTextField("Nombre", 190, colaborador.Colaborador_Nombre);
                scrollView.Add(txtNombre);

                scrollView.Add(new STLLabel("Apellidos", 220));
                UITextField txtApellidos = new STLTextField("Apellidos", 240, colaborador.Colaborador_Apellidos);
                scrollView.Add(txtApellidos);

                scrollView.Add(new STLLabel("Puesto", 270));
                UITextField txtPuesto = new STLTextField("Puesto", 290, colaborador.Colaborador_Puesto);
                scrollView.Add(txtPuesto);

                scrollView.Add(new STLLabel("Profesión", 320));
                UITextField txtProfesion = new STLTextField("Profesión", 340, colaborador.Colaborador_Profesion);
                scrollView.Add(txtProfesion);

                scrollView.Add(new STLLabel("Habilidades", 370));
                UITextField txtHabilidades = new STLTextField("Habilidades", 390, colaborador.Colaborador_Habilidades);
                scrollView.Add(txtHabilidades);

                scrollView.Add(new STLLabel("Fecha de Nacimiento", 420));
                UIDatePicker dpFechaNacimiento = new UIDatePicker
                {
                    Mode = UIDatePickerMode.Date,
                    Frame = new CGRect(40, 440, UIScreen.MainScreen.Bounds.Width - 40, 100),
                    Date = DatePickerHelper.GetDate(colaborador.Colaborador_Fecha_Nacimiento)
                };
                scrollView.Add(dpFechaNacimiento);

                scrollView.Add(new STLLabel("Genero", 570));
                UITextField txtGenero = new STLTextField("Genero", 590, colaborador.Genero_Id);
                scrollView.Add(txtGenero);

                scrollView.Add(new STLLabel("Correo Electrónico", 620));
                UITextField txtEmail = new STLTextField("Correo Electrónico", 640, colaborador.Colaborador_Correo_Electronico, UIKeyboardType.EmailAddress);
                scrollView.Add(txtEmail);

                scrollView.Add(new STLLabel("Teléfono", 670));
                UITextField txtTelefono = new STLTextField("Teléfono", 690, colaborador.Colaborador_Telefono, UIKeyboardType.PhonePad);
                scrollView.Add(txtTelefono);

                scrollView.Add(new STLLabel("Celular", 720));
                UITextField txtCelular = new STLTextField("Celular", 740, colaborador.Colaborador_Celular, UIKeyboardType.PhonePad);
                scrollView.Add(txtCelular);


                this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(rightButton, UIBarButtonItemStyle.Plain, (sender, e) =>
                {
                    new ColaboradoresController().AddChangeColaborador(colaborador.Miembro_Empresa_Id, txtNombre.Text, txtApellidos.Text,
                                                                       txtEmail.Text, txtTelefono.Text, txtCelular.Text, txtProfesion.Text,
                                                                       txtPuesto.Text, txtHabilidades.Text, dpFechaNacimiento.Date.ToString(),
                                                                       colaborador.Colaborador_Id);
                }), true);
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 780);
                Add(scrollView);
            }
        }
    }
}