using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
//using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{

    public interface ColoniaSeleccionada
    {
        void ColoniaSeleccionada(string Colonia);
    }

    public partial class ColoniaViewController : UIViewController
    {

        public ColoniaSeleccionada ColoniaSeleccionadaDel;

        public List<string> Colonias = new List<string>();

        UILabel selectedLbl = new UILabel();
      
        public ColoniaViewController (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            string[] ArrayColonias = Colonias.ToArray();
            selectedLbl.Text = ArrayColonias[0];
            this.dtpColonia.Model = new StackOverflowModel(ArrayColonias, selectedLbl);
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var color = new UIColor(0, 0.0f);
            this.View.BackgroundColor = color;
        }

        partial void btnSeleccionar_TouchUpInside(UIButton sender)
        {
            this.ColoniaSeleccionadaDel.ColoniaSeleccionada(selectedLbl.Text);
            this.DismissViewController(true, null);
        }

        partial void btnCancelar_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        public class StackOverflowModel : UIPickerViewModel
        {
            string[] Colonias;
            public UILabel lbl;

            public StackOverflowModel(string[] colonias, UILabel Colonia)
            {
                this.Colonias = colonias;
                lbl = Colonia;
            }

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 1;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                return Colonias.Length;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                return Colonias[row];
            }

            public override void Selected(UIPickerView pickerView, nint row, nint component)
            {
                lbl.Text = String.Format("{0}", Colonias[pickerView.SelectedRowInComponent(0)]);
            }

        }
    }

}