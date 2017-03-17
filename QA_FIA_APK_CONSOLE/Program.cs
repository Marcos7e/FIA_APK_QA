using QA_FIA_APK_CONSOLE.core.Verificables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

            AndroidVerification av = new AndroidVerification();
            av.LoadMetrics(); 

        }
    }
}
