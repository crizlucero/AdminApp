using System;
namespace WorklabsMx.Helpers
{
    public class DateHelper
    {
        public static double GetMonthsDays(DateTime date) =>
             (new DateTime(date.Year, date.Month, 1)).AddMonths(1).AddDays(-1).Day;

        public static double CalcularCreditos(string hora_inicio, string hora_fin)
        {
            double horas = DateTime.Parse(hora_fin).Subtract(DateTime.Parse(hora_inicio)).TotalHours * 2;
            DateTime hora_inicial = DateTime.Parse(hora_inicio);
            DateTime hora_final = DateTime.Parse(hora_fin);
            double tiempo = 0;
            for (double i = 0; i < horas; i += .5)
            {
                if (hora_inicial.Hour > 11 && hora_inicial.Hour < 17)
                {
                    if (hora_final != hora_inicial)
                    {
                        tiempo += .5;
                        hora_inicial = hora_inicial.AddMinutes(30);
                    }
                    else break;
                }
                else break;
            }
            return horas + tiempo;
        }
    }
}
