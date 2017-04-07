using QA_FIA_APK_CONSOLE.metricas;
using QA_FIA_APK_CONSOLE.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FIA_APK_CONSOLE.core.Instructions
{
    public class VerifyInstructions
    {
        Logger log;
        public enum Instructions
        {
            EXIST,
            ANY,
            COUNT
        }

        public bool Verify(Instructions inst, MetricData_Model data)
        {
            try
            {
                switch (inst)
                {
                    case Instructions.EXIST: { return VerifyExist(data); }
                    case Instructions.ANY: { return VerifyAny(data); }
                    case Instructions.COUNT: { return VerifyCount(data); }
                }

                return true;
            }
            catch (Exception e)
            {
                log = new Logger();
                log.WriteInLog(e);
                return false;
            }
        }

        #region palabras reservadas
        private bool VerifyExist(MetricData_Model data)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private bool VerifyAny(MetricData_Model data)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private bool VerifyCount(MetricData_Model data)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion


    }
}
