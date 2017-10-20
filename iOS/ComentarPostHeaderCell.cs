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
                this.btnFotografia.SetImage(image, UIControlState.Normal);
                this.btnBorrarFoto.Hidden = false;
                this.btnPublicar.Enabled = true;
                this.btnPublicar.Layer.Opacity = 1f;
                this.btnFotografia.ContentMode = UIViewContentMode.ScaleAspectFit;
            }
        }

        internal void UpdateCell(PostModel Post)
        {
            this.LocalPost = Post;

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
            if (new Controllers.EscritorioController().CommentPost(LocalPost.Publicacion_Id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), txtComentarPost.Text))
            {
                if (PostComentado != null)
                {
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
            if (MostrarImagenEnGrande != null)
            {
                MostrarImagenEnGrande(sender.ImageView, EventArgs.Empty);
            }
        }

        partial void btnBorrarFoto_TouchUpInside(UIButton sender)
        {
            this.btnFotografia.SetImage(null, UIControlState.Normal);
            if (this.txtComentarPost.Text == "Escribe un comentario")
            {
                this.btnPublicar.Layer.Opacity = 0.5f;
                this.btnPublicar.Enabled = false;
            }
            this.btnBorrarFoto.Hidden = true;
        }
    }
}