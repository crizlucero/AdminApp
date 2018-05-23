using System;
using Java.Util;

namespace WorklabsMx.Droid.Helpers
{
    public class CalendarHelper
    {
        public long GetDateTimeMS(int year, int month, int day, int hr, int min)
        {
            Calendar c = Calendar.GetInstance(Java.Util.TimeZone.Default);

            c.Set(CalendarField.DayOfMonth, day);
            c.Set(CalendarField.HourOfDay, hr);
            c.Set(CalendarField.Minute, min);
            c.Set(CalendarField.Month, month);
            c.Set(CalendarField.Year, year);

            return c.TimeInMillis;
        }

        public string GetDate(long millis)
        {
            Calendar c = Calendar.GetInstance(Java.Util.TimeZone.Default);
            c.TimeInMillis = millis;
            int dia = c.Get(CalendarField.DayOfMonth);
            int mes = c.Get(CalendarField.Month);
            int year = c.Get(CalendarField.Year);

            return string.Format("{0:D2}/{1:D2}/{2}",dia,mes,year);
        }

        public static DateTime RoundUp(DateTime dt, TimeSpan d) => new DateTime(((dt.Ticks + d.Ticks - 1) / d.Ticks) * d.Ticks);
    }
}
