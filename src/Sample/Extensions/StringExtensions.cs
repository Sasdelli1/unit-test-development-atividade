using System.Text.RegularExpressions;

namespace Sample.Extensions
{
    public static class StringExtensions
    {
        public static bool IsValidMail(this string email)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            return validateEmailRegex.IsMatch(email);
        }
    }
}
