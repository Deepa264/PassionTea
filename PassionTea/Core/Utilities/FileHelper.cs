using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Utilities
{
   static class FileHelper
    {
        public static String GetScreenShotPath()
        {
            var requiredPath = Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase));
            requiredPath = requiredPath.Replace("file:\\", String.Empty);
            requiredPath = Path.Combine(requiredPath, "ScreenShots");

            if (!Directory.Exists(requiredPath))
            {
                Directory.CreateDirectory(requiredPath);
            }
            requiredPath += @"\";
            return requiredPath;
        }
        public static void DeleteScreenshotFolder()
        {
            var requiredPath = GetScreenShotPath();
            if (!Directory.Exists(requiredPath))
            {
                Directory.Delete(requiredPath,true);
            }

        }
    }
}
