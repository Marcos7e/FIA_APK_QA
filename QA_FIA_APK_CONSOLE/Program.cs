using QA_FIA_APK_CONSOLE.core.LanguageData;
using QA_FIA_APK_CONSOLE.core.Models;
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
            JSONRulesReader jra = new JSONRulesReader(@"D:\Storage\FIA UES\project\QA_ANDROID\FIA_APK_QA\QA_FIA_APK_CONSOLE\VerificationRules\Android");
            ClassTextReader ctr = new ClassTextReader(@"C:\Users\Marcos\Desktop\IVerificable.cs");
            VerifyAction va = new VerifyAction(jra.METRIC_DATA);

            var files = jra.METRIC_FILES;
            jra.read();
            var metricInfo = va.StartVerifications();

            foreach (MetricInfo info in metricInfo)
            {
                Console.WriteLine("======================================");
                Console.WriteLine($"Metrica: {info.Name}");
                Console.WriteLine($"Descripción: {info.Description}");
                Console.WriteLine($"Operación: {info.Operation}");
                Console.WriteLine($"Archivo: {info.File}");
                Console.WriteLine($"Resultado: {info.Result}");
            }
            Console.ReadKey();
        }
    }
}
