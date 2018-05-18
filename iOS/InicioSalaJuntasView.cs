using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class InicioSalaJuntasView : UITableViewController
    {
        public InicioSalaJuntasView (IntPtr handle) : base (handle)
        {
			
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.imgSala.UserInteractionEnabled = true;
			UITapGestureRecognizer tapGestureimgSala = new UITapGestureRecognizer(imgSalaTouch);
			this.imgSala.AddGestureRecognizer(tapGestureimgSala);

			this.imgHorario.UserInteractionEnabled = true;
			UITapGestureRecognizer tapGestureimgHorario = new UITapGestureRecognizer(imgHorarioTouch);
			this.imgHorario.AddGestureRecognizer(tapGestureimgHorario);
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		partial void btnMenu_Touch(UIBarButtonItem sender)
		{
			this.View.EndEditing(true);
			this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
		}

		private void imgSalaTouch(UITapGestureRecognizer Recognizer)
        {
			this.PerformSegue("PorSalaSegue", null);
        }
        
		private void imgHorarioTouch(UITapGestureRecognizer Recognizer)
        {
			this.PerformSegue("PorHorarioSegue", null);
        }
	}
}