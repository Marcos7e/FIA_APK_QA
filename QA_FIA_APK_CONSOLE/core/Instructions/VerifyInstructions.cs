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

        public bool Verify(Instructions inst)
        {
            try
            {
                switch (inst)
                {
                    case Instructions.EXIST: { return VerifyExist(); }
                    case Instructions.ANY: { return VerifyAny(); }
                    case Instructions.COUNT: { return VerifyCount(); }
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

        private bool VerifyExist()
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

        private bool VerifyAny()
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

        private bool VerifyCount()
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
