using System;
using UIKit;
using WorklabsMx.iOS.ViewElements;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.iOS.Styles;
using CoreGraphics;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class ReporteController : UIViewController
    {
        public string post_id, comment_id;
        readonly List<UIRadioButton> radios;
        readonly Controllers.EscritorioController ctrlEscritorio;
        int size = 30;
        public ReporteController(IntPtr handle) : base(handle)
        {
            radios = new List<UIRadioButton>();
            ctrlEscritorio = new Controllers.EscritorioController();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIBarButtonSystemItem.Done, (sender, e) =>
            {
                SimpleStorage storage = SimpleStorage.EditGroup("Login");
                UIRadioButton radioSelected = radios.Find(radio => radio.IsChecked);
                if (radioSelected != null)
                {
                    bool report = false;
                    if (string.IsNullOrEmpty(post_id))
                        report = ctrlEscritorio.ReportarPost(post_id, storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), radioSelected.IDRadio);
                    else
                        report = ctrlEscritorio.ReportarComment(comment_id, storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), radioSelected.IDRadio);

                    if (report)
                    {
                        NavigationController.PopViewController(true);
                        new MessageDialog().SendToast("Gracias por su aportación \n El equipo de Worklabs revisará el caso.");
                    }
                    else
                        new MessageDialog().SendToast("Existió un error, intente de nuevo");
                }
                else
                    new MessageDialog().SendToast("Seleccione una opción de reporte");
            }), true);

            #region Post a reportar

            using (UIView postView = new UIView(new CGRect(0, 50, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                PostModel post = ctrlEscritorio.GetSinglePost(post_id);
                UIButton pstImage = new STLButton(ImageGallery.LoadImage(post.Usuario_Fotografia_Ruta))
                {
                    Frame = new CGRect(10, 20, 50, 50)
                };
                pstImage.Layer.MasksToBounds = true;
                pstImage.Layer.CornerRadius = 25;
                pstImage.TouchUpInside += (sender, e) =>
                {
                    new MessageDialog().ShowImage(ImageGallery.LoadImage(post.Usuario_Fotografia_Ruta));
                };
                postView.AddSubview(pstImage);

                UIButton lblNombre = new STLButton(post.Usuario_Nombre)
                {
                    Frame = new CGRect(65, 25, UIScreen.MainScreen.Bounds.Width, 20),
                    Font = UIFont.BoldSystemFontOfSize(16),
                    BackgroundColor = UIColor.Clear,
                    HorizontalAlignment = UIControlContentHorizontalAlignment.Left
                };
                lblNombre.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
                postView.AddSubview(lblNombre);

                UILabel lblfecha = new STLLabel(post.Publicacion_Fecha, 45, 12)
                {
                    Frame = new CGRect(65, 35, UIScreen.MainScreen.Bounds.Width, 50)
                };
                postView.AddSubview(lblfecha);

                if (post.Publicacion_Imagen_Ruta != "")
                {
                    UIImageView imgPost = new STLImageView(110, post.Publicacion_Imagen_Ruta)
                    {
                        Frame = new CGRect(10, 90, UIScreen.MainScreen.Bounds.Width - 100, 100)
                    };
                    Add(imgPost);
                    size += 160;
                }

                UILabel txtPost = new UILabel
                {
                    Frame = new CGRect(10, 90 + size, UIScreen.MainScreen.Bounds.Width - 10, 30),
                    Text = post.Publicacion_Contenido,
                    Font = UIFont.SystemFontOfSize(16),
                    LineBreakMode = UILineBreakMode.WordWrap,
                    Lines = 0
                };
                int postSize = 30 * Convert.ToInt32(Math.Floor(txtPost.IntrinsicContentSize.Width / (UIScreen.MainScreen.Bounds.Width - 10)));
                txtPost.Frame = new CGRect(10, 110, UIScreen.MainScreen.Bounds.Width - 10, 30 + postSize);
                postView.AddSubview(txtPost);
                size += postSize;

                Add(postView);
            }
            #endregion

            #region Acusaciones

            foreach (KeyValuePair<int, string> mensaje in ctrlEscritorio.GetMensajesReporte())
            {
                UIRadioButton radio = new UIRadioButton(20, 200 + size, mensaje.Value)
                {
                    IDRadio = mensaje.Key
                };
                radio.TouchUpInside += Radio_TouchUpInside;
                radios.Add(radio);
                size += 30;
                View.Add(radio);
            }
            #endregion
        }

        void Radio_TouchUpInside(object sender, EventArgs e)
        {
            foreach (UIRadioButton r in radios)
            {
                if (((UIRadioButton)sender).IDRadio == r.IDRadio)
                {
                    r.IsChecked = true;
                }
                else
                    r.IsChecked = false;

                r.SetImage(r.ChangeState(), UIControlState.Normal);
            }
        }
    }
}