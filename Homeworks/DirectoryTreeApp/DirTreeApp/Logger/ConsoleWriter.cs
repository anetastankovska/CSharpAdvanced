using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Logger
{
    public class ConsoleWriter
    { 

        public void WriteColoredLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
