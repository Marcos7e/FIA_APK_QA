using QA_FIA_APK_CONSOLE.core.Models;
using QA_FIA_APK_CONSOLE.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE.core.LanguageData
{
    public class VerifyAction
    {
        public Logger log;
        public enum Verify
        {
            EXISTS,
            EQUAL,
            MORE_THAN,
            LESS_THAN,
            MORE_EQUAL,
            LESS_EQUAL
        }

        public VerifyAction()
        {
            // mandar a llamar lectura de Metricas vs Acoplamiento ...
        }

        public bool verify(Metric metric)
        {
            try
            {
                Verify verify;
                Enum.TryParse(metric.Operation, out verify);

                switch (verify)
                {
                    case Verify.EXISTS:
                        return VerifyExists(metric);

                    case Verify.EQUAL:
                        return VerifyEqual(metric);

                    case Verify.MORE_THAN:
                        return VerifyMoreThan(metric);

                    case Verify.LESS_THAN:
                        return VerifyLessThan(metric);

                    case Verify.MORE_EQUAL:
                        return VerifyMoreEqual(metric);

                    case Verify.LESS_EQUAL:
                        return VerifyLessEqual(metric);

                    default:
                        throw new Exception();
                }

            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return false;
            }
        }

        private bool VerifyLessEqual(Metric metric)
        {
            throw new NotImplementedException();
        }

        private bool VerifyMoreEqual(Metric metric)
        {
            throw new NotImplementedException();
        }

        private bool VerifyLessThan(Metric metric)
        {
            throw new NotImplementedException();
        }

        private bool VerifyMoreThan(Metric metric)
        {
            throw new NotImplementedException();
        }

        private bool VerifyEqual(Metric metric)
        {
            throw new NotImplementedException();
        }

        private bool VerifyExists(Metric metric)
        {
            throw new NotImplementedException();
        }
    }
}
