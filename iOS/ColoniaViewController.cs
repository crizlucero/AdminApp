using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using PerpetualEngine.Storage;
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

        string Colonia = "";
      
        public ColoniaViewController (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            string[] ArrayColonias = Colonias.ToArray();
            Colonia = ArrayColonias[0];
            this.dtpColonia.Model = new StackOverflowModel(ArrayColonias, Colonia);

        }

        partial void btnSeleccionar_TouchUpInside(UIButton sender)
        {
            this.ColoniaSeleccionadaDel.ColoniaSeleccionada(Colonia);
            this.DismissViewController(true, null);
        }

        partial void btnCancelar_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        public class StackOverflowModel : UIPickerViewModel
        {
            string[] Colonias;
            string Colonia;

            public StackOverflowModel(string[] colonias, string Colonia)
            {
                this.Colonias = colonias;
                this.Colonia = Colonia;
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
                Colonia = String.Format("{0}", Colonias[pickerView.SelectedRowInComponent(0)]);

            }
        }
    }

}