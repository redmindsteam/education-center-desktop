using System;

namespace EducationCenter.Service.Interfaces.Common
{
    public interface IFileService
    {
        public Task<(bool IsSuccessful, string Message)> CopyToAsync(string oldpath, string newpath);

        public Task<(bool IsSuccessful, string Message)> CopyImageAsync(string path);
    }
}