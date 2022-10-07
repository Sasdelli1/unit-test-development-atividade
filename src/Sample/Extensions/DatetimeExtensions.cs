using System;

namespace Sample.Extensions
{
    public static class DatetimeExtensions
    {
        public static string ToStringShortPtBR(this DateTime date)
        {
            if (date == DateTime.MinValue)
                throw new ArgumentNullException();

            return date.ToString("dd/MM/yyyy");
        }

        public static string ToStringPtBR(this DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
