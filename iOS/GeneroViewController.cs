using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface GeneroSeleccionado
    {
        void GeneroSeleccionado(string Genero);
    }

    public partial class GeneroViewController : UIViewController
    {
        public GeneroSeleccionado GeneroSeleccionadoDelegato;

        UILabel selectedLbl = new UILabel();

        public string Nombre = "";

        public GeneroViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            selectedLbl.Text = "Masculino";
            this.dtpGenero.Model = new StackOverflowModel(selectedLbl);

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var color = new UIColor(0, 0.0f);
            this.View.BackgroundColor = color;
        }

        partial void btnCancelar_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnSeleccionar_TouchUpInside(UIButton sender)
        {
            this.GeneroSeleccionadoDelegato.GeneroSeleccionado(selectedLbl.Text);
            this.DismissViewController(true, null);
        }

        public class StackOverflowModel : UIPickerViewModel
        {
            static string[] names = new string[] 
            {
                "Masculino",
                "Femenino"
            };

            UILabel lbl;

            public StackOverflowModel(UILabel lbl)
            {
                this.lbl = lbl;
            }

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 1;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                return names.Length;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                return names[row];
            }

            public override void Selected(UIPickerView pickerView, nint row, nint component)
            {
                lbl.Text = String.Format("{0}", names[pickerView.SelectedRowInComponent(0)]);
                
            }
        }
    }
}


