using System.Text.RegularExpressions;

namespace EducationCenter.Service.Common.Validators;

public class EmailValidator
{
    public static (bool IsSuccessful, string ErrorMessage) IsValid(string email)
    {
        string regexExpression = @"^([a-zA-Z0-9_\-\.]+)
                        @((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)
                        |(([a-zA-Z0-9_\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})
                        (\]?)$";
        bool iscorrect =  Regex.IsMatch(email, regexExpression, RegexOptions.ECMAScript);
        if (iscorrect) return (IsSuccessful: true, Message: "");
        else return (IsSuccessful: false, Message: "Email is not valid");
    }
}
