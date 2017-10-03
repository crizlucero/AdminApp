using System;
using UIKit;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using Foundation;
using System.Text.RegularExpressions;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class LoginViewController : UIViewController
    {

        String EmailRegex = "";
        String PassWordRegex = "";

        readonly ConfiguracionesModel configuracionCorreo;
        readonly ConfiguracionesModel configuracionPassword;

        //Constructor
        public LoginViewController(IntPtr handle) : base(handle)
        {
            configuracionCorreo = new ConfigurationsController().GetConfiguraciones("REGEX Y LONGITUD DE CORREO ELECTRONICO DEL USUARIO");
            configuracionPassword = new ConfigurationsController().GetConfiguraciones("REGEX Y LONGITUD DE CONTRASEÑA DEL USUARIO");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationItem.Title = "Iniciar Sesión";
            var localStorage = SimpleStorage.EditGroup("Login");

            localStorage.Put("EmailRegex", configuracionCorreo.Parametro_Varchar_1);
            localStorage.Put("PasswordRegex", configuracionPassword.Parametro_Varchar_1);

            EmailRegex = localStorage.Get("EmailRegex") ?? "No Existe la llave";
            PassWordRegex = localStorage.Get("PasswordRegex") ?? "No Existe la llave";

            localStorage.Delete("Usuario_Id");
            localStorage.Delete("Usuario_Tipo");
            this.EventosTecladoTextfileds();
            this.LimiteCaracteresTextFields(this.txtEmail, int.Parse(configuracionCorreo.Parametro_Varchar_2));
            this.LimiteCaracteresTextFields(this.txtPassword, int.Parse(configuracionPassword.Parametro_Varchar_2));
        }


        void NavigateToTabbed()
        {
            InvokeOnMainThread(() =>
                {
                    var app = (AppDelegate)UIApplication.SharedApplication.Delegate;
                    app.Window.RootViewController = UIStoryboard.FromName("Main", null)
                                                     .InstantiateViewController("splitViewController")
                    as UISplitViewController;
                });
        }

        /* Acciona eventos para los textfields de ocultar teclado en patalla cuando de presiona la tecla intro, y en le caso de el textfield de contraseña
         se procede a iniciar sesion cuando se presiona la tecla intro */
        private void EventosTecladoTextfileds() 
        {
			this.txtEmail.ShouldReturn += (textField) => {
				this.txtPassword.BecomeFirstResponder();
				return true;
			};

			this.txtPassword.ShouldReturn += (textField) => {
				this.AccionIniciarSesion();
				textField.ResignFirstResponder();
				return true;
			};
        }

        //Evento que se ejecuta cuando se toca la pantalla, despues procede a oculytar el teclado
		public override void TouchesBegan(NSSet touches, UIEvent evt)
		{
			base.TouchesBegan(touches, evt);
			UITouch touch = touches.AnyObject as UITouch;
			if (touch != null)
			{
				View.EndEditing(true);
			}
		}

        /* Metodo que realiza el inicio de sesion, se ejecuta cuando el usuario presiona el boton de iniciar sesion o cuando el usuario la tecla intro mientras esta posicionado
         en el cuadro de texto de la contraseña */
        private void AccionIniciarSesion()
        {
			List<string> MiembrosId = new LoginController().MemberLogin(this.txtEmail.Text, new PassSecurity().EncodePassword(this.txtPassword.Text));
 
            bool EmailEsValido = this.ElTextoEsValido(this.txtEmail, EmailRegex);
            bool PasswordEsValido = this.ElTextoEsValido(this.txtPassword, PassWordRegex);

            if (PasswordEsValido && EmailEsValido) {
				if (MiembrosId.Count > 0)
				{
					var localStorage = SimpleStorage.EditGroup("Login");
					localStorage.Put("Usuario_Id", MiembrosId[0]);
					localStorage.Put("Usuario_Tipo", MiembrosId[1]);
					NavigateToTabbed();

				}
				else
				{
					new MessageDialog().SendToast("Correo y/o contraseña incorrecto");
				}
            } else {
                new MessageDialog().SendToast("Asegurese de que el Correo y/o contraseña tengan el formato correcto");
            }

			

		}

        //Define el limite de caracteres a escribir en cada cuadro de texto de esta pantalla
        private void LimiteCaracteresTextFields(UITextField TextField, int LongitudMaxima) 
        {
			TextField.ShouldChangeCharacters = (textField, range, replacementString) =>
			{
				var newLength = textField.Text.Length + replacementString.Length - range.Length;
				return newLength <= LongitudMaxima;
			};
        }

        private Boolean ElTextoEsValido(UITextField TextField, String RegularExpr) 
        {
            bool EsValido = Regex.IsMatch(TextField.Text, RegularExpr);
            return EsValido;
        }

        // Cuando se toca el boton iniciar sesion se desancadena este evento
        partial void BtnIniciarSesion_TouchUpInside(UIButton sender)
        {
            this.AccionIniciarSesion();
        }

        partial void BtnRestaurar_TouchUpInside(UIButton sender)
        {
            string miembro = new LoginController().ValidateMember(txtEmailRecuperar.Text);
            if (miembro.Length > 0)
                new Emails().SendMail(txtEmailRecuperar.Text, miembro, new PassSecurity().GeneraIdentifier());
        }

        partial void BtnRegistro_TouchUpInside(UIButton sender) =>
            UIApplication.SharedApplication.OpenUrl(new NSUrl("http://desarrolloworklabs.com/registro-miembro#registry"));
    }
}
