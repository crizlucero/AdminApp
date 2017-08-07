using System;
using UIKit;
using WorklabsMx.Models;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class AboutMeModificaController : UIViewController
    {
        MiembroModel miembro;
        public AboutMeModificaController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Actualizar datos";
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            miembro = new MiembrosController().GetMemberData(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));
            Title = "Mi Perfil";

            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {

                scrollView.Add(new STLLabel("Fotografía", 40));

                UIImageView imagen = new STLImageView(70, miembro.Miembro_Fotografia);
                imagen.Image.Scale(new CGSize(50, 50), 0);
                scrollView.Add(imagen);

                UIButton btnPhoto = ImageGallery.SelectPhoto(this, imagen);
                btnPhoto.Frame = new CGRect(20, 130, 220, 30);
                scrollView.Add(btnPhoto);

                scrollView.Add(new STLLabel("Nombre", 170));
                UITextField txtNombre = new STLTextField("Nombre", 200, miembro.Miembro_Nombre);
                scrollView.Add(txtNombre);

                scrollView.Add(new STLLabel("Apellidos", 230));
                UITextField txtApellidos = new STLTextField("Apellidos", 260, miembro.Miembro_Apellidos);
                scrollView.Add(txtApellidos);

                scrollView.Add(new STLLabel("Puesto", 290));
                UITextField txtPuesto = new STLTextField("Puesto", 320, miembro.Miembro_Puesto);
                scrollView.Add(txtPuesto);

                scrollView.Add(new STLLabel("Profesión", 350));
                UITextField txtProfesion = new STLTextField("Profesión", 380, miembro.Miembro_Profesion);
                scrollView.Add(txtProfesion);

                scrollView.Add(new STLLabel("Habilidades", 410));
                UITextField txtHabilidades = new STLTextField("Habilidades", 440, miembro.Miembro_Habilidades);
                scrollView.Add(txtHabilidades);

                scrollView.Add(new STLLabel("Fecha de Nacimiento", 470));

                UIDatePicker dpFechaNacimiento = new UIDatePicker
                {
                    Mode = UIDatePickerMode.Date,
                    Frame = new CGRect(40, 500, UIScreen.MainScreen.Bounds.Width - 40, 100),
                    Date = DatePickerHelper.GetDate(miembro.Miembro_Fecha_Nacimiento)
                };

                scrollView.Add(dpFechaNacimiento);

                scrollView.Add(new STLLabel("Genero", 630));
                PickerDataModel mdlGenero = new PickerDataModel();
                foreach (string pck in new PickerItemsController().GetGeneros())
                {
                    mdlGenero.Items.Add(pck);
                }
                UIPickerView pckGenero = new UIPickerView
                {
                    Frame = new CGRect(30, 660, UIScreen.MainScreen.Bounds.Width, 50),
                    Model = mdlGenero
                };
                pckGenero.Select(Convert.ToInt32(miembro.Genero_Id) - 1, 0, true);
                scrollView.Add(pckGenero);
                //UITextField txtGenero = new STLTextField("Genero", 590, miembro.Genero_Descripcion);
                //scrollView.Add(txtGenero);

                scrollView.Add(new STLLabel("Correo Electrónico", 720));
                UITextField txtEmail = new STLTextField("Correo Electrónico", 750, miembro.Miembro_Correo_Electronico, UIKeyboardType.EmailAddress);
                scrollView.Add(txtEmail);

                scrollView.Add(new STLLabel("Teléfono", 780));
                UITextField txtTelefono = new STLTextField("Teléfono", 810, miembro.Miembro_Telefono, UIKeyboardType.PhonePad);
                scrollView.Add(txtTelefono);

                scrollView.Add(new STLLabel("Celular", 840));
                UITextField txtCelular = new STLTextField("Celular", 870, miembro.Miembro_Celular, UIKeyboardType.PhonePad);
                scrollView.Add(txtCelular);


                this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Actualizar", UIBarButtonItemStyle.Plain, (sender, e) =>
                {
                    //Actualizar datos
                }), true);
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 940);
                Add(scrollView);
            }
        }
    }
}