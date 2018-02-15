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
        public UsuarioModel Miembro = new UsuarioModel();
        public List<EtiquetaModel> Etiquetas;

        List<EtiquetaModel> EtiquetasHabilidades = new List<EtiquetaModel>();
        List<EtiquetaModel> EtiquetasIntereses = new List<EtiquetaModel>();

        public MiInfoViewController (IntPtr handle) : base (handle)
        {
        }

       public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.lblSobreMi.Text = Miembro.Usuario_Descripcion;
            this.Etiquetas = Miembro.Etiquetas;
            foreach(EtiquetaModel Etiqueta in Etiquetas)
            {
                if (Etiqueta.Etiqueta_Tipo == "HABILIDAD")
                {
                    EtiquetasHabilidades.Add(Etiqueta);
                }
                else if (Etiqueta.Etiqueta_Tipo == "INTERES")
                {
                    EtiquetasIntereses.Add(Etiqueta);
                }
            }
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "Habilidades")
            {
                var VistaHabilidades = (HabilidadesCollectionView)segue.DestinationViewController;
                VistaHabilidades.EtiquetasHabilidades = EtiquetasHabilidades;
            }
            else if (segue.Identifier == "Intereses")
            {
                var VistaIntereses = (InteresesCollectionView)segue.DestinationViewController;
                VistaIntereses.EtiquetasIntereses = EtiquetasIntereses;
            }
        }

       


    }
}