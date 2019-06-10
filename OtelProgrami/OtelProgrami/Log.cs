using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
namespace OtelProgrami
{
    class Log
    {
        public void logOlustur(string log, string zaman)
        {
            StreamWriter yazici = new StreamWriter("Log.txt", append: true);
            yazici.WriteLine(log + " " + zaman);
            yazici.Close();
        }
    }
}
