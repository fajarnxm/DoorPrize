using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DoorPrize.framework
{
    public sealed class LogTxt
    {
        private static volatile LogTxt instance;
        private static object syncRoot = new Object();

        private LogTxt() { }

        public static LogTxt Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new LogTxt();
                    }
                }

                return instance;
            }
        }

        public void Error(Exception exp, MethodBase Method)
        {
            try
            {
                var tes = new StackTrace(exp, true);
                var frame = tes.GetFrame(0);

                int LineNumber = 0;
                string FileName = "";
                string InnerExp = "";

                LineNumber = frame.GetFileLineNumber();
                FileName = frame.GetFileName();

                if(exp.InnerException != null)
                {
                    InnerExp = exp.InnerException.ToString();
                }

                using (IDataAccess da = new SQLDataAccess())
                {
                    //string tmp = "SaveLog '" + exp.Message.Replace("'", "''") + "', '" + Method.Name + "', '" + LineNumber + "', '" + exp.GetType().Name + "', '" + FileName + "', '" + InnerExp.Replace("'", "''") + "', '" + tes.ToString().Replace("'", "''") + "'";
                    da.ExecuteNonQuery("SaveLog '" + exp.Message.Replace("'", "''") + "', '" + Method.Name + "', '" + LineNumber + "', '" + exp.GetType().Name + "', '" + FileName + "', '" + InnerExp.Replace("'", "''") + "', '" + tes.ToString().Replace("'", "''") + "'", null);
                }

            }

            catch
            {
                using (IDataAccess da = new SQLDataAccess())
                {
                    da.ExecuteNonQuery("SaveLog 'unknown', 'unknown', 'unknown', 'unknown', 'unknown', 'unknown', 'unknown'", null);
                }
            }
        }
    }
}
