using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface ComentarioRealizado
    {
        void ComentarioRealizado(String Comentario);
    }

    public partial class ComentarviewController : UIViewController
    {

        public ComentarioRealizado ComentarioDelegate;

        public ComentarviewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var Tap = new UITapGestureRecognizer(this.Tapped);
            this.View.AddGestureRecognizer(Tap);
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var color = new UIColor(0, 0.0f);
            this.View.BackgroundColor = color;
        }

        partial void btnCamara_TouchUpInside(UIButton sender)
        {
        }

        partial void btnClose_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnComentar_TouchUpInside(UIButton sender)
        {
            this.ComentarioDelegate.ComentarioRealizado(this.txtComentario.Text);
            this.DismissViewController(true, null);
        }

        private void Tapped(UITapGestureRecognizer Recognizer)
        {
            this.View.EndEditing(true);
        }
    }
}