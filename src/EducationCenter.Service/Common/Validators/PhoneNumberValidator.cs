using System.Text.RegularExpressions;

namespace EducationCenter.Service.Common.Validators
{
    public class PhoneNumberValidator
    {
        public static bool IsValid(string phoneNumber)
        {
            string regexExpression = @"^[+998]{4}[0-9]{9}$";
            return Regex.IsMatch(phoneNumber, regexExpression, RegexOptions.ECMAScript);
        }
    }
}