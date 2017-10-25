using System;
using UIKit;
using WorklabsMx.Models;
using PerpetualEngine.Storage;


namespace WorklabsMx.iOS
{

    public partial class ComentarPostHeaderCell : UITableViewCell
    {

        public string Placeholder { get; set; }

        PostModel LocalPost;

        public event EventHandler PostComentado;

        public event EventHandler TextoEscrito;

        public event EventHandler MostrarActionSheet;

        public event EventHandler MostrarImagenEnGrande;

        bool mostrarImagen = false;

        UIImage ImagenPublicacion;


        public ComentarPostHeaderCell (IntPtr handle) : base (handle)
        {

        }

        internal void getText(UITextView TextoComentario)
        {
            if (TextoComentario != null)
            {
                this.txtComentarPost.Text = TextoComentario.Text;
                this.btnPublicar.Enabled = true;
                this.btnPublicar.Layer.Opacity = 1f;
            }

        }

        internal void getConfigImageLoaded(UIImage image)
        {
            if (image != null)
            {
                mostrarImagen = true;
                ImagenPublicacion = image;
                this.btnFotografia.SetImage(image, UIControlState.Normal);
                this.btnFotografia.ContentMode = UIViewContentMode.ScaleAspectFit;
                this.btnFotografia.Hidden = false;
                this.btnFotografia.Enabled = true;
                this.btnBorrarFoto.Hidden = false;
                this.btnBorrarFoto.Enabled = true;
                this.btnPublicar.Enabled = true;
                this.btnPublicar.Layer.Opacity = 1f;
            }
        }

        internal void UpdateCell(PostModel Post)
        {
            this.LocalPost = Post;

            if (mostrarImagen)
            {
                
            }

            Placeholder = "Escribe un comentario";
            this.txtComentarPost.ShouldBeginEditing = t => {
                if (this.txtComentarPost.Text == Placeholder)
                    this.txtComentarPost.Text = string.Empty;
                this.txtComentarPost.TextColor = UIColor.Black;
                return true;
            };
            this.txtComentarPost.ShouldEndEditing = t => {
                if (string.IsNullOrEmpty(this.txtComentarPost.Text))
                    this.txtComentarPost.Text = Placeholder;
                var color = new UIColor(149, 152, 154, 1);

                this.txtComentarPost.TextColor = color;
                return true;
            };
            this.txtComentarPost.Changed += HandleTextMessageChanged;
        }

        partial void btnComentar_TouchUpInside(UIButton sender)
        {
            var localStorage = SimpleStorage.EditGroup("Login");

            byte[] Fotografia;

            if (ImagenPublicacion != null)
            {
                Fotografia = ImagenPublicacion?.AsPNG().ToArray();
            }
            else
            {
                Fotografia = new byte[0];
            }

            if (new Controllers.EscritorioController().CommentPost(LocalPost.Publicacion_Id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), txtComentarPost.Text, Fotografia))
            {
                if (PostComentado != null)
                {
                    this.txtComentarPost.Text = "";
                    this.btnPublicar.Enabled = false;
                    this.btnPublicar.Layer.Opacity = 0.5f;
                    mostrarImagen = false;
                    this.btnFotografia.Hidden = true;
                    this.btnFotografia.Enabled = false;
                    PostComentado(this, EventArgs.Empty);
                }
            }
        }



        private void HandleTextMessageChanged(object sender, EventArgs e)
        {
            if (TextoEscrito != null)
            {
                TextoEscrito(txtComentarPost, EventArgs.Empty);
            }
            if (string.IsNullOrWhiteSpace(txtComentarPost.Text))
            {
                this.btnPublicar.Enabled = false;
                this.btnPublicar.Layer.Opacity = 0.5f;
            }
            else
            {
                this.btnPublicar.Enabled = true;
                this.btnPublicar.Layer.Opacity = 1f;
            }
        }

        partial void btnSleccionarImagen_TouchUpInside(UIButton sender)
        {
            if (MostrarActionSheet != null)
            {
                MostrarActionSheet(this, EventArgs.Empty);
            }
        }

        partial void btnFotografia_TouchUpInside(UIButton sender)
        {
            if (mostrarImagen)
            {
                if (MostrarImagenEnGrande != null)
                {
                    MostrarImagenEnGrande(sender.ImageView, EventArgs.Empty);
                }
            }
        }

        partial void btnBorrarFoto_TouchUpInside(UIButton sender)
        {
            mostrarImagen = false;
            this.btnFotografia.Hidden = true;
            this.btnFotografia.Enabled = false;
            if (this.txtComentarPost.Text == "Escribe un comentario")
            {
                this.btnPublicar.Layer.Opacity = 0.5f;
                this.btnPublicar.Enabled = false;
            }
            this.btnBorrarFoto.Hidden = true;
            this.btnBorrarFoto.Enabled = false;
        }
    }
}