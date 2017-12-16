using Java.Util;

namespace WorklabsMx.Droid.Helpers
{
    public class CalendarHelper 
    {
        public long GetDateTimeMS(int year, int month, int day, int hr, int min)
        {
            Calendar c = Calendar.GetInstance(TimeZone.Default);

            c.Set(CalendarField.DayOfMonth, day);
            c.Set(CalendarField.HourOfDay, hr);
            c.Set(CalendarField.Minute, min);
            c.Set(CalendarField.Month, month);
            c.Set(CalendarField.Year, year);

            return c.TimeInMillis;
        }
    }
}
