using System;

namespace EducationCenter.Domain.Common
{
    public class BaseResponse<T>
    {
        public bool IsSuccessful { get; set; } = true;

        public string ErrorMessage { get; set; } = String.Empty;

        public T Data { get; set; }
    }
}