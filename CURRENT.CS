using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace ShutdownClock
{
    class Current
    {
        public static string Readme = "Remember not to deleting or editing any files in this folder!" + Environment.NewLine + "Program will not work then!!!" ;

        //change these values during update a code
        public static string Version = "137";
        public static int Update_nr = 3;
        public static int Update_new = 3;

        public static string Ver_label = "1.3.7";

        public static bool Update_available = false;

        public static void ReadmeCreateFile()
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "/data/profiles/README!!!.txt", Readme);
            
        }
        public static bool GrantSourceAccess(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
            return true;
        }

        public static void Update_Check(int current)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://zonesoftwares.com/updates/sc/columns/num.cse");
            StreamReader reader = new StreamReader(stream);
            string numeric = reader.ReadToEnd();
            int num = Convert.ToInt32(numeric);
            if(num > Update_nr)
            {
                Update_new = num;
                Update_available = true;
            }
        }

        // for mysql to zapleciny:
        // server=zapleciny.pl
        // uid=zapleciny_bd
        // passwd=****
        // database=zapleciny !!
    }
}
