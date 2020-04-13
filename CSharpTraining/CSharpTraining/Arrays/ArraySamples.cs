using System;
using System.Linq;

namespace CSharpTraining.Arrays
{
    class ArraySamples
    {
        string[] aaa = { "\"arr\"", "base\t", "c\n", "100" };
        int[] c = { 1, 2, 3, 4 };
        char[] d = { 'a', 'b', 'n' };
        bool[] b = { true, false, true };
        public void ArraySamplesMethod()
        {
            ArraySamples[] e1 = { new ArraySamples(), new ArraySamples(), new ArraySamples() };
            string[] abc=(string[])aaa.Clone();
            int[] acbd = (int[])c.Clone();
            Console.WriteLine(acbd.Max() + "\t" + acbd.Min()+"\t"+acbd.Average()) ;
            Console.WriteLine(""+(aaa==abc)+"\t"+abc.GetHashCode()+"\t"+aaa.GetHashCode());
            foreach (string a in aaa)
            {
                try
                {
                    Convert.ToInt32(a);
                    Console.WriteLine("Valid number");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number " + e.Message);
                }
            }
        }
    }
}
