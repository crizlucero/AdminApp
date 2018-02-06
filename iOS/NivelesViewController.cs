using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface NivelSeleccionado
    {
        void NivelSeleccionado(string Nivel);
    }

    public partial class NivelesViewController : UIViewController
    {

        public NivelSeleccionado NivelSeleccionadoDel;

        UILabel selectedLbl = new UILabel();

        public NivelesViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            selectedLbl.Text = "Masculino";
            this.pcvNiveles.Model = new ListadoNiveles(selectedLbl);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var color = new UIColor(0, 0.0f);
            this.View.BackgroundColor = color;
        }

        partial void btnSeleccionar_Touch(UIButton sender)
        {
            this.NivelSeleccionadoDel.NivelSeleccionado(selectedLbl.Text);
            this.DismissViewController(true, null);
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        public class ListadoNiveles : UIPickerViewModel
        {
            static string[] names = new string[]
            {
                "NIVEL 1",
                "NIVEL 2",
                "NIVEL 3",
                "NIVEL 4",
                "NIVEL 5",
                "NIVEL 6",
                "NIVEL 7",
            };

            UILabel lbl;

            public ListadoNiveles(UILabel lbl)
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