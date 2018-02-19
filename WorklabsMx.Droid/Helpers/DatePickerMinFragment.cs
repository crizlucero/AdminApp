using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace WorklabsMx.Droid.Helpers
{
    public class DatePickerMinFragment : DialogFragment, DatePickerDialog.IOnDateSetListener
    {
        Action<DateTime> _dateSelectedHandler = delegate { };

        public static DatePickerMinFragment NewInstance(Action<DateTime> onDateSelected)
        {
            DatePickerMinFragment frag = new DatePickerMinFragment
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

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth) => _dateSelectedHandler(new DateTime(year, month + 1, dayOfMonth));
    }
}
