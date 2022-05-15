using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Logger
{
    public class FileWriter
    {
        public string FileName { get; set; }

        public FileWriter(string filename)
        {
            if (File.Exists(filename))
            {
                throw new IOException("The file already exists");
            }
            FileName = filename;
        }

        public void WriteInFile(string message)
        {
            using (FileStream fw = File.Open(FileName, FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fw))
            {
                sw.WriteLine(message);
            }
        }
    }
}
