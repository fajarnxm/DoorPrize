using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using DoorPrize.framework;

namespace DoorPrize.framework
{
    public class Logger
    {
        string source;
        //TraceListener TL;
        EventLogTraceListener ETL;
        TraceSource TS;
        private static readonly Random rnd = new Random(DateTime.Now.Millisecond);
        public Logger()
        {
            source = ConfigManager.GetSetting("logSource");
            if (!System.Diagnostics.EventLog.SourceExists(source))
                System.Diagnostics.EventLog.CreateEventSource(source, source);
            TS = new TraceSource(source);
            ETL = new EventLogTraceListener(source);
            Trace.Listeners.Add(ETL);
            TS.Listeners.Add(ETL);
            TS.Switch.Level = SourceLevels.All;           
        }

        public int LogWarning(MethodBase methodcaller, Exception ex, bool showMsg)
        {
            int retval = getID();
            StringBuilder msg = new StringBuilder();
            msg.Append("Warning : " + ex.Message);
            msg.AppendLine("On Method : " + methodcaller.Name);
            msg.AppendLine("Exception Type : " + ex.GetType().Name);
            if (ex.InnerException != null)
                msg.AppendLine("Inner Ex : " + ex.InnerException.Message);
            TS.TraceEvent(TraceEventType.Information,retval, msg.ToString());
            TS.Flush();
            if (showMsg)
                if (ex.GetType() == typeof(ApplicationException))
                    X.Msg.Alert("Error", ex.Message + "<br/> " + Helper.MSG_CONTACT_ADMIN + "<br/>Log ID : " + retval).Show();            
                else
                    X.Msg.Alert("Error", Helper.MSG_CONTACT_ADMIN + "<br/>Log ID : " + retval).Show();            
            return retval;           
        }

        public int LogException(MethodBase methodcaller, Exception ex, bool showMsg)
        {           
            int retval = getID();
            StringBuilder msg = new StringBuilder();
            msg.Append("Warning : " + ex.Message);
            msg.AppendLine("On Method : " + methodcaller.Name);
            msg.AppendLine("Exception Type : " + ex.GetType().Name);
            if (ex.InnerException != null)
                msg.AppendLine("Inner Ex : " + ex.InnerException.Message);
            TS.TraceEvent(TraceEventType.Error, retval, msg.ToString());
            TS.Flush();                
            if(showMsg)
                if (ex.GetType() == typeof(ApplicationException))
                    X.Msg.Alert("Error", ex.Message + "<br/> " + Helper.MSG_CONTACT_ADMIN + "<br/>Log ID : " + retval).Show();
                else
                    X.Msg.Alert("Error", Helper.MSG_CONTACT_ADMIN + "<br>Log ID : " + retval).Show();
            return retval;
        }

        private int getID()
        {
            return rnd.Next(1, 65535);
        }

    }
}
