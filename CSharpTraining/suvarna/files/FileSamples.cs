using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace suvarna.files
{
    class FileSamples
    {
        public void WriteTextToFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public void AppendToFile(string path, string conentToAppend)
        {
            File.AppendAllText(path, conentToAppend);
        }

        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
