using System;
using System.Collections.Generic;
using UIKit;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS.Models
{
    public class SucursalesModel : UIPickerViewModel
    {
        PickerItemsController items = new PickerItemsController();

        List<string> Sucursales = new List<string>();


        public SucursalesModel()
        {
            Sucursales = items.GetSucursales();
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return Sucursales.Count;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            return Sucursales[row.GetHashCode()].ToString();
        }
    }
}
