using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE.utils
{
    public class ClassTextReader
    {
        public string CLASS_ROUTE { get; set; }
        public string READED_CLASS { get; set; }
        Logger l;

        public ClassTextReader(string route)
        {
            CLASS_ROUTE = route;
            ReadClassData();
        }

        private string ReadFile()
        {
            try
            {
                return File.ReadAllText(CLASS_ROUTE);
            }
            catch (Exception e)
            {
                l = new Logger();
                l.WriteInLog(e);
                return string.Empty;
            }
        }
        private bool ReadClassData()
        {
            try
            {
                if (File.Exists(CLASS_ROUTE))
                {
                    READED_CLASS = ReadFile();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                l = new Logger();
                l.WriteInLog(e);
                return false;
            }
        }

        

    }
}
