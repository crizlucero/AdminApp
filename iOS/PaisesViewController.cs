using Foundation;
using System;
using UIKit;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS
{

    public interface Pais
    {
        void PaisSeleccionado(string Pais);
    }

    public partial class PaisesViewController : UIViewController
    {
        
        public Pais PaisDelegate;

        UILabel selectedLbl = new UILabel();

        public PaisesViewController(IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PickerItemsController items = new PickerItemsController();
            string[] arrSucursales = items.GetPaises().ToArray();
            selectedLbl.Text = arrSucursales[0];
            pcvSucursales.Model = new StackOverflowModel(arrSucursales, selectedLbl);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnSeleccionar_Touch(UIButton sender)
        {
            this.PaisDelegate.PaisSeleccionado(selectedLbl.Text);
            this.DismissViewController(true, null);
        }

        public class StackOverflowModel : UIPickerViewModel
        {
            string[] Sucursales;
            public UILabel lbl;

            public StackOverflowModel(string[] Sucursales, UILabel Colonia)
            {
                this.Sucursales = Sucursales;
                lbl = Colonia;
            }

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 1;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                return Sucursales.Length;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                return Sucursales[row];
            }

            public override void Selected(UIPickerView pickerView, nint row, nint component)
            {
                lbl.Text = String.Format("{0}", Sucursales[pickerView.SelectedRowInComponent(0)]);
            }

        }

    }
}