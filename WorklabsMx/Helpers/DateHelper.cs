using System;
namespace WorklabsMx.Helpers
{
    public class DateHelper
    {
        public static double GetMonthsDays(DateTime date) =>
             (new DateTime(date.Year, date.Month, 1)).AddMonths(1).AddDays(-1).Day;
    }
}
