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
        bool sendComment = false;

        public event EventHandler PostComentado;

        public ComentarPostHeaderCell (IntPtr handle) : base (handle)
        {
            
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
            if (new Controllers.EscritorioController().CommentPost(LocalPost.POST_ID, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), txtComentarPost.Text))
            {
                if (PostComentado != null)
                {
                    PostComentado(this, EventArgs.Empty);
                }
            }
        }

        internal bool SendActionPost()
        {
            return sendComment;
        }

        private void HandleTextMessageChanged(object sender, EventArgs e)
		{
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

       
    }
}