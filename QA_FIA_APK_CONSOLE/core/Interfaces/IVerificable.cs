using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE.core.Interfaces
{
    public interface IVerificable
    {
        string METRIC_ROUTE { get; set; }
        string SOURCE_ROUTE { get; set; }
        List<string> MetricFiles { get; set; }
        List<string> SourceFiles { get; set; }

        bool LoadMetrics();
        bool LoadSource();


    }
}
