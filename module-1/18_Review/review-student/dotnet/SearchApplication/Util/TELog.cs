using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SearchApplication.Util
{
    class TELog
    {
        public static void Log(string message)
        {
            string logFile = "logs/search.log";
            try
            {
                using (StreamWriter sw = new StreamWriter(logFile, true))
                {
                    sw.WriteLine(message);
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                throw new TELogException(e.Message);
            }
        }
    }
}
