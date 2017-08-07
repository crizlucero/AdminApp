using System;
using System.Collections.Generic;
using UIKit;

namespace WorklabsMx.iOS.Styles
{
    public class PickerDataModel : UIPickerViewModel
    {
        public event EventHandler<EventArgs> ValueChanged;

        public List<string> Items { get; private set; }

        /// <summary>
        /// The current selected item
        /// </summary>
        public string SelectedItem => Items[selectedIndex];

        int selectedIndex = 0;

        public PickerDataModel()
        {
            Items = new List<string>();
        }

        /// <summary>
        /// Called by the picker to determine how many rows are in a given spinner item
        /// </summary>
        public override nint GetRowsInComponent(UIPickerView pickerView, nint component) => Items.Count;


        /// <summary>
        /// called by the picker to get the text for a particular row in a particular
        /// spinner item
        /// </summary>
        public override string GetTitle(UIPickerView pickerView, nint row, nint component) => Items[(int)row];


        /// <summary>
        /// called by the picker to get the number of spinner items
        /// </summary>
        public override nint GetComponentCount(UIPickerView pickerView) => 1;

        /// <summary>
        /// called when a row is selected in the spinner
        /// </summary>
        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            selectedIndex = (int)row;
            ValueChanged?.Invoke(this, new EventArgs());
        }
    }
}
