using Business.Utils;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Business.Extensions
{
    internal static class ImageExtension
    {
        public static void DeleteImage(this string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static string SaveImage(this byte[] byteArray, ImageTypes ImageType, int id)
        {
            var fileName = $"{id}.Png";
            var paths = GetPath(ImageType);

            using (var stream = new MemoryStream(byteArray))
            {
                using (var bm = new Bitmap(Image.FromStream(stream), 300, 300))
                {
                    bm.SetResolution(96, 96);
                    bm.Save(Path.Combine(paths.Item2, fileName), ImageFormat.Png);
                }
            }

            return Path.Combine(paths.Item1, fileName);
        }

        public static byte[] ToImage(this string path)
        {
            if (string.IsNullOrEmpty(path)) return null;
            var file = Path.Combine(Directory.GetCurrentDirectory(), path);
            return !File.Exists(file) ? null : File.ReadAllBytes(file);
        }

        private static Tuple<string, string> GetPath(ImageTypes imageType)
        {
            var folder = string.Empty;
            switch (imageType)
            {
                case ImageTypes.User:
                    folder = @"Resources\\Users";
                    break;
                case ImageTypes.Category:
                    folder = @"Resources\\Categories";
                    break;
                case ImageTypes.Product:
                    folder = @"Resources\\Products";
                    break;
                case ImageTypes.Table:
                    folder = @"Resources\\Tables";
                    break;
                case ImageTypes.Restaurant:
                    folder = @"Resources\\Restaurant";
                    break;
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), folder);
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            return Tuple.Create(folder, path);
        }
    }
}
