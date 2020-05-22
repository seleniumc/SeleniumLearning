using System;
using System.Collections.Generic;
using System.IO;


namespace Laxmi.SampleFiles
{
    class SampleFiless
    {
        public void WriteTextToFile(string path, string data)
        {
            File.WriteAllText(path, data);
        }
    public void AppendToFile(string path, string data)
        {
            File.AppendAllText(path, data);

        }
        public string[] ReadAllLines(string path )
        {
            File.ReadAllLines(path);

        }

        internal void AppendToFile(string v)
        {
            throw new NotImplementedException();
        }

        internal void WriteTextToFile(string v)
        {
            throw new NotImplementedException();
        }

        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }
    }

}
