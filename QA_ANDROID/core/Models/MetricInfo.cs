using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE.core.Models
{
    public class MetricInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Operation { get; set; }
        public string File { get; set; }
        public bool Result { get; set; }
        public int? Times { get; set; }
    }
}
