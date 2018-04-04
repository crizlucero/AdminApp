using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.Models;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class SalasJuntasCelda : UITableViewCell
    {
        public SalasJuntasCelda (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(SalaJuntasModel SalaJuntas)
        {
            this.lblPiso.Text = "Piso: " + SalaJuntas.Sala_Nivel;
            this.lblCapacidad.Text = SalaJuntas.Sala_Capacidad + " Personas";
            this.lblNombreSala.Text = SalaJuntas.Sala_Descripcion;
            if (SalaJuntas.Sala_Capacidad == "6")
            {
                imgSalaJuntas.Image = UIImage.FromBundle("Sala6");
            }
            else if (SalaJuntas.Sala_Capacidad == "10")
            {
                imgSalaJuntas.Image = UIImage.FromBundle("Sala10");
            }

        }
    }
}