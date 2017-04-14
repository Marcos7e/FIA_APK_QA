using QA_FIA_APK_CONSOLE.core.Verificables;
using QA_FIA_APK_CONSOLE.utils;
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
            JSONRulesReader jra = new JSONRulesReader(@"D:\Storage\FIA UES\project\QA_ANDROID\FIA_APK_QA\QA_FIA_APK_CONSOLE\VerificationRules\Android");
            var files = jra.METRIC_FILES;
            jra.read();
        }
    }
}
