using System;
using UIKit;
using WorklabsMx.Models;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using WorklabsMx.iOS.ViewElements;

namespace WorklabsMx.iOS
{
    public partial class AboutMeModificaController : UIViewController
    {
        UsuarioModel miembro;
        UITableView selectView;
        public AboutMeModificaController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            miembro = new UsuariosController().GetMemberDataAsync(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"));
            Title = "Mi Perfil";

            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {

                scrollView.Add(new STLLabel("Fotografía", 40));

                UIImageView imagen = new STLImageView(70, miembro.Usuario_Fotografia);
                imagen.Image.Scale(new CGSize(50, 50), 0);
                scrollView.Add(imagen);

                UIButton btnPhoto = ImageGallery.SelectPhoto(this, imagen);
                btnPhoto.Frame = new CGRect(20, 130, 220, 30);
                scrollView.Add(btnPhoto);

                scrollView.Add(new STLLabel("Nombre", 170));
                UITextField txtNombre = new STLTextField("Nombre", 200, miembro.Usuario_Nombre);
                scrollView.Add(txtNombre);

                scrollView.Add(new STLLabel("Apellidos", 230));
                UITextField txtApellidos = new STLTextField("Apellidos", 260, miembro.Usuario_Apellidos);
                scrollView.Add(txtApellidos);

                scrollView.Add(new STLLabel("Puesto", 290));
                UITextField txtPuesto = new STLTextField("Puesto", 320, miembro.Usuario_Puesto);
                scrollView.Add(txtPuesto);

                scrollView.Add(new STLLabel("Profesión", 350));
                UITextField txtProfesion = new STLTextField("Profesión", 380, miembro.Usuario_Profesion);
                scrollView.Add(txtProfesion);

                scrollView.Add(new STLLabel("Habilidades", 410));
                UITextField txtHabilidades = new STLTextField("Habilidades", 440, "");
                scrollView.Add(txtHabilidades);

                scrollView.Add(new STLLabel("Fecha de Nacimiento", 470));

                UIDatePicker dpFechaNacimiento = new UIDatePicker
                {
                    Mode = UIDatePickerMode.Date,
                    Frame = new CGRect(40, 500, UIScreen.MainScreen.Bounds.Width - 80, 100),
                    Date = DatePickerHelper.GetDate(miembro.Usuario_Fecha_Nacimiento)
                };

                scrollView.Add(dpFechaNacimiento);

                scrollView.Add(new STLLabel("Genero", 630));
                UITextField txtGenero = new STLTextField("Genero", 660, miembro.Genero.Genero_Descripcion);
                txtGenero.EditingDidBegin += (sender, e) =>
                {
                    selectView = new UIDropdownList(txtGenero, View);
                };
                txtGenero.EditingDidEnd += (sender, e) =>
                {
                    selectView.RemoveFromSuperview();
                };
                scrollView.Add(txtGenero);
                //UITextField txtGenero = new STLTextField("Genero", 590, miembro.Genero_Descripcion);
                //scrollView.Add(txtGenero);

                scrollView.Add(new STLLabel("Correo Electrónico", 720));
                UITextField txtEmail = new STLTextField("Correo Electrónico", 750, miembro.Usuario_Correo_Electronico, UIKeyboardType.EmailAddress);
                scrollView.Add(txtEmail);

                scrollView.Add(new STLLabel("Teléfono", 780));
                UITextField txtTelefono = new STLTextField("Teléfono", 810, miembro.Usuario_Telefono, UIKeyboardType.PhonePad);
                scrollView.Add(txtTelefono);

                scrollView.Add(new STLLabel("Celular", 840));
                UITextField txtCelular = new STLTextField("Celular", 870, miembro.Usuario_Celular, UIKeyboardType.PhonePad);
                scrollView.Add(txtCelular);

                this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Actualizar", UIBarButtonItemStyle.Plain, (sender, e) =>
                {
                    /*if (new UsuariosController().UpdateDataMiembros(Convert.ToInt32(KeyChainHelper.GetKey("Usuario_Id")), txtNombre.Text, txtApellidos.Text, txtEmail.Text,
                                                                   txtTelefono.Text, txtCelular.Text, txtProfesion.Text, txtPuesto.Text, txtHabilidades.Text, (DateTime)dpFechaNacimiento.Date, ""))
                        new MessageDialog().SendToast("Datos guardados");
                    else
                        new MessageDialog().SendToast("Hubo un error\nIntente de nuevo");*/
                }), true);
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 940);
                Add(scrollView);
            }
        }
    }
}