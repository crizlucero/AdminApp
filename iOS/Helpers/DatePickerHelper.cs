using System;
using Foundation;

namespace WorklabsMx.iOS.Helpers
{
    public class DatePickerHelper
    {
        public DatePickerHelper()
        {
        }

        public static NSDate GetDate(string date) => (NSDate)DateTime.SpecifyKind(Convert.ToDateTime(date), DateTimeKind.Local);

    }
}
