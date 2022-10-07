using EducationCenter.Service.Common.Helpers;
using EducationCenter.Service.Interfaces.Common;
using System;

namespace EducationCenter.Service.Services.Common
{
    public class FileService : IFileService
    {
        private readonly string _imagesPath = "images";

        public async Task<(bool IsSuccessful, string Message)> CopyImageAsync(string path)
        {
            if (!File.Exists(path))
                return (IsSuccessful: false, Message: "Selected image is not found");
            byte[] image = await File.ReadAllBytesAsync(path);
            string partpath = Path.Combine(_imagesPath, ImageHelper.MakeImageName(path));
            try
            { await File.WriteAllBytesAsync(partpath, image); }
            catch
            {
                return (IsSuccessful: false, Message: "Image not fetched");
            }
            return (IsSuccessful: true, Message: partpath);
        }

        public async Task<(bool IsSuccessful, string Message)> CopyToAsync(string oldpath, string newpath)
        {
            throw new NotImplementedException();
        }
    }
}