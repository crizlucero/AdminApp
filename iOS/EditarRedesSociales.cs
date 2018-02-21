using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;


namespace WorklabsMx.iOS
{

    public interface EventosRedesSociales
    {
        void RedesSociales(List<RedSocialModel> Redes_Sociales);
    }

    public partial class EditarRedesSociales : UITableViewController
    {

        public EventosRedesSociales RedesSocilesDelegate;

        public List<RedSocialModel> Redes_Sociales = new List<RedSocialModel>();

        List<RedSocialModel> New_Redes_Sociales;

        List<RedSocialModel> RedesSocialesBD;

        RedSocialModel RedSocial = new RedSocialModel();

        static string[] RedeSocialNombre = new string[]
        {
            "Página Web",
            "Facebook",
            "Instagram",
            "Twitter",
            "YouTube",
            "LinkedIn",
            "Skype"
        };

        public EditarRedesSociales (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            RedesSocialesBD = new PickerItemsController().GetRedesSociales();
            New_Redes_Sociales = new List<RedSocialModel>();


            if (Redes_Sociales != null)
            {
                if (Redes_Sociales.Count > 0)
                {
                    
                    foreach(RedSocialModel ActualRedSocial in Redes_Sociales)
                    {
                        for (int indice = 0; indice < RedeSocialNombre.Length; indice ++)
                        {
                            if (ActualRedSocial.Red_Social_Nombre.Contains(RedeSocialNombre[indice]))
                            {
                                New_Redes_Sociales.Add(ActualRedSocial);

                            }
                        }
                       

                        if (ActualRedSocial.Red_Social_Enlace == "" || ActualRedSocial.Red_Social_Enlace == null)
                        {
                        }
                        else
                        {
                            if (ActualRedSocial.Red_Social_Nombre.Contains(RedeSocialNombre[0]))
                            {
                                txtWeb.Text = ActualRedSocial.Red_Social_Enlace;
                            }
                            if (ActualRedSocial.Red_Social_Nombre.Contains(RedeSocialNombre[1]))
                            {
                                txtFacebook.Text = ActualRedSocial.Red_Social_Enlace;
                            }
                            if (ActualRedSocial.Red_Social_Nombre.Contains(RedeSocialNombre[2]))
                            {
                                txtInstagram.Text = ActualRedSocial.Red_Social_Enlace;
                            }
                            if (ActualRedSocial.Red_Social_Nombre.Contains(RedeSocialNombre[3]))
                            {
                                txtTwitter.Text = ActualRedSocial.Red_Social_Enlace;
                            }
                            if (ActualRedSocial.Red_Social_Nombre.Contains(RedeSocialNombre[4]))
                            {
                                txtYoutube.Text = ActualRedSocial.Red_Social_Enlace;
                            }
                            if (ActualRedSocial.Red_Social_Nombre.Contains(RedeSocialNombre[5]))
                            {
                                txtLinkedin.Text = ActualRedSocial.Red_Social_Enlace;
                            }
                            if (ActualRedSocial.Red_Social_Nombre.Contains(RedeSocialNombre[6]))
                            {
                                txtSkype.Text = ActualRedSocial.Red_Social_Enlace;
                            }
                        }

                    }
                }
            }

            txtWeb.EditingChanged += (sender, e) =>
            {
                New_Redes_Sociales[0].Red_Social_Enlace = txtWeb.Text;
                RedesSocilesDelegate.RedesSociales(New_Redes_Sociales);
            };

            txtFacebook.EditingChanged += (sender, e) =>
            {
                New_Redes_Sociales[1].Red_Social_Enlace = txtFacebook.Text;
                RedesSocilesDelegate.RedesSociales(New_Redes_Sociales);
            };

            txtInstagram.EditingChanged += (sender, e) =>
            {
                New_Redes_Sociales[2].Red_Social_Enlace = txtInstagram.Text;
                RedesSocilesDelegate.RedesSociales(New_Redes_Sociales);
            };

            txtTwitter.EditingChanged += (sender, e) =>
            {
                New_Redes_Sociales[3].Red_Social_Enlace = txtTwitter.Text;
                RedesSocilesDelegate.RedesSociales(New_Redes_Sociales);
            };

            txtYoutube.EditingChanged += (sender, e) =>
            {
                New_Redes_Sociales[4].Red_Social_Enlace = txtYoutube.Text;
                RedesSocilesDelegate.RedesSociales(New_Redes_Sociales);
            };

            txtLinkedin.EditingChanged += (sender, e) =>
            {
                New_Redes_Sociales[5].Red_Social_Enlace = txtLinkedin.Text;
                RedesSocilesDelegate.RedesSociales(New_Redes_Sociales);
            };

            txtSkype.EditingChanged += (sender, e) =>
            {
                New_Redes_Sociales[6].Red_Social_Enlace = txtSkype.Text;
                RedesSocilesDelegate.RedesSociales(New_Redes_Sociales);
            };

            StyleHelper.Style(vwWeb.Layer);
            StyleHelper.Style(vwSkype.Layer);
            StyleHelper.Style(vwTwitter.Layer);
            StyleHelper.Style(vwYoutube.Layer);
            StyleHelper.Style(vwFacebook.Layer);
            StyleHelper.Style(vwLinkedin.Layer);
            StyleHelper.Style(vwInstagram.Layer);

            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }


    }
}