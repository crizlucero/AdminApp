using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{

    public interface PlazosInterface
    {
        void PlazoSeleccionado(string Plazo);
    }

    public partial class PlazosViewController : UIViewController
    {

        public PlazosInterface PlazosDelegate;

        UILabel selectedLbl = new UILabel();

        public PlazosViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.pcvPlazos.Model = new ListadoPlazos(selectedLbl);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        partial void btnSleccionar_Touch(UIButton sender)
        {
            this.PlazosDelegate.PlazoSeleccionado(selectedLbl.Text);
            this.DismissViewController(true, null);
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }


        public class ListadoPlazos : UIPickerViewModel
        {
            static string[] names = new string[]
            {
                "06 MESES",
                "12 MESES",
                "24 MESES",
                "36 MESES"
            };

            UILabel lbl;

            public ListadoPlazos(UILabel lbl)
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