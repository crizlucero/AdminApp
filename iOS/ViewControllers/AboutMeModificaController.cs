using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using CoreGraphics;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class AboutMeModificaController : UIViewController
    {
        MiembroModel miembro;
        ImageGallery selectImage;
        public AboutMeModificaController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Actualizar datos";
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            miembro = new MiembrosController().GetMemberData(storageLocal.Get("Miembro_Id"));
            this.Title = "Mi Perfil";

            var scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));

            scrollView.Add(new STLLabel("Fotografía", 40));

            UIImageView imagen = new STLImageView(65, miembro.Miembro_Fotografia);
            imagen.Image.Scale(new CGSize(50, 50), 0);
            scrollView.Add(imagen);

            UIButton btnPhoto = ImageGallery.SelectPhoto(this, imagen, selectImage); 
            btnPhoto.Frame = new CGRect(20, 130, 220, 30);
            scrollView.Add(btnPhoto);

            scrollView.Add(new STLLabel("Nombre",170));
            UITextField txtNombre = new STLTextField("Nombre", 190, miembro.Miembro_Nombre);
            scrollView.Add(txtNombre);

            scrollView.Add(new STLLabel ("Apellidos", 220) );
            UITextField txtApellidos = new STLTextField("Apellidos", 240,miembro.Miembro_Apellidos);
            scrollView.Add(txtApellidos);

            scrollView.Add(new STLLabel("Puesto",270));
            UITextField txtPuesto = new STLTextField("Puesto", 290,miembro.Miembro_Puesto);
            scrollView.Add(txtPuesto);

            scrollView.Add(new STLLabel("Profesión", 320));
            UITextField txtProfesion = new STLTextField("Profesión", 340, miembro.Miembro_Profesion);
            scrollView.Add(txtProfesion);

            scrollView.Add(new STLLabel("Habilidades",370));
            UITextField txtHabilidades = new STLTextField("Habilidades", 390, miembro.Miembro_Habilidades);
            scrollView.Add(txtHabilidades);

            scrollView.Add(new STLLabel("Fecha de Nacimiento", 420));
            UIDatePicker dpFechaNacimiento = new UIDatePicker
            {
                Mode = UIDatePickerMode.Date,
                Frame = new CGRect(40, 440, UIScreen.MainScreen.Bounds.Width - 40, 100),
                //Date = (NSDate)Convert.ToDateTime(miembro.Miembro_Fecha_Nacimiento)
            };
            scrollView.Add(dpFechaNacimiento);

            scrollView.Add(new STLLabel("Genero", 570));
            UITextField txtGenero = new STLTextField("Genero", 590, miembro.Genero_Descripcion);
            scrollView.Add(txtGenero);

            scrollView.Add(new STLLabel("Correo Electrónico", 620));
            UITextField txtEmail = new STLTextField("Correo Electrónico", 640, miembro.Miembro_Correo_Electronico, UIKeyboardType.EmailAddress);
            scrollView.Add(txtEmail);

            scrollView.Add(new STLLabel("Teléfono", 670));
            UITextField txtTelefono = new STLTextField("Teléfono",690,miembro.Miembro_Telefono,UIKeyboardType.PhonePad);
            scrollView.Add(txtTelefono);

            scrollView.Add(new STLLabel("Celular", 720));
            UITextField txtCelular = new STLTextField("Celular", 740, miembro.Miembro_Celular, UIKeyboardType.PhonePad);
            scrollView.Add(txtCelular);


            this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Actualizar", UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                //Actualizar datos
            }), true);
            scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 780);
            Add(scrollView);
        }
    }
}