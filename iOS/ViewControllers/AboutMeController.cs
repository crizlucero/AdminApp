using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class AboutMeController : UIViewController
    {
        Miembro miembro;
        public AboutMeController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
			DataBase db = new DataBase();
			miembro = db.GetMemberData(storageLocal.Get("Miembro_Id"));
			this.FillData();
		}

		private void FillData()
		{
			#region Datos del miembro
			lblProfesion.Text = miembro.Miembro_Profesion;
			lblPuesto.Text = miembro.Miembro_Puesto;
			lblHabilidades.Text = miembro.Miembro_Habilidades;
			lblTelefono.Text = miembro.Miembro_Telefono;
			lblCelular.Text = miembro.Miembro_Celular;
			#endregion
		}
    }
}