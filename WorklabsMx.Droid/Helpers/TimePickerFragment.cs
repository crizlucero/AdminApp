using System;
using Android.App;
using Android.OS;
using Android.Text.Format;
using Android.Widget;

namespace WorklabsMx.Droid.Helpers
{
    public class TimePickerFragment : DialogFragment, TimePickerDialog.IOnTimeSetListener
    {
        public static readonly string TAG = "MyTimePickerFragment";
        Action<DateTime> timeSelectedHandler = delegate { };

        public static TimePickerFragment NewInstance(Action<DateTime> onTimeSelected)
        {
            TimePickerFragment frag = new TimePickerFragment
            {
                timeSelectedHandler = onTimeSelected
            };
            return frag;
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState) => new TimePickerDialog(Activity, this, DateTime.Now.Hour, DateTime.Now.Minute, DateFormat.Is24HourFormat(Activity));

        public void OnTimeSet(TimePicker view, int hourOfDay, int minute) => timeSelectedHandler(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hourOfDay, minute, 0));
    }
}
