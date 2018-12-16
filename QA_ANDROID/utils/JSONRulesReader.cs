using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QA_ANDROID.core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_ANDROID.utils
{
    public class JSONRulesReader
    {
        public string RULE_ROUTE { get; set; }
        public List<string> METRIC_FILES { get; set; }
        public List<Metric> METRIC_DATA { get; set; }
        public Logger l;

        public JSONRulesReader()
        {
            METRIC_FILES = new List<string>();
            METRIC_DATA = new List<Metric>();
        }
        public JSONRulesReader(string absoluteRoute)
        {
            METRIC_FILES = new List<string>();
            METRIC_DATA = new List<Metric>();
            METRIC_FILES = LoadFileMetrics(absoluteRoute);
        }
        public void read()
        {
            foreach (string metricFile in METRIC_FILES)
            {
                using (StreamReader r = new StreamReader(metricFile))
                {
                    string json = r.ReadToEnd();
                    METRIC_DATA.Add(JsonConvert.DeserializeObject<Metric>(json));
                }
            }
            
        }

        private List<string> LoadFileMetrics(string path)
        {
            try
            {
                if (Directory.Exists(path))
                    return Directory.GetFiles(path).ToList();
                return null;
            }
            catch (Exception e)
            {
                l = new Logger();
                l.WriteInLog(e);
                return null;
            }
        }

        
    }
}
