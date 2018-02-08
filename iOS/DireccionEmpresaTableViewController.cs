using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
//using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class DireccionEmpresaTableViewController : UITableViewController
    {

        public EmpresaModel Empresa = new EmpresaModel();
        public string TerritorioId = "";
        public string GiroId;

        //SimpleStorage StoregeLocal;
        List<string> Colonias = new List<string>();
        PickerItemsController Items = new PickerItemsController();

        public DireccionEmpresaTableViewController (IntPtr handle) : base (handle)
        {
            //StoregeLocal = SimpleStorage.EditGroup("Login");
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            this.EventosTecladoTextfileds();
            Empresa = new EmpresaController().GetEmpresaMiembro(KeyChainHelper.GetKey("Usuario_Id"));
            this.txtCalle.Text = Empresa.Empresa_Miembro_Calle;
            this.txtEstado.Text = Empresa.Territorio.Estado;
            this.txtMunicipio.Text = Empresa.Territorio.Municipio;
            this.txtColonia.Text = Empresa.Territorio.Colonia;
            this.txtCodigoPostal.Text = Empresa.Territorio.CP;
            this.LimiteCaracteresTextFields(this.txtCodigoPostal, 5);
            this.txtNumeroExterior.Text = Empresa.Empresa_Miembro_Numero_Exterior;
            this.txtNumeroInterior.Text = Empresa.Empresa_Miembro_Numero_Interior;
            Colonias = Items.GetColonias(Empresa.Territorio.CP);

            if (txtCodigoPostal.Text == "")
            {
                this.btnEditarColonia.Enabled = false;
            }
        }

        partial void btnGuardar(UIBarButtonItem sender)
        {
            this.GuardarCambios();
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }

        /* Acciona eventos para los textfields de ocultar teclado en patalla cuando se presiona la tecla intro, y en le caso de el textfield de contraseña
        se procede a iniciar sesion cuando se presiona la tecla intro */
        private void EventosTecladoTextfileds()
        {
            this.txtCodigoPostal.ShouldReturn += (textField) => {
                this.txtCalle.BecomeFirstResponder();
                return true;
            };

            this.txtCalle.ShouldReturn += (textField) => {
                this.txtEstado.BecomeFirstResponder();
                return true;
            };

            this.txtEstado.ShouldReturn += (textField) => {
                this.txtMunicipio.BecomeFirstResponder();
                return true;
            };

            this.txtMunicipio.ShouldReturn += (textField) => {
                this.txtColonia.BecomeFirstResponder();
                return true;
            };

            this.txtColonia.ShouldReturn += (textField) => {
                this.txtNumeroInterior.BecomeFirstResponder();
                return true;
            };

            this.txtNumeroInterior.ShouldReturn += (textField) => {
                this.txtNumeroExterior.BecomeFirstResponder();
                return true;
            };

            this.txtNumeroExterior.ShouldReturn += (textField) => {
                this.GuardarCambios();
                textField.ResignFirstResponder();
                return true;
            };
        }


        private void GuardarCambios()
        {
            if (InternetConectionHelper.VerificarConexion())
            {
                //TerritorioId = new TerritorioController().GetTerritorioId(txtCodigoPostal.Text, txtColonia.Text);
                if (new EmpresaController().UpdateDataEmpresa(Empresa.Empresa_Miembro_Id, KeyChainHelper.GetKey("Usuario_Id"), GiroId, TerritorioId, Empresa.Empresa_Miembro_Razon_Social, Empresa.Empresa_Miembro_Rfc,
                                                                  Empresa.Empresa_Miembro_Nombre, txtCalle.Text, txtNumeroExterior.Text, txtNumeroInterior.Text, Empresa.Empresa_Miembro_Correo_Electronico, Empresa.Empresa_Miembro_Telefono, Empresa.Empresa_Miembro_Pagina_Web, Empresa.Empresa_Miembro_Red_Social_1, Empresa.Empresa_Miembro_Red_Social_2, Empresa.Empresa_Miembro_Red_Social_3, Empresa.Empresa_Miembro_Logotipo))
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

        //Define el limite de caracteres a escribir en cada cuadro de texto de esta pantalla
        private void LimiteCaracteresTextFields(UITextField TextField, int LongitudMaxima)
        {
            TextField.ShouldChangeCharacters = (textField, range, replacementString) =>
            {
                var newLength = textField.Text.Length + replacementString.Length - range.Length;
                if (newLength == 5)
                {
                    TerritorioModel territorio = new TerritorioController().GetTerritorio(textField.Text + replacementString);
                    TerritorioId = territorio.Territorio_Id;
                    txtEstado.Text = territorio.Estado;
                    txtMunicipio.Text = territorio.Municipio;
                    this.Colonias = Items.GetColonias(territorio.CP);
                    if (this.Colonias.Count != 0)
                    {
                        this.btnEditarColonia.Enabled = true;
                        this.txtColonia.Text = this.Colonias[0];
                    }

                }
                return newLength <= LongitudMaxima;
            };
        }

        partial void btnEditarColonia_TouchupInside(UIButton sender)
        {
            
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "SeleccionarColonia")
            {
                var ColoniaView = (ColoniaViewController)segue.DestinationViewController;
                ColoniaView.ColoniaSeleccionadaDel = this;
                ColoniaView.Colonias = this.Colonias;
            }
        }


    }


    partial class DireccionEmpresaTableViewController : ColoniaSeleccionada
    {
        public void ColoniaSeleccionada(string Colonia)
        {
            this.txtColonia.Text = Colonia;
        }

    }

}