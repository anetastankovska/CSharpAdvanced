using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LogWriter : IDisposable, Ilogger
    {
        public FileWriter FileWriter { get;}
        public ConsoleWriter ConsoleWriter { get; }
        
        public LogWriter(string filepath = null)
        {
            ConsoleWriter = new ConsoleWriter();
            if (!string.IsNullOrEmpty(filepath))
            {
                FileWriter = new FileWriter(filepath);
            }
        }

        public void LogMessage(string message) 
        {
            ConsoleWriter.WriteColoredLine(message);
            if (FileWriter != null)
            {
                FileWriter.WriteInFile(message);
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Logger disposed");
        }
    }
}
