using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QA_FIA_APK_CONSOLE.core.LanguageData.VerifyAction;

namespace QA_FIA_APK_CONSOLE.core.Models
{
    public class Metric
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> SearchIn { get; set; }
        public string Operation { get; set; }
        public int? Times { get; set; }
        public List<string> Value { get; set; }

        public Metric()
        {
            SearchIn = new List<string>();
            Value = new List<string>();
        }
    }
}
