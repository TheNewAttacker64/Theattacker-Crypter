using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stubcry
{
    internal class config
    {
        public static bool istartup = false;
        public static bool ispersist = false;
        public static bool istask = false;
        public static bool isdotnet = false;
        public static bool isexcludewd = false;
        public static bool issleep = false;
        public static string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "$FOLDER");
        public static string FileName = "$FNAME" + ".exe";
        public static string servicename = "$service";
        public static string fullpath = Path.Combine(folder, FileName);
        public static string  ePath = Process.GetCurrentProcess().MainModule.FileName;
        public static int taskm = 0;
        public static int sleeptime = 1*1000;

    }
}
