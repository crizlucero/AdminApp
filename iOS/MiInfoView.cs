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
    public partial class MiInfoView : UIViewController
    {
        public UsuarioModel Miembro = new UsuarioModel();
        public List<EtiquetaModel> Etiquetas;

        List<EtiquetaModel> EtiquetasHabilidades = new List<EtiquetaModel>();
        List<EtiquetaModel> EtiquetasIntereses = new List<EtiquetaModel>();

        public MiInfoView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.lblMidescripcion.Text = (Miembro.Usuario_Descripcion != "" && Miembro.Usuario_Descripcion != null) ? Miembro.Usuario_Descripcion : "Sin Info";
            this.Etiquetas = Miembro.Etiquetas;
            if (this.Etiquetas != null)
            {
                foreach (EtiquetaModel Etiqueta in Etiquetas)
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