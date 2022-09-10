using System.Text.RegularExpressions;

namespace EducationCenter.Service.Common.Validators;

public class EmailValidator
{
    public static bool IsValid(string email)
    {
        string regexExpression = @"^([a-zA-Z0-9_\-\.]+)
                        @((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)
                        |(([a-zA-Z0-9_\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})
                        (\]?)$";

        return Regex.IsMatch(email, regexExpression, RegexOptions.ECMAScript);
    }
}
