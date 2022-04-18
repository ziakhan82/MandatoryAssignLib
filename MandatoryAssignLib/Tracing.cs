using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib
{
   public class Tracing
   {

       public static TraceSource ts = new TraceSource(("ZiaAplliactaion"));

       static Tracing()
       {
           ts.Switch = new SourceSwitch("ZiaLog","All");
           string logFile = "FileLog.text";
           string filePath = Environment.GetEnvironmentVariable("war");
           string fullPath = Path.Combine(logFile, filePath);

           TraceListener traceListener = new TextWriterTraceListener(new StreamWriter(fullPath));

           traceListener.Filter = new EventTypeFilter(SourceLevels.All);

           ts.Listeners.Add(traceListener);
       }

       public static void log(TraceEventType traceEventType, string message)
       {
           ts.TraceEvent(traceEventType,111,message);
           ts.Close();
       }
       
           
       } 


   }

