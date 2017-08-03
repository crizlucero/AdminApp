using Foundation;
using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using System.Collections.Generic;
using WorklabsMx.iOS.Models;

namespace WorklabsMx.iOS
{
    public partial class EmpresaMiembroModificaController : UIViewController
    {
        EmpresaModel empresa;
        public EmpresaMiembroModificaController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Actualizar datos";
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            empresa = new EmpresaController().GetEmpresaMiembro(storageLocal.Get("Miembro_Id"));
            using (var scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                scrollView.Add(new STLLabel("Logotipo", 40));

                UIImageView imagen = new UIImageView
                {
                    Frame = new CGRect(40, 65, 50, 50),
                    Image = ImageGallery.LoadImage(empresa.Empresa_Miembro_Logotipo)
                };
                imagen.Image.Scale(new CGSize(50, 50), 0);
                scrollView.Add(imagen);

                UIButton btnPhoto = ImageGallery.SelectPhoto(this, imagen);
                btnPhoto.Frame = new CGRect(20, 130, 220, 40);

                scrollView.Add(btnPhoto);
                #region Dirección

                scrollView.Add(new STLLabel("Dirección", 170, 20));

                scrollView.Add(new STLLabel("Estado", 200));
                UITextField txtEstado = new STLTextField("Estado", 220, empresa.Territorio_Estado_Descripcion);
                scrollView.Add(txtEstado);

                scrollView.Add(new STLLabel("Municipio", 250));
                UITextField txtMunicipio = new STLTextField("Municipio", 270, empresa.Territorio_Municipio_Descripcion);
                scrollView.Add(txtMunicipio);

                scrollView.Add(new STLLabel("Colonia", 300));
                UIPickerView pckColonia = new UIPickerView
                {
                    Model = new PickerModel(new List<string> { empresa.Territorio_Colonia_Descripcion })
                };
                //UITextField txtColonia = new STLTextField("Colonia", 320, empresa.Territorio_Colonia_Descripcion);
                scrollView.Add(pckColonia);

                scrollView.Add(new STLLabel("Código Postal", 350));
                UITextField txtCP = new STLTextField("Código Postal", 370, empresa.Territorio_Colonia_Descripcion, UIKeyboardType.NumberPad);
                scrollView.Add(txtCP);

                scrollView.Add(new STLLabel("Calle", 400));
                UITextField txtCalle = new STLTextField("Calle", 420, empresa.Empresa_Miembro_Calle);
                scrollView.Add(txtCalle);

                scrollView.Add(new STLLabel("Num. Exterior", 450));
                UITextField txtNumExterior = new STLTextField("Num. Exterior", 470, empresa.Empresa_Miembro_Numero_Exterior);
                scrollView.Add(txtNumExterior);

                scrollView.Add(new STLLabel("Num. Interior", 500));
                UITextField txtNumInterior = new STLTextField("Num. Interior", 520, empresa.Empresa_Miembro_Numero_Interior);
                scrollView.Add(txtNumInterior);

                scrollView.Add(new STLLabel("RFC", 550));
                UITextField txtRFC = new STLTextField("RFC", 570, empresa.Empresa_Miembro_Rfc);
                scrollView.Add(txtRFC);

                scrollView.Add(new STLLabel("Razón social", 600));
                UITextField txtRazonSocial = new STLTextField("Razón Social", 620, empresa.Empresa_Miembro_Razon_Social);
                scrollView.Add(txtRazonSocial);
                #endregion
                #region Contacto
                scrollView.Add(new STLLabel("Contacto", 650, 20));

                scrollView.Add(new STLLabel("Nombre", 680));
                UITextField txtNombre = new STLTextField("Nombre", 700, empresa.Empresa_Miembro_Nombre);
                scrollView.Add(txtNombre);

                scrollView.Add(new STLLabel("Giro Comercial", 730));
                UITextField txtGiroComercial = new STLTextField("Giro Comercial", 750, empresa.Giro_Descripcion);
                scrollView.Add(txtGiroComercial);

                scrollView.Add(new STLLabel("Teléfono", 780));
                UITextField txtTelefono = new STLTextField("Teléfono", 800, empresa.Empresa_Miembro_Telefono, UIKeyboardType.PhonePad);
                scrollView.Add(txtTelefono);

                scrollView.Add(new STLLabel("Correo Electrónico", 830));
                UITextField txtCorreoElectronico = new STLTextField("Correo Electrónico", 850, empresa.Empresa_Miembro_Correo_Electronico, UIKeyboardType.EmailAddress);
                scrollView.Add(txtCorreoElectronico);

                scrollView.Add(new STLLabel("Página Web", 880));
                UITextField txtPaginaWeb = new STLTextField("Página Web", 900, empresa.Empresa_Miembro_Pagina_Web, UIKeyboardType.Url);
                scrollView.Add(txtPaginaWeb);
                #endregion
                #region Redes Sociales
                scrollView.Add(new STLLabel("Redes Sociales", 930, 20));

                new STLImageLabel(scrollView, "Facebook", 960, "ic_facebook");

                UITextField txtFacebook = new STLTextField("Facebook", 990, empresa.Empresa_Miembro_Red_Social_1, UIKeyboardType.Url);
                scrollView.Add(txtFacebook);

                new STLImageLabel(scrollView, "Twitter", 1020, "ic_twitter");
                UITextField txtTwitter = new STLTextField("Twitter", 1050, empresa.Empresa_Miembro_Red_Social_2, UIKeyboardType.Url);
                scrollView.Add(txtTwitter);

                new STLImageLabel(scrollView, "Instagram", 1080, "ic_instagram");
                UITextField txtInstagram = new STLTextField("Instagram", 1110, empresa.Empresa_Miembro_Red_Social_3, UIKeyboardType.Url);
                scrollView.Add(txtInstagram);
                #endregion


                NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Actualizar", UIBarButtonItemStyle.Plain, (sender, e) =>
                {
                    //Actualizar datos
                }), true);

                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 1150);
                Add(scrollView);
            }
        }
    }
}