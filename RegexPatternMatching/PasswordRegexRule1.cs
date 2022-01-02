using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    public class PasswordRegexRule1
    {
        public static string PASS_REGEX_RULE1 = "^[A-Z a-z]{8,}$"; 

        public bool ValidatePasswordRule1(string password)
        {
            return Regex.IsMatch(password, PASS_REGEX_RULE1);
        }
    }
}
