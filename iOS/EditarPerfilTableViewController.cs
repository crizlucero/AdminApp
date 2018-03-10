using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using Foundation;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Enum;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{

    public interface EventosEditarPerfil
    {
        void MiInfo(UsuarioModel InfoActualizar);
    }

    public partial class EditarPerfilTableViewController : UITableViewController
    {
        UIImagePickerController imgPicker;

        public EventosEditarPerfil MiInfoDeleghate;

        bool TouchedBack = false, TouchedProfile = false;

        bool FromMi = true, FromSocial = false, FromTrabajo = false;

        public UsuarioModel InfoPerifl;

        public UsuarioModel NewInfoPerfil = new UsuarioModel();

        EmpresaModel NuevosDatosEmpresa = new EmpresaModel();

        List<RedSocialModel> NewRedesSociales = new List<RedSocialModel>();

        public EditarPerfilTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            NewRedesSociales = InfoPerifl.Redes_Sociales;
            NewInfoPerfil = InfoPerifl;
            imgPicker = new UIImagePickerController();
            imgPicker.Delegate = this;
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
            UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
            if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
            {
                statusBar.BackgroundColor = UIColor.Black;
            }
            UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;

            this.txtNombre.AttributedPlaceholder = new NSAttributedString("  Nombre", null, UIColor.Clear.FromHex(0x767676));
            txtNombre.Text = InfoPerifl.Usuario_Nombre;// + " " + InfoPerifl.Usuario_Apellidos;

            this.txtApellidos.AttributedPlaceholder = new NSAttributedString("  Nombre", null, UIColor.Clear.FromHex(0x767676));
            txtApellidos.Text = InfoPerifl.Usuario_Apellidos;

            lblEmpresa.Text = (InfoPerifl.Usuario_Empresa_Nombre != "" && InfoPerifl.Usuario_Empresa_Nombre != null) ? InfoPerifl.Usuario_Empresa_Nombre : "Sin Info";
            NewInfoPerfil.Usuario_Empresa_Nombre = lblEmpresa.Text;


            await GetImages();

            this.vwVistaMi.Hidden = false;
            this.vwSocial.Hidden = true;
            this.vwTrabajo.Hidden = true;
        }


        async Task GetImages()
        {
            UIImage ReescalImageBack = new UIImage();
            UIImage ReescalImageUsr = new UIImage();
            await Task.Run(() =>
            {

                if ((NewInfoPerfil.Usuario_Fotografia != "" && NewInfoPerfil.Usuario_Fotografia != null && NewInfoPerfil.Usuario_Fotografia != "user_male.png"))
                {
                    if (NewInfoPerfil.Usuario_Fotografia_Perfil == null)
                    {
                            NewInfoPerfil.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(NewInfoPerfil.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                       
                    }
                    else if (NewInfoPerfil.Usuario_Fotografia_Perfil.Length == 0)
                    {
   
                            NewInfoPerfil.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(NewInfoPerfil.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                    }
                    var data = NSData.FromArray(NewInfoPerfil.Usuario_Fotografia_Perfil);
                    var uiimage = UIImage.LoadFromData(data);
                    ReescalImageUsr = ImageHelper.ReescalProfileImage(uiimage);

                }
                else
                {
                    ReescalImageUsr = UIImage.FromBundle("ProfileImageBig");
                }


                if (NewInfoPerfil.Usuario_Fotografia_Fondo != null && NewInfoPerfil.Usuario_Fotografia_Fondo != "")
                {
                    if (NewInfoPerfil.Usuario_Fotografia_FondoPerfil == null)
                    {
                        NewInfoPerfil.Usuario_Fotografia_FondoPerfil = new UploadImages().DownloadFileFTP(NewInfoPerfil.Usuario_Fotografia_Fondo, MenuHelper.ProfileImagePath);
                    }
                    else if (NewInfoPerfil.Usuario_Fotografia_FondoPerfil.Length == 0)
                    {
                        NewInfoPerfil.Usuario_Fotografia_FondoPerfil = new UploadImages().DownloadFileFTP(NewInfoPerfil.Usuario_Fotografia_Fondo, MenuHelper.ProfileImagePath);
                    }
                    var data = NSData.FromArray(NewInfoPerfil.Usuario_Fotografia_FondoPerfil);
                    var uiimage = UIImage.LoadFromData(data);
                    ReescalImageBack = ImageHelper.ReescalProfileImage(uiimage);
                }

            });
            this.btnImagen.SetBackgroundImage(ReescalImageUsr, UIControlState.Normal);
            this.btnFondoImagen.SetBackgroundImage(ReescalImageBack, UIControlState.Normal);
        }

        private UIImage GetImage(byte[] Imagen)
        {
            if (Imagen != null)
            {
                var data = NSData.FromArray(Imagen);
                var uiimage = UIImage.LoadFromData(data);
                return uiimage;
            }
            return null;
        }

        partial void FondoImagen_Touch(UIButton sender)
        {
            TouchedBack = true;
            PresentViewController(CrearActionSheet(), true, null);
        }

        partial void btnImagen_Touch(UIButton sender)
        {
            TouchedProfile = true;
            PresentViewController(CrearActionSheet(), true, null);
        }


        partial void btnClose_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }


        private UIAlertController CrearActionSheet()
        {
            var ShowGalleryAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);

            ShowGalleryAlert.AddAction(this.AbrirGaleria(this.imgPicker));
            ShowGalleryAlert.AddAction(this.AbrirCamara(this.imgPicker));

            var CloseAction = UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel,(action) =>
            {
                this.TouchedBack = false;
                this.TouchedProfile = false;
            });
            ShowGalleryAlert.AddAction(CloseAction);
            return ShowGalleryAlert;

        }

        [Foundation.Export("imagePickerController:didFinishPickingImage:editingInfo:")]
        public void FinishedPickingImage(UIKit.UIImagePickerController picker, UIKit.UIImage image, Foundation.NSDictionary editingInfo)
        {
            if (this.TouchedBack)
            {

                image = ImageHelper.ReescalProfileBackImage(image);
                this.btnFondoImagen.SetBackgroundImage(image, UIControlState.Normal);
                NewInfoPerfil.Usuario_Fotografia_FondoPerfil = image?.AsPNG().ToArray();
            }
            else if (this.TouchedProfile)
            {
                image = ImageHelper.ReescalProfileImage(image);
                this.btnImagen.SetBackgroundImage(image, UIControlState.Normal);
                NewInfoPerfil.Usuario_Fotografia_Perfil = image?.AsPNG().ToArray();
            }
            this.TouchedBack = false;
            this.TouchedProfile = false;
            picker.DismissViewController(true, null);
        }

        [Foundation.Export("imagePickerControllerDidCancel:")]
        public void Canceled(UIKit.UIImagePickerController picker)
        {
            picker.DismissViewController(true, null);
        }

        private UIImagePickerController SelectImage(UIImagePickerController ImagePicker)
        {
            ImagePicker.AllowsEditing = false;
            ImagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            ImagePicker.AllowsEditing = true;
            return ImagePicker;
        }

        private UIAlertAction AbrirCamara(UIImagePickerController ImagePicker)
        {
            const String HeaderMessage = "Se necesita acceso a la camara";
            const String BodyMessage = "Habilita el acceso de Worklabs a la camara en la configuración de tu iPhone";

            UIAlertAction openCamera = UIAlertAction.Create("Tomar fotografia", UIAlertActionStyle.Default, (action) =>
            {
                AVCaptureDevice.RequestAccessForMediaType(AVMediaType.Video, (bool isAccessGranted) =>
                {
                    InvokeOnMainThread(() =>
                    {
                        try
                        {
                            if (isAccessGranted)
                            {
                                ImagePicker.SourceType = UIImagePickerControllerSourceType.Camera;
                                ImagePicker.CameraDevice = UIImagePickerControllerCameraDevice.Rear;
                                ImagePicker.AllowsEditing = true;
                                this.PresentViewController(ImagePicker, true, null);
                            }
                            else
                            {
                                this.PresentViewController(this.PermisosDispositivo(HeaderMessage, BodyMessage), true, null);
                            }
                        }
                        catch (Exception e)
                        {
                            SlackLogs.SendMessage(e.Message);
                        }

                    });
                });

            });

            return openCamera;
        }



        private UIAlertAction AbrirGaleria(UIImagePickerController ImagePicker)
        {
            const String HeaderMessage = "Se necesita acceso a la galería";
            const String BodyMessage = "Habilita el acceso de Worklabs a la galería en la configuración de tu iPhone";
            UIAlertAction openGalery = UIAlertAction.Create("Selecciona una foto", UIAlertActionStyle.Default, (action) =>
            {
                var photos = PHPhotoLibrary.AuthorizationStatus;
                if (photos != PHAuthorizationStatus.NotDetermined)
                {
                    this.PresentViewController(this.SelectImage(ImagePicker), true, null);
                }
                else
                {
                    PHPhotoLibrary.RequestAuthorization(handler: (obj) =>
                    {
                        InvokeOnMainThread(() =>
                        {
                            if (obj != PHAuthorizationStatus.Authorized)
                            {
                                this.PresentViewController(this.PermisosDispositivo(HeaderMessage, BodyMessage), true, null);
                            }
                            else
                            {
                                this.PresentViewController(this.SelectImage(ImagePicker), true, null);
                            }
                        });
                    });
                }
            });
            return openGalery;
        }

        private UIAlertController PermisosDispositivo(String headerMessage, String BodyMessage)
        {
            var alert = UIAlertController.Create(headerMessage, BodyMessage, UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Aceptar", UIAlertActionStyle.Default, (Action) =>
            {
                this.openSettings();
            }));
            alert.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Default, null));
            return alert;
        }

        private void openSettings()
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
        }

        partial void btnSocial_Touch(UIButton sender)
        {
            this.vwVistaMi.Hidden = true;
            this.vwSocial.Hidden = false;
            this.vwTrabajo.Hidden = true;
            this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromMi)
            {
                this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwVistaMi.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
            }
            else if (FromTrabajo)
            {
                this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            this.FromMi = false;
            this.FromSocial = true;
            this.FromTrabajo = false;
        }

        partial void btnSobreMi_Touch(UIButton sender)
        {
            this.vwVistaMi.Hidden = false;
            this.vwSocial.Hidden = true;
            this.vwTrabajo.Hidden = true;
            this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwVistaMi.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromSocial)
            {
                this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
                this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xF4F4F4);
            }
            else if (FromTrabajo)
            {
                this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            this.FromMi = true;
            this.FromSocial = false;
            this.FromTrabajo = false;
        }

         partial  void btnTrabajo_Touch(UIButton sender)
        {
            this.vwVistaMi.Hidden = true;
            this.vwSocial.Hidden = true;
            this.vwTrabajo.Hidden = false;
            this.btnTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            this.btnTrabajo.SetTitleColor(UIColor.Clear.FromHex(0x63B4EA), UIControlState.Normal);
            this.vwTrabajo.BackgroundColor = UIColor.Clear.FromHex(0xFFFFFF);
            if (FromMi)
            {
                this.btnSobreMi.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnSobreMi.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwVistaMi.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            else if (FromSocial)
            {
                this.btnSocial.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
                this.btnSocial.SetTitleColor(UIColor.Clear.FromHex(0x767676), UIControlState.Normal);
                this.vwSocial.BackgroundColor = UIColor.Clear.FromHex(0xE6E6E6);
            }
            this.FromMi = false;
            this.FromSocial = false;
            this.FromTrabajo = true;
        }

        partial void btnGuardar_Touch(UIButton sender)
        {
            NewInfoPerfil.Usuario_Nombre = txtNombre.Text;
            NewInfoPerfil.Usuario_Apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = new DateTime();
            fechaNacimiento = DateTime.Parse(NewInfoPerfil.Usuario_Fecha_Nacimiento);
            int resultRedesSociales = -1;
            int resultEtiquetas = -1;
            bool resultadoTrabajo = false;
            bool resultDataMiembros = false;

            if(NewInfoPerfil.Etiquetas != null)
            {
                if(NewInfoPerfil.Etiquetas.Count > 0)
                {
                    foreach (EtiquetaModel Etiqueta in NewInfoPerfil.Etiquetas)
                    {
                        if ((Etiqueta.Etiqueta_Nombre != "" && Etiqueta.Etiqueta_Nombre != null) && (Etiqueta.Etiqueta_Id == "" || Etiqueta.Etiqueta_Id == null))
                        {
                            TipoEtiquetas etiqueta_tipo;
                            if (Etiqueta.Etiqueta_Tipo == "Habilidad")
                            {
                                etiqueta_tipo = TipoEtiquetas.Habilidad;

                            }
                            else
                            {
                                etiqueta_tipo = TipoEtiquetas.Interes;
                            }
                            resultEtiquetas = new UsuariosController().AddRemoveEtiquetas(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), Etiqueta.Etiqueta_Id, Etiqueta.Etiqueta_Nombre, etiqueta_tipo, Etiqueta.Usuario_Etiqueta_Id);
                        }
                        else 
                        {
                            resultEtiquetas = 1;
                        }
                    }
                }
                else
                {
                    resultEtiquetas = 1;
                }

            }
            else
            {
                resultEtiquetas = 1;
            }

            if (NewRedesSociales != null)
            {
                if(NewRedesSociales.Count > 0)
                {
                    foreach (RedSocialModel RedSocial in NewRedesSociales)
                    {
                        if ((RedSocial.Red_Social_Id != null && RedSocial.Red_Social_Id != "") && (RedSocial.Red_Social_Enlace != null && RedSocial.Red_Social_Enlace != ""))
                        {
                            resultRedesSociales = new RedesSocialesController().SetRedSocial(KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), RedSocial.Red_Social_Id, RedSocial.Red_Social_Enlace, RedSocial.Usuario_Red_Social_Id);
                        }
                        else
                        {
                            resultRedesSociales = 1;
                        }
                    }
                }
                else
                {
                    resultRedesSociales = 1;
                }
            }
            else
            {
                resultRedesSociales = 1;
            }

            resultDataMiembros = new UsuariosController().UpdateDataMiembros(KeyChainHelper.GetKey("Usuario_Id"), NewInfoPerfil.Usuario_Nombre, NewInfoPerfil.Usuario_Apellidos, NewInfoPerfil.Usuario_Correo_Electronico,
                                                                             NewInfoPerfil.Usuario_Telefono, NewInfoPerfil.Usuario_Celular, NewInfoPerfil.Usuario_Descripcion, fechaNacimiento, NewInfoPerfil.Usuario_Fotografia_Perfil, NewInfoPerfil.Usuario_Fotografia_FondoPerfil);

            if (NewInfoPerfil.Empresa_Actual.Empresa_Logotipo_Perfil == null)
            {
                NewInfoPerfil.Empresa_Actual.Empresa_Logotipo_Perfil = new byte[0]; 
            }

            resultadoTrabajo = new EmpresaController().UpdateUsuarioEmpresaPerfil(NewInfoPerfil.Empresa_Actual.Empresa_Id, NewInfoPerfil.Usuario_Id, "57802", NewInfoPerfil.Empresa_Actual.Empresa_Nombre, 
                                                                                  NewInfoPerfil.Empresa_Actual.Empresa_Correo_Electronico, NewInfoPerfil.Empresa_Actual.Empresa_Pagina_Web, NewInfoPerfil.Usuario_Puesto, NewInfoPerfil.Empresa_Actual.Empresa_Logotipo_Perfil);

            if (resultDataMiembros && resultadoTrabajo && resultEtiquetas != -1 && resultRedesSociales != -1)
            {
                this.DismissViewController(true, () =>
                {
                    MenuHelper.GetUsuarioInfo();
                    this.MiInfoDeleghate.MiInfo(MenuHelper.Usuario);
                });
            }
            else
            {
                new MessageDialog().SendToast("Error al intentar actualizar la información");
            }

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "EditarMiInfo")
            {
                var VistaHabilidades = (EditarMiInfoPerfilViewController)segue.DestinationViewController;
                VistaHabilidades.EditarInfoDelegate = this;
                VistaHabilidades.Miembro = InfoPerifl;
            }
            else if (segue.Identifier == "EditarSociales")
            {
                var VistaRedesSociales = (VistaEditarRedesSociales)segue.DestinationViewController;
                VistaRedesSociales.Redes_Sociales = InfoPerifl.Redes_Sociales;
                VistaRedesSociales.Miembro = InfoPerifl;
                VistaRedesSociales.VistaRedesSocialesDelegate = this;
            }
            else if (segue.Identifier == "EditarTrabajo")
            {
                var VsitaTrabajo = (TrabajoViewController)segue.DestinationViewController;
                VsitaTrabajo.InfoPerifl = InfoPerifl;
                VsitaTrabajo.EventosVistaTrabajoDelegate = this;
            }
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }
    }

    public partial class EditarPerfilTableViewController : EventosActualizarInfoPerfil
    {
        public void InfoSobreMi(UsuarioModel InfoActualizar)
        {
            NewInfoPerfil = InfoActualizar;
        }

        public void Etiquetas(EtiquetaModel Etiquetas)
        {
            NewInfoPerfil.Etiquetas.Add(Etiquetas);
        }
    }

    public partial class EditarPerfilTableViewController : EventosVistaRedesSociales
    {
        public void RedesSociales(List<RedSocialModel> Redes_Sociales)
        {
            NewRedesSociales = Redes_Sociales;
        }
    }

    public partial class EditarPerfilTableViewController : EventosVistaTrabajo
    {
        public void InfoEmpresa(UsuarioModel Empresa)
        {
            NewInfoPerfil = Empresa;

        }
    }

}