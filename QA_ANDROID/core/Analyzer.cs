using QA_ANDROID.core.Models;
using QA_ANDROID.core.LanguageData;
using QA_ANDROID.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QA_ANDROID.core
{
    public class Analyzer
    {
        JSONRulesReader jrr = null;
        VerifyAction va = null;


        public Analyzer()
        {
            jrr = new JSONRulesReader($@"{AppDomain.CurrentDomain.BaseDirectory}VerificationRules\Android");
            jrr.read();
            va = new VerifyAction(jrr.METRIC_DATA);
            
        }

        public void LoadMetricFiles()
        {
            jrr.read();
        }

        public List<MetricInfo> StartMetricVerification(string apkBasePath)
        {
            return va.StartVerifications(apkBasePath);
        }
    }
}
