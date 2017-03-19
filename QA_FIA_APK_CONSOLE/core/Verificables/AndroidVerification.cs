using QA_FIA_APK_CONSOLE.core.Interfaces;
using QA_FIA_APK_CONSOLE.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE.core.Verificables
{
    public class AndroidVerification : IVerificable
    {
        public Logger l;

        public List<string> MetricFiles { get; set; }
        public string METRIC_ROUTE { get; set; } = @"C:\Users\Usuario\Documents\BE10003\Metricas";
        public List<string> SourceFiles { get; set; }
        public string SOURCE_ROUTE { get; set; }

        public bool LoadMetrics()
        {
            try
            {
                if (!Directory.Exists(METRIC_ROUTE))
                    return false;

                SourceFiles = Directory.GetFiles(METRIC_ROUTE).ToList();
                return true;
            }
            catch (Exception e)
            {
                l = new Logger();
                l.WriteInLog(e);
                return false;
            }
        }

        public bool LoadSource()
        {
            throw new NotImplementedException();
        }

        public bool StartVerification()
        {
            throw new NotImplementedException();
        }
    }
}
