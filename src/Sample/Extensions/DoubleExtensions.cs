using System.Globalization;

namespace Sample.Extensions
{
    public static class DoubleExtensions
    {
        public static string ToStringMoneyPtBR(this double value)
        {
            return string.Format(new CultureInfo("pt-BR"), "{0:C}", value);
        }
    }
}
