using System;
using UIKit;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.Styles;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class BusquedasController : UIViewController
    {
        public BusquedasController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var localStorage = SimpleStorage.EditGroup("Busqueda");
            switch (localStorage.Get("origen"))
            {
                case "DirectorioUsuarios": break;
                case "MisColaboradores": break;
                case "DirectorioEmpresas": break;
            }
        }

        void CreateUserFilter()
        {
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                scrollView.Add(new STLLabel("Nombre", 170));
                scrollView.Add(new STLTextField("Nombre", 200));

                scrollView.Add(new STLLabel("Apellidos", 230));
                scrollView.Add(new STLTextField("Apellidos", 260));

                scrollView.Add(new STLLabel("Puesto", 290));
                scrollView.Add(new STLTextField("Puesto", 320));

                scrollView.Add(new STLLabel("Profesión", 350));
                scrollView.Add(new STLTextField("Profesión", 380));

                scrollView.Add(new STLLabel("Habilidades", 410));
                scrollView.Add(new STLTextField("Habilidades", 440));
                View.AddSubview(scrollView);
            }
        }
    }
}