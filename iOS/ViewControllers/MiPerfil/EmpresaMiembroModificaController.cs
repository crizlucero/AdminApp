using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using System.Collections.Generic;
using WorklabsMx.iOS.Models;
//using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class EmpresaMiembroModificaController : UIViewController
    {
        EmpresaModel empresa;
        UITableView selectView;
        UITextField txtEstado, txtMunicipio, txtColonia, txtCP, txtGiroComercial;
        string territorio_id, empresa_id, giro_id;
        List<string> colonias;
        //SimpleStorage storageLocal;
        PickerItemsController items;
        public EmpresaMiembroModificaController(IntPtr handle) : base(handle)
        {
            items = new PickerItemsController();
            //storageLocal = SimpleStorage.EditGroup("Login");
            empresa = new EmpresaController().GetEmpresaMiembro(KeyChainHelper.GetKey("Usuario_Id"));
            TerritorioModel territorio = new TerritorioController().GetTerritorio(empresa.Territorio.CP);
            empresa_id = empresa.Empresa_Miembro_Id;
            territorio_id = territorio.Territorio_Id;
            colonias = items.GetColonias(territorio.CP);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

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
                txtEstado = new STLTextField("Estado", 230, empresa.Territorio.Estado)
                {
					Enabled = false,
					TextColor = UIColor.Gray
                };
                scrollView.Add(txtEstado);

                scrollView.Add(new STLLabel("Municipio", 260));
                txtMunicipio = new STLTextField("Municipio", 290, empresa.Territorio.Municipio){
					Enabled = false,
					TextColor = UIColor.Gray
                };
                scrollView.Add(txtMunicipio);

                scrollView.Add(new STLLabel("Colonia", 320));
                txtColonia = new STLTextField("Colonia", 350, empresa.Territorio.Colonia);
                txtColonia.EditingDidBegin += (sender, e) =>
                {
                    //selectView = new UIDropdownList(txtColonia, scrollView, colonias);
                    selectView = new STLDropDownList(colonias, txtColonia);
                    View.AddSubview(selectView);
                };
                txtColonia.EditingDidEnd += (sender, e) =>
                {
                    territorio_id = GetTerritorioId();
                    selectView.RemoveFromSuperview();
                };
                scrollView.Add(txtColonia);

                scrollView.Add(new STLLabel("Código Postal", 380));
                txtCP = new STLTextField("Código Postal", 410, empresa.Territorio.CP, UIKeyboardType.NumberPad);
                txtCP.EditingChanged += TxtCP_EditingChanged;
                scrollView.Add(txtCP);

                scrollView.Add(new STLLabel("Calle", 440));
                UITextField txtCalle = new STLTextField("Calle", 470, empresa.Empresa_Miembro_Calle);
                scrollView.Add(txtCalle);

                scrollView.Add(new STLLabel("Num. Exterior", 500));
                UITextField txtNumExterior = new STLTextField("Num. Exterior", 530, empresa.Empresa_Miembro_Numero_Exterior);
                scrollView.Add(txtNumExterior);

                scrollView.Add(new STLLabel("Num. Interior", 560));
                UITextField txtNumInterior = new STLTextField("Num. Interior", 590, empresa.Empresa_Miembro_Numero_Interior);
                scrollView.Add(txtNumInterior);

                scrollView.Add(new STLLabel("RFC", 620));
                UITextField txtRFC = new STLTextField("RFC", 650, empresa.Empresa_Miembro_Rfc){
					Enabled = false,
					TextColor = UIColor.Gray
                };
                scrollView.Add(txtRFC);

                scrollView.Add(new STLLabel("Razón social", 680));
                UITextField txtRazonSocial = new STLTextField("Razón Social", 710, empresa.Empresa_Miembro_Razon_Social){
					Enabled = false,
					TextColor = UIColor.Gray
                };
                scrollView.Add(txtRazonSocial);
                #endregion
                #region Contacto
                scrollView.Add(new STLLabel("Contacto", 750, 20));

                scrollView.Add(new STLLabel("Nombre", 780));
                UITextField txtNombre = new STLTextField("Nombre", 810, empresa.Empresa_Miembro_Nombre);
                scrollView.Add(txtNombre);

                scrollView.Add(new STLLabel("Giro Comercial", 840));
                txtGiroComercial = new STLTextField("Giro Comercial", 870, empresa.Giro_Descripcion);
                txtGiroComercial.EditingDidBegin += (sender, e) =>
                {
                    selectView = new STLDropDownList(colonias, txtGiroComercial);
                    View.AddSubview(selectView);
                };
                txtGiroComercial.EditingDidEnd += (sender, e) =>
                {
                    giro_id = GetGiroId();
                    selectView.RemoveFromSuperview();
                };
                scrollView.Add(txtGiroComercial);

                scrollView.Add(new STLLabel("Teléfono", 900));
                UITextField txtTelefono = new STLTextField("Teléfono", 930, empresa.Empresa_Miembro_Telefono, UIKeyboardType.PhonePad);
                scrollView.Add(txtTelefono);

                scrollView.Add(new STLLabel("Correo Electrónico", 960));
                UITextField txtCorreoElectronico = new STLTextField("Correo Electrónico", 990, empresa.Empresa_Miembro_Correo_Electronico, UIKeyboardType.EmailAddress);
                scrollView.Add(txtCorreoElectronico);

                scrollView.Add(new STLLabel("Página Web", 1020));
                UITextField txtPaginaWeb = new STLTextField("Página Web", 1050, empresa.Empresa_Miembro_Pagina_Web, UIKeyboardType.Url);
                scrollView.Add(txtPaginaWeb);
                #endregion
                #region Redes Sociales
                scrollView.Add(new STLLabel("Redes Sociales", 1080, 20));

                new STLImageLabel(scrollView, "Facebook", 1110, "ic_facebook");

                UITextField txtFacebook = new STLTextField("Facebook", 1140, empresa.Empresa_Miembro_Red_Social_1, UIKeyboardType.Url);
                scrollView.Add(txtFacebook);

                new STLImageLabel(scrollView, "Twitter", 1170, "ic_twitter");
                UITextField txtTwitter = new STLTextField("Twitter", 1200, empresa.Empresa_Miembro_Red_Social_2, UIKeyboardType.Url);
                scrollView.Add(txtTwitter);

                new STLImageLabel(scrollView, "Instagram", 1230, "ic_instagram");
                UITextField txtInstagram = new STLTextField("Instagram", 1260, empresa.Empresa_Miembro_Red_Social_3, UIKeyboardType.Url);
                scrollView.Add(txtInstagram);
                #endregion

                NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Actualizar", UIBarButtonItemStyle.Plain, (sender, e) =>
                {
                    if (new EmpresaController().UpdateDataEmpresa(empresa.Empresa_Miembro_Id, KeyChainHelper.GetKey("Usuario_Id"), giro_id, territorio_id, txtRazonSocial.Text, txtRFC.Text,
                                                              txtNombre.Text, txtCalle.Text, txtNumExterior.Text, txtNumInterior.Text, txtCorreoElectronico.Text, txtTelefono.Text,
                                                                 txtPaginaWeb.Text, txtFacebook.Text, txtTwitter.Text, txtInstagram.Text, ""))
                        new MessageDialog().SendToast("Datos guardados");
                    else
                        new MessageDialog().SendToast("Hubo un error\nIntente de nuevo");
                }), true);

                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 1300);
                Add(scrollView);
            }
            giro_id = GetGiroId();
        }
        void TxtCP_EditingChanged(object sender, EventArgs e)
        {
            if (((UITextField)sender).Text.Length == 5)
            {
                TerritorioModel territorio = new TerritorioController().GetTerritorio(((UITextField)sender).Text);
                territorio_id = territorio.Territorio_Id;
                txtEstado.Text = territorio.Estado;
                txtMunicipio.Text = territorio.Municipio;
                colonias = items.GetColonias(territorio.CP);
            }
        }
        string GetTerritorioId() => new TerritorioController().GetTerritorioId(txtCP.Text, txtColonia.Text);

        string GetGiroId() => items.GetGiroId(txtGiroComercial.Text).ToString();
    }
}