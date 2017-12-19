using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class SeleccionarSalaJuntasViewController : UIViewController
    {
        public SeleccionarSalaJuntasViewController (IntPtr handle) : base (handle)
        {
        }

        nfloat h = 50.0f;
        nfloat w = 50.0f;
        nfloat padding = 10.0f;
        nint n = 5;


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.svSeleccionarSalaJuntas.CanCancelContentTouches = false;
            this.svSeleccionarSalaJuntas.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            this.svSeleccionarSalaJuntas.ClipsToBounds = false;
            this.svSeleccionarSalaJuntas.ScrollEnabled = true;
            this.svSeleccionarSalaJuntas.PagingEnabled = true;

            //this.scvScrollSalasJuntas.ContentSize = new CGSize(scvScrollSalasJuntas.Frame.Width, scvScrollSalasJuntas.Frame.Height);
            Console.WriteLine(svSeleccionarSalaJuntas.ContentSize);
            nfloat with = 0;
            nfloat ImageX = 0;
            for (int i = 0; i < n; i++)
            {
                imgSalasJuntas.Frame = new CGRect(ImageX, imgSalasJuntas.Frame.Y, imgSalasJuntas.Frame.Width, imgSalasJuntas.Frame.Height);
                imgSalasJuntas.Image = UIImage.FromBundle("ImagenSala");
               
                //scvScrollSalasJuntas.AddSubview(imgSalaJuntas);
                with = with + imgSalasJuntas.Frame.Width;
                ImageX = ImageX + imgSalasJuntas.Frame.Width;

            }
            this.svSeleccionarSalaJuntas.ContentSize = new CGSize(with, svSeleccionarSalaJuntas.Frame.Height);
            //this.scvScrollSalasJuntas.Frame = new CGRect(this.scvScrollSalasJuntas.Frame.X, this.scvScrollSalasJuntas.Frame.Y, with, this.scvScrollSalasJuntas.Frame.Height);
            //this.vwVistaSalas.Frame = new CGRect(this.vwVistaSalas.Frame.X, this.vwVistaSalas.Frame.Y, with, this.vwVistaSalas.Frame.Height);
            svSeleccionarSalaJuntas.AddSubview(this.vwVistaSeleccionSalaJuntas);
            //this.scvScrollSalasJuntas.ContentSize = new CGSize(with, scvScrollSalasJuntas.Frame.Height + 10);
            Console.WriteLine(svSeleccionarSalaJuntas.ContentSize);
        }

        partial void btnAtras_Touch(UIButton sender)
        {
            
        }

        partial void btnAdelante_Touch(UIButton sender)
        {
            
        }
    }
}