using System;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using Foundation;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class MiInfoViewController : UIViewController
    {
        public MiembroModel Miembro = new MiembroModel();
        string[] Habilidades, Intereses;
        List<string> ListaHabilidades = new List<string>();
        List<string> ListaIntereses = new List<string>();

        public MiInfoViewController (IntPtr handle) : base (handle)
        {
        }

       public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            this.OcultarIntereses();
            this.OcultarHabilidades();

            Habilidades = Miembro.Miembro_Habilidades.Split(',');

            for (int indice = 0; indice < Habilidades.Length - 1; indice++)
            {
                ListaHabilidades.Add(Habilidades[indice]);
            }

            this.MostrarHabilidades();
            this.MostrarIntereses();

            txtSobreMi.Text = Miembro.Miembro_SobreMi;
        }

        private void OcultarHabilidades()
        {
            lblHabTag1.Hidden = true;
            lblHabTag2.Hidden = true;
            lblHabTag3.Hidden = true;
            lblHabTag4.Hidden = true;
            lblHabTag5.Hidden = true;
        }

        private void OcultarIntereses()
        {
            lblIntTag1.Hidden = true;
            lblIntTag2.Hidden = true;
            lblIntTag3.Hidden = true;
            lblIntTag4.Hidden = true;
            lblIntTag5.Hidden = true;
        }

        private void MostrarHabilidades()
        {
            if(ListaHabilidades.Count == 1)
            {
                this.lblHabTag1.Hidden = false;
            }
            if (ListaHabilidades.Count == 2)
            {
                this.lblHabTag1.Hidden = false;
                this.lblHabTag2.Hidden = false;
            }
            if (ListaHabilidades.Count == 3)
            {
                this.lblHabTag1.Hidden = false;
                this.lblHabTag2.Hidden = false;
                this.lblHabTag3.Hidden = false;
            }
            if (ListaHabilidades.Count == 4)
            {
                this.lblHabTag1.Hidden = false;
                this.lblHabTag2.Hidden = false;
                this.lblHabTag3.Hidden = false;
                this.lblHabTag4.Hidden = false;
            }
            if (ListaHabilidades.Count == 5)
            {
                this.lblHabTag1.Hidden = false;
                this.lblHabTag2.Hidden = false;
                this.lblHabTag3.Hidden = false;
                this.lblHabTag4.Hidden = false;
                this.lblHabTag5.Hidden = false;
            }
        }

        private void MostrarIntereses()
        {
            if (ListaIntereses.Count == 1)
            {
                this.lblIntTag1.Hidden = false;
            }
            if (ListaIntereses.Count == 2)
            {
                this.lblIntTag1.Hidden = false;
                this.lblIntTag2.Hidden = false;
            }
            if (ListaIntereses.Count == 3)
            {
                this.lblIntTag1.Hidden = false;
                this.lblIntTag2.Hidden = false;
                this.lblIntTag3.Hidden = false;
            }
            if (ListaIntereses.Count == 4)
            {
                this.lblIntTag1.Hidden = false;
                this.lblIntTag2.Hidden = false;
                this.lblIntTag3.Hidden = false;
                this.lblIntTag4.Hidden = false;
            }
            if (ListaIntereses.Count == 5)
            {
                this.lblIntTag1.Hidden = false;
                this.lblIntTag2.Hidden = false;
                this.lblIntTag3.Hidden = false;
                this.lblIntTag4.Hidden = false;
                this.lblIntTag5.Hidden = false;
            }
        }

    }
}