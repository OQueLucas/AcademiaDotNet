using System.Text.RegularExpressions;

namespace POOAlexandre
{
    internal class Utilidades
    {
        public static bool EmailIsValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";

            return Regex.IsMatch(email, pattern);
        }
    }
}
