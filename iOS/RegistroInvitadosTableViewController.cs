using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using System.Text.RegularExpressions;

namespace WorklabsMx.iOS
{
    public partial class RegistroInvitadosTableViewController : UITableViewController
    {
        List<MiembroModel> invitados;
        List<SucursalModel> sucursales = new SucursalController().GetSucursales();
        String EmailRegex = "";
        string DomicilioInvitacion = "";

        public RegistroInvitadosTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            EmailRegex = KeyChainHelper.GetKey("EmailRegex");
            invitados = new List<MiembroModel>();
            //this.CrearInvitado();
            txtApellido.AttributedPlaceholder = new NSAttributedString("APELLIDO", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
            txtNombre.AttributedPlaceholder = new NSAttributedString("NOMBRE", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
            txtEmail.AttributedPlaceholder = new NSAttributedString("EMAIL", new UIStringAttributes { ForegroundColor = UIColor.Clear.FromHex(0x848484) });
            NSDateFormatter dateFormat = new NSDateFormatter();
            dateFormat.DateFormat = "E, d MMM yyyy HH:mm";
            this.lblFecha.Text = dateFormat.ToString((NSDate)DateTime.Now);
            this.lblUbicacion.Text = sucursales[0].Sucursal_Descripcion;

            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.txtNombre.ShouldReturn += (textField) => {
                this.txtApellido.BecomeFirstResponder();
                return true;
            };

            this.txtApellido.ShouldReturn += (textField) => {
                this.txtEmail.BecomeFirstResponder();
                return true;
            };


            this.txtEmail.ShouldReturn += (textField) => {
                textField.ResignFirstResponder();
                return true;
            };
        }

        partial void btnAñadir_Touch(UIButton sender)
        {
            TableView.BeginUpdates();
            //CrearInvitado();
            NSIndexPath newIndexPath = NSIndexPath.FromRowSection(invitados.Count - 1, 0);
            TableView.InsertRows (new NSIndexPath[]{newIndexPath}, withRowAnimation: UITableViewRowAnimation.Automatic);
            TableView.EndUpdates();
        }


        partial void btnFecha_Tocuh(UIButton sender)
        {
            this.PerformSegue("SeleccionarFecha", null);
        }

        partial void btnUbicacion_Touch(UIButton sender)
        {
            this.PerformSegue("sucursales", null);
        }

        partial void btnEnviarInvitacion_Touch(UIButton sender)
        {
            var CamposVacios = false;
            var ErrorInvitar = false;

           // foreach (MiembroModel invitado in invitados)
            //{
                if ((txtNombre.Text/*invitado.Miembro_Nombre*/ != "" && txtApellido.Text /*invitado.Miembro_Apellidos*/ != "" && txtEmail.Text /*invitado.Miembro_Correo_Electronico*/ != ""))
                {

                    bool EmailEsValido = this.ElTextoEsValido(this.txtEmail, EmailRegex);

                    if(EmailEsValido)
                    {
                        var Sucursal = sucursales.Find(x => x.Sucursal_Descripcion == lblUbicacion.Text);
                        if (InternetConectionHelper.VerificarConexion())
                        {
                            if (new InvitadosController().RegistraInvitado(txtNombre.Text /*invitado.Miembro_Nombre*/, txtApellido.Text /*invitado.Miembro_Apellidos*/, txtEmail.Text /*invitado.Miembro_Correo_Electronico*/, txtAsunto.Text, DateTime.Parse(lblFecha.Text), Sucursal.Sucursal_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo")) != -1)
                            {
                                ErrorInvitar = false;
                                this.CrearInvitado();
                                this.DomicilioInvitacion = Sucursal.Sucursal_Descripcion + " " + Sucursal.Sucursal_Domicilio;
                            }
                            else
                            {
                                ErrorInvitar = true;
                                //break;
                            }
                        }
                        else
                        {
                            ErrorInvitar = true;
                            //break;
                        }
                    }
                    else
                    {
                        
                    }

                    CamposVacios = false;
                }
                else
                {
                    CamposVacios = true;
                    //break;
                }
            //}
            if(CamposVacios)
            {
                new MessageDialog().SendToast("Favor de llenar todos los campos");

            }
            else if (ErrorInvitar)
            {
                new MessageDialog().SendToast("No se pudieron enviar las invitaciones, intente de nuevo");
            } else
            {
                this.PerformSegue("DetalleInvitacion", null);
            }
        }

        private Boolean ElTextoEsValido(UITextField TextField, String RegularExpr)
        {
            bool EsValido = Regex.IsMatch(TextField.Text, RegularExpr);
            return EsValido;
        }

       /* public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                return invitados.Count;
            }
            else
            {
                return 2;
            }

        }*/


        partial void btnMenuInvitados_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SeleccionarFecha")
            {
                var GenderView = (FechaReservacionPickerViewController)segue.DestinationViewController;
                GenderView.FechaSeleccionadaDelegate = this;
                GenderView.FromRegister = true;
            }
            else if (segue.Identifier == "sucursales")
            {
                var GenderView = (SucursalesViewController)segue.DestinationViewController;
                GenderView.SucursalSeleccionadaDel = this;
            }
            else if (segue.Identifier == "DetalleInvitacion")
            {
                var GenderView = (DetalleInvitacionViewController)segue.DestinationViewController;
                GenderView.Invitados = this.invitados;
                GenderView.DomicilioInvitacion = this.DomicilioInvitacion;
            }

        }

        private void CrearInvitado()
        {
            MiembroModel invitado = new MiembroModel();
            invitado.Miembro_Nombre = txtNombre.Text;
            invitado.Miembro_Apellidos = txtApellido.Text;
            invitado.Miembro_Correo_Electronico = txtEmail.Text;
            invitado.Miembro_Fecha_Registro = this.lblFecha.Text;
            invitados.Add(invitado);

        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }


    }



    partial class RegistroInvitadosTableViewController : FechaReservaSeleccionada
    {
        public void FechaReservaSeleccionada(String FechaReservacion)
        {
            this.lblFecha.Text = FechaReservacion;
           
        }
    }

    partial class RegistroInvitadosTableViewController : SucursalSeleccionada
    {
        public void SucursalSeleccionada(String Sucursal)
        {

            this.lblUbicacion.Text = Sucursal;

        }
    }
}