using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class ComentarPostHeaderCell : UITableViewCell
    {
        public ComentarPostHeaderCell (IntPtr handle) : base (handle)
        {
            
        }

        internal void UpdateCell()
        {
            this.txtComentarPost.Changed += HandleTextMessageChanged;
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