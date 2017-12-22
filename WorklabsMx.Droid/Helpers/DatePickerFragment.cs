using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace WorklabsMx.Droid.Helpers
{
    public class DatePickerFragment : DialogFragment, DatePickerDialog.IOnDateSetListener
    {

        Action<DateTime> _dateSelectedHandler = delegate { };

        public static DatePickerFragment NewInstance(Action<DateTime> onDateSelected)
        {
            DatePickerFragment frag = new DatePickerFragment
            {
                _dateSelectedHandler = onDateSelected
            };
            return frag;
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            DateTime currently = DateTime.Now;
            DatePickerDialog dialog = new DatePickerDialog(Activity, this, currently.Year, currently.Month - 1, currently.Day);
            dialog.DatePicker.MinDate = new CalendarHelper().GetDateTimeMS(currently.Year, currently.Month - 1, currently.Day, 0, 0);
            return dialog;
        }

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            DateTime selectedDate = new DateTime(year, month + 1, dayOfMonth);
            _dateSelectedHandler(selectedDate);
        }
    }
}
