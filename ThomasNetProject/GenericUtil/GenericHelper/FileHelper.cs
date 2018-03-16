using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasNetProject.GenericUtil.GenericHelper
{
    public class FileHelper
    {

        public static string getlatestFilePath(string folder)
        {
            var files = new DirectoryInfo(folder).GetFiles("*.*");
            string latestfile = "";
            DateTime lastupdated = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdated)
                {
                    lastupdated = file.LastWriteTime;
                    latestfile = file.FullName;
                }
            }
            return latestfile;
        }

        public static string getlatestFileextension(string folder)
        {
            var files = new DirectoryInfo(folder).GetFiles("*.*");
            string latestfile = "";
            DateTime lastupdated = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdated)
                {
                    lastupdated = file.LastWriteTime;
                    latestfile = file.Extension;
                }
            }
            return latestfile;
        }
    }
}
