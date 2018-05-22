using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class ConfirmacionReservaSalaViewController : UITableViewController
    {
		public string Fecha;
		public string Horas;
		public string SalaNombre;
		public string CantidadPersonas;
		public string Nivel;

        public ConfirmacionReservaSalaViewController (IntPtr handle) : base (handle)
        {
			
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.lblFecha.Text = this.Fecha;
			this.lblHoras.Text = this.Horas;
			this.lblNombreSala.Text = this.SalaNombre;
			this.lblCantidadPersonas.Text = this.CantidadPersonas;
			this.lblNivel.Text = this.Nivel;
		}

		partial void btnConfirmar_Touch(UIButton sender)
		{
			this.PerformSegue("ProgramaReuniones", null);
		}
	}
}