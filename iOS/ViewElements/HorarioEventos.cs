using System;
using CoreGraphics;
using UIKit;

namespace WorklabsMx.iOS.ViewElements
{
    public class HorarioEventos : UIScrollView
    {
        public HorarioEventos()
        {
            Frame = new CGRect(0, UIScreen.MainScreen.Bounds.Height / 2, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height / 2);
            BackgroundColor = UIColor.White;
            Hidden = true;

            GenerarHorarios();
        }

        void GenerarHorarios()
        {
            int size = 0;
            for (int i = 0; i < 24; ++i)
            {
                UILabel lblHora = new UILabel
                {
                    Text = TimeSpan.FromHours(i).ToString("hh':'mm"),
                    Frame = new CGRect(0, 30 + size, 70, 100)
                };
                lblHora.Layer.BorderWidth = 1;
                lblHora.Layer.BorderColor = UIColor.LightGray.CGColor;
                Add(lblHora);
                UIView viewEvent = new UIView
                {
                    Frame = new CGRect(0, 30 + size, UIScreen.MainScreen.Bounds.Width, 100)
                };
                viewEvent.Layer.BorderWidth = 1;
                viewEvent.Layer.BorderColor = UIColor.LightGray.CGColor;
                Add(viewEvent);
                size += 100;
            }
            ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, size);
            ContentOffset = new CGPoint(0, 930);
        }
    }
}
