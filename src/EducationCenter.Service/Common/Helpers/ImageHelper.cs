using System;

namespace EducationCenter.Service.Common.Helpers
{
    public class ImageHelper
    {
        public static string MakeImageName(string filename)
        {
            string extension = Path.GetExtension(filename);
            return "IMG_" + Guid.NewGuid().ToString()+extension;
        }
    }
}