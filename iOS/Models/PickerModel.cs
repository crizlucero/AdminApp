using System;
using System.Collections.Generic;
using UIKit;

namespace WorklabsMx.iOS.Models
{
    public class PickerModel : UIPickerViewModel
    {
        List<string> _items;
        protected int selectedIndex = 0;
        public PickerModel(List<string> items) => _items = items;

        public string SelectedItem => _items[selectedIndex];

        public override nint GetComponentCount(UIPickerView pickerView) => 1;

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component) => _items.Count;

        public override string GetTitle(UIPickerView pickerView, nint row, nint component) => _items[(int)row];


        public override void Selected(UIPickerView pickerView, nint row, nint component) => selectedIndex = (int)row;

    }
}
