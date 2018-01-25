using System;
using UIKit;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS
{

    public interface SucursalSeleccionada
    {
        void SucursalSeleccionada(string Sucursal);
    }

    public interface SucursalCancelada
    {
        void SucursalCancelada();
    }

    public partial class SucursalesViewController : UIViewController
    {
        
        public SucursalSeleccionada SucursalSeleccionadaDel;
        public SucursalCancelada SucursalCanceladaDel;

        UILabel selectedLbl = new UILabel();

        public SucursalesViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PickerItemsController items = new PickerItemsController();
            string[] arrSucursales = items.GetSucursales().ToArray();
            selectedLbl.Text = arrSucursales[0];
            pcvSucursales.Model = new StackOverflowModel(arrSucursales, selectedLbl);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        partial void btnSeleccionar_Touch(UIButton sender)
        {
            this.SucursalSeleccionadaDel.SucursalSeleccionada(selectedLbl.Text);
            this.DismissViewController(true, null);
        }

        partial void btnCancelar_Touch(UIButton sender)
        {
            this.SucursalCanceladaDel.SucursalCancelada();
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