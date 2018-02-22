using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
//using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;


namespace WorklabsMx.iOS
{



    public partial class EditarRedesSocialesTableViewController : UITableViewController
    {

        public EmpresaModel Empresa = new EmpresaModel();
        public string TerritorioId = "";
        public string GiroId;

        //SimpleStorage StoregeLocal;

        public EditarRedesSocialesTableViewController (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            this.EventosTecladoTextfileds();
            //StoregeLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            //Empresa = new EmpresaController().GetEmpresaMiembro(StoregeLocal.Get("Usuario_Id"));
            Empresa = new EmpresaController().GetEmpresaMiembro(KeyChainHelper.GetKey("Usuario_Id"));
            this.txtPaginaWeb.Text = Empresa.Empresa_Pagina_Web;
            this.txtUsuarioTwitter.Text = Empresa.Empresa_Red_Social_1;
            this.txtUsuarioInstagram.Text = Empresa.Empresa_Red_Social_2;
            this.txtUsuarioFacebook.Text = Empresa.Empresa_Red_Social_3;
        }

        partial void btnGardar(UIBarButtonItem sender)
        {
            this.ActualizarInfo();
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }

        /* Acciona eventos para los textfields de ocultar teclado en patalla cuando se presiona la tecla intro, y en le caso de el textfield de contraseña
        se procede a iniciar sesion cuando se presiona la tecla intro */
        private void EventosTecladoTextfileds()
        {
            this.txtPaginaWeb.ShouldReturn += (textField) => {
                this.txtUsuarioFacebook.BecomeFirstResponder();
                return true;
            };

            this.txtUsuarioFacebook.ShouldReturn += (textField) => {
                this.txtUsuarioTwitter.BecomeFirstResponder();
                return true;
            };

            this.txtUsuarioTwitter.ShouldReturn += (textField) => {
                this.txtUsuarioInstagram.BecomeFirstResponder();
                return true;
            };

            this.txtUsuarioInstagram.ShouldReturn += (textField) => {
                this.ActualizarInfo();
                textField.ResignFirstResponder();
                return true;
            };
        }

        private void ActualizarInfo()
        {
            if (InternetConectionHelper.VerificarConexion())
            {
                if (new EmpresaController().UpdateDataEmpresa(Empresa.Empresa_Id, KeyChainHelper.GetKey("Usuario_Id"), GiroId, TerritorioId, Empresa.Empresa_Razon_Social, Empresa.Empresa_Rfc,Empresa.Empresa_Nombre, Empresa.Empresa_Calle, Empresa.Empresa_Numero_Exterior, Empresa.Empresa_Numero_Interior, Empresa.Empresa_Correo_Electronico, Empresa.Empresa_Telefono, this.txtPaginaWeb.Text, this.txtUsuarioTwitter.Text, this.txtUsuarioInstagram.Text, this.txtUsuarioFacebook.Text, Empresa.Empresa_Logotipo))
                {
                    new MessageDialog().SendToast("Datos guardados"); 

                    this.TableView.ReloadData();
                }
                else
                {
                    new MessageDialog().SendToast("Hubo un error\nIntente de nuevo");
                }
                    
            }
            else
            {
                new MessageDialog().SendToast("No tienes conexión a internet, intenta mas tarde");
            }
        }
    }
}