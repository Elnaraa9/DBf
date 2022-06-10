using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helpers
{
    public static class Extension
    {
        public static bool CheckFileSize(this IFormFile file, int kb)
        {
            return file.Length / 1024 <= kb;
        }
        public static bool CheckFileType(this IFormFile file,string type)
        {
            return file.ContentType.Contains(type);
        }
        public static string SaveFile(this IFormFile file,string root,params string[] folders)
        {
            var fileName = Guid.NewGuid().ToString() + file.FileName;
            var resultPath = Path.Combine(root, "img", fileName);
            using (FileStream fileStream =
                new FileStream(resultPath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            return fileName
        }
    }
}
