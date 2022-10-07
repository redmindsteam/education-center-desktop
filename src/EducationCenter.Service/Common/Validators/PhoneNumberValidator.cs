using System.Text.RegularExpressions;

namespace EducationCenter.Service.Common.Validators
{
    public class PhoneNumberValidator
    {
        public static (bool IsSuccessful, string ErrorMessage) IsValid(string phoneNumber)
        {
            string regexExpression = @"^[+998]{4}[0-9]{9}$";
            bool isuccess =  Regex.IsMatch(phoneNumber, regexExpression, RegexOptions.ECMAScript);
            if (isuccess) return (IsSuccessful: true, Message: "");
            else return (IsSuccessful: false, Message: "Phone number is not valid");
        }
    }
}