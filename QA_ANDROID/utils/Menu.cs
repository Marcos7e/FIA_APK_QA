using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE.utils
{
    static public class Menu
    {
        static public void Hello()
        {
            Console.WriteLine($"QA_FIA_APK_CONSOLE { System.Reflection.Assembly.GetExecutingAssembly().GetName().Version} - Inicio: {DateTime.Now}");
            Console.WriteLine();
        }
    }
}
