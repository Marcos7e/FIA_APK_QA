using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_ANDROID.utils
{
    public class Logger
    {
        public string LOG_ROUTE { get; set; }
        StackFrame sf;

        public Logger()
        {
            LOG_ROUTE = @"C:\Users\Marcos\Documents\LOGGER\log.txt";
        }

        private void VerifyLogExistence()
        {
            try
            {
                if (!File.Exists(LOG_ROUTE))
                    File.Create(LOG_ROUTE);
            }
            catch (Exception ex)
            {
                sf = new StackFrame();
                Console.WriteLine($"Ocurrió una excepcion en: {sf.GetMethod().ToString()}: {ex.Message}");
            }
        }

        private void WriteInLog(string text)
        {
            ///TODO HERE
        }

        public void WriteInLog(Exception e)
        {
            try
            {
                VerifyLogExistence();

                using (StreamWriter w = File.AppendText(LOG_ROUTE))
                {
                    w.Write("\r\nLog Entry : ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                        DateTime.Now.ToLongDateString());
                    w.WriteLine("  :");
                    w.WriteLine("  :{0}", e.Message);
                    w.WriteLine("-------------------------------");
                }
            }
            catch (Exception ex)
            {
                sf = new StackFrame();
                Console.WriteLine($"Ocurrió una excepcion en: {sf.GetMethod().ToString()}: {ex.Message}");
            }
        }
    }
}
