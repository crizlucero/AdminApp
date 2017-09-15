using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.ViewElements;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;
using CoreGraphics;
using WorklabsMx.Helpers;
using WorklabsMx.iOS.Styles;
using Contacts;
using ContactsUI;
using Foundation;
using MessageUI;

namespace WorklabsMx.iOS
{
    public partial class PerfilController : UIViewController
    {
        MiembroModel miembro;
        public string Usuario = null, Tipo = null;
        UIScrollView scrollView;
        UIImageView imagen;
        int postNumber, totalSize = 0;
        static int currentPage = 0;
        ImageGallery selectImage;
        SimpleStorage storageLocal;
        UITextField txtPublish;
        bool endLine = false;
        List<PostCard> AllPost;
        UIView viewView;
        public PerfilController(IntPtr handle) : base(handle)
        {
            AllPost = new List<PostCard>();
            storageLocal = SimpleStorage.EditGroup("Login");
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            if (string.IsNullOrEmpty(Usuario))
                miembro = new MiembrosController().GetMemberData(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"));
            else
                miembro = new MiembrosController().GetMemberData(Usuario, Tipo);
            new InfoPersonaCard(miembro, View, 100);

            UIToolbar tbNav = new UIToolbar
            {
                Frame = new CGRect(0, 60, UIScreen.MainScreen.Bounds.Width, 40)
            };
            UIBarButtonItem bbiPosts = new UIBarButtonItem(UIBarButtonSystemItem.Bookmarks, async (sender, e) =>
            {
                #region Publicar
                viewView = new UIView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, 100)) { BackgroundColor = UIColor.White };
                txtPublish = new STLTextField("Publica algo :)", 20)
                {
                    Frame = new CGRect(5, 20, UIScreen.MainScreen.Bounds.Width - 120, 30)
                };
                viewView.Add(txtPublish);
                UIButton btnPhoto = new STLButton(UIImage.FromBundle("ic_attach_file"))
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 140, 20, 30, 30),
                    BackgroundColor = UIColor.FromRGBA(0, 0, 0, 0)
                };
                btnPhoto.TouchUpInside += BtnPhoto_TouchUpInside;
                viewView.Add(btnPhoto);

                UIButton btnPublicar = new STLButton("Publicar")
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 110, 20, 100, 30)
                };
                btnPublicar.TouchUpInside += BtnPublicar_TouchUpInside;
                viewView.Add(btnPublicar);

                View.AddSubview(viewView);
                #endregion
                #region Posts
                scrollView = new UIScrollView(new CGRect(0, 150, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)) { BackgroundColor = UIColor.White };
                await this.AddPostsAsync();
                View.AddSubview(scrollView);
                #endregion
            });

            if (Usuario != storageLocal.Get("Usuario_Id") || Tipo != storageLocal.Get("Usuario_Tipo"))
            {
                NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_person_add"), UIBarButtonItemStyle.Plain, (sender, e) =>
                {
                    // Create a new Mutable Contact (read/write)
                    // and attach it to the editor
                    CNContactStore store = new CNContactStore();
                    CNMutableContact contact = new CNMutableContact();
                    CNContactViewController editor = CNContactViewController.FromNewContact(contact);

                    CNLabeledValue<CNPhoneNumber> cellPhone = new CNLabeledValue<CNPhoneNumber>(CNLabelPhoneNumberKey.Mobile, new CNPhoneNumber(miembro.Miembro_Celular));
                    CNLabeledValue<CNPhoneNumber> telephone = new CNLabeledValue<CNPhoneNumber>(CNLabelPhoneNumberKey.Main, new CNPhoneNumber(miembro.Miembro_Telefono));
                    CNLabeledValue<NSString> email = new CNLabeledValue<NSString>(CNLabelKey.Home, new NSString(miembro.Miembro_Correo_Electronico));
                    // Configure editor

                    editor.ContactStore = store;
                    contact.GivenName = miembro.Miembro_Nombre;
                    contact.FamilyName = miembro.Miembro_Apellidos;
                    contact.JobTitle = miembro.Miembro_Puesto;
                    contact.PhoneNumbers = new[] { telephone, cellPhone };
                    contact.EmailAddresses = new CNLabeledValue<NSString>[] { email };
                    // Display picker
                    var navController = ParentViewController as UINavigationController;
                    navController.PushViewController(editor, true);

                }), true);
            }

            UIBarButtonItem bbiInfo = new UIBarButtonItem(UIImage.FromBundle("ic_format_list_bulleted"), UIBarButtonItemStyle.Done, (sender, e) =>
            {
                new InfoPersonaCard(miembro, View, 100);
            });

            UIBarButtonItem bbiFavorites = new UIBarButtonItem(UIImage.FromBundle("ic_star"), UIBarButtonItemStyle.Done, (sender, e) =>
            {
                MiembrosFavoritos();
            });

            UIBarButtonItem bbiSpace = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace);
            UIBarButtonItem[] bbs = {
                bbiSpace,
                bbiInfo,
                bbiSpace,
                bbiPosts,
                bbiSpace,
                bbiFavorites,
                bbiSpace
            };
            tbNav.SetItems(bbs, false);
            View.Add(tbNav);
        }

        /// <summary>
        /// Agrega a la pantalla los posts
        /// </summary>
        async Task AddPostsAsync()
        {
            List<PostModel> posts;
            posts = new Controllers.EscritorioController().GetPerfilPosts(Usuario ?? storageLocal.Get("Usuario_Id"),
                                                                          Tipo ?? storageLocal.Get("Usuario_Tipo"));
            if (posts.Count > 0)
            {
                endLine = (posts.Count < 5);
                foreach (PostModel post in posts)
                {
                    try
                    {
                        AllPost.Add(new PostCard(post, this)
                        {
                            Frame = new CGRect(0, totalSize, UIScreen.MainScreen.Bounds.Width, 140)
                        });
                        AllPost[postNumber].lblNombre.TouchUpInside += (sender, e) =>
                        {
                            try
                            {
                                PerfilController perfilController = (PerfilController)Storyboard.InstantiateViewController("PerfilIndividualController");
                                perfilController.Tipo = post.Tipo;
                                perfilController.Usuario = post.MIEMBRO_ID;
                                NavigationController.PushViewController(perfilController, true);
                                ((UIButton)sender).BackgroundColor = UIColor.Clear;
                            }
                            catch (Exception ex)
                            {
                                SlackLogs.SendMessage(ex.Message);
                            }
                        };
                        totalSize += AllPost[postNumber].totalSize;
                        scrollView.AddSubview(AllPost[postNumber]);
                        UITextField txtComentario = new STLTextField("Escribe un comentario", 215 + totalSize)
                        {
                            Frame = new CGRect(5, 140 + totalSize - (AllPost[postNumber].PostComments.Count * 60), UIScreen.MainScreen.Bounds.Width - 50, 30)
                        };
                        scrollView.Add(txtComentario);

                        UIButton btnComentar = new STLButton(UIImage.FromBundle("ic_send"))
                        {
                            Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 140 + totalSize - (AllPost[postNumber].PostComments.Count * 60), 30, 30),
                            BackgroundColor = UIColor.LightGray
                        };
                        btnComentar.Layer.CornerRadius = 15;
                        btnComentar.TouchUpInside += async (sender, e) =>
                        {
                            if (new Controllers.EscritorioController().CommentPost(post.POST_ID, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"), txtComentario.Text))
                            {
                                nfloat scrollPosition = scrollView.ContentOffset.Y;
                                txtComentario.Text = "";
                                scrollView.RemoveFromSuperview();
                                await AddPostsAsync();
                                scrollView.ContentOffset = new CGPoint(0, scrollPosition);
                            }
                        };
                        scrollView.Add(btnComentar);

                        #region Comentarios
                        //await AddCommentsPostAsync(post.POST_ID);
                        #endregion
                        totalSize += 180;
                        ++postNumber;
                    }
                    catch (Exception e)
                    {
                        SlackLogs.SendMessage(e.Message);
                    }
                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 100 + totalSize);

                scrollView.Scrolled += ScrollView_Scrolled;
                View.AddSubview(scrollView);

            }
            else
            {
                endLine = true;
                Console.WriteLine("No more elements");
            }
        }

        void BtnPhoto_TouchUpInside(object sender, EventArgs e)
        {
            viewView.Frame = new CGRect(5, 50, UIScreen.MainScreen.Bounds.Width, 100);
            UIImagePickerController imagePicker = new UIImagePickerController();
            imagen = new STLImageView(65, "");
            imagen.Image.Scale(new CGSize(50, 50), 0);
            viewView.Add(imagen);
            selectImage = new ImageGallery(imagePicker, imagen);
            this.PresentViewController(imagePicker, true, () => { });
            scrollView.Frame = new CGRect(0, 150, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height);
        }

        async void BtnPublicar_TouchUpInside(object sender, EventArgs e)
        {
            if (imagen != null)
                imagen.Hidden = true;
            if (new Controllers.EscritorioController().SetPost(storageLocal.Get("Usuario_Id"), null, txtPublish.Text, "", imagen?.Image.AsPNG().ToArray()))
            {
                scrollView.RemoveFromSuperview();
                totalSize = 0;
                currentPage = 0;
                scrollView = new UIScrollView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
                AllPost.Reverse();
                await AddPostsAsync();
                txtPublish.Text = "";
            }
        }

        async void ScrollView_Scrolled(object sender, EventArgs e)
        {
            if (((UIScrollView)sender).ContentOffset.Y > totalSize - 1000 && !endLine)
            {
                currentPage += 5;
                await AddPostsAsync();
            }
        }

        void MiembrosFavoritos()
        {
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 100, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                int position = 0;
                foreach (MiembroModel usuario in new MiembrosController().GetMiembrosFavoritos(storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo")))
                {
                    InfoPersonaCard personaCard = new InfoPersonaCard(usuario, scrollView, position);
                    personaCard.lblMail.TouchUpInside += (sender, e) =>
                    {
                        MFMailComposeViewController mailController;
                        if (MFMailComposeViewController.CanSendMail)
                        {
                            mailController = new MFMailComposeViewController();

                            mailController.SetToRecipients(new string[] { usuario.Miembro_Correo_Electronico });
                            mailController.SetSubject("Contacto - Worklabs");
                            mailController.SetMessageBody("", false);

                            mailController.Finished += (object s, MFComposeResultEventArgs args) =>
                            {
                                Console.WriteLine(args.Result.ToString());
                                args.Controller.DismissViewController(true, null);
                            };

                            this.PresentViewController(mailController, true, null);
                        }
                    };
                    personaCard.lblNombre.TouchUpInside += (sender, e) =>
                    {
                        PerfilController perfilController = (PerfilController)Storyboard.InstantiateViewController("PerfilIndividualController");
                        perfilController.Tipo = usuario.Miembro_Tipo;
                        perfilController.Usuario = usuario.Miembro_Id;
                        perfilController.Title = "Perfil";
                        NavigationController.PushViewController(perfilController, true);
                        ((UIButton)sender).BackgroundColor = UIColor.Clear;
                    };
                    position += 400;
                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, position);
                View.AddSubview(scrollView);
            }
        }
    }
}