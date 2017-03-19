using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE.utils
{
    public class JSONRulesReader
    {
        public string RULE_ROUTE { get; set; }

        public void read()
        {
            using (StreamReader r = new StreamReader(@"D:\Storage\FIA UES\project\QA_ANDROID\FIA_APK_QA\QA_FIA_APK_CONSOLE\VerificationRules\generated (1).json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject(json);
            }
        }
    }
}
