using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{
    public partial class ComunidadTableViewController : UITableViewController
    {
        List<MiembroModel> Usuarios = new List<MiembroModel>();

        public ComunidadTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.FillData();
        }

        private void FillData(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            this.Usuarios = new MiembrosController().GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio);
        }
    }
}