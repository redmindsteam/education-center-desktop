using System;

namespace EducationCenter.Service.Common.Validators
{
    public class NameValidator 
    {
        public static (bool IsSuccessful, string ErrorMessage) IsValid(string name)
        {
            return (IsSuccessful: true, ErrorMessage: "");
        }
    }
}