using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Strings
{
    class StringSamples
    {
        string s = "ABCDEFGHI,EMLON,DFSKK";
        public StringSamples()
        {
            Console.WriteLine("Length of string is " + s.Length);
            Console.WriteLine("Substring of string is " + s.Substring(3));
            Console.WriteLine("Substring of string is " + s.Substring(3, 2));
            string[] arr = s.Split(',');
            Console.WriteLine("Size of Array is " + arr.Length);
            Console.WriteLine("For each");
            foreach (string a in arr)
                Console.WriteLine(a);
            Console.WriteLine("For forward");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int counter = 0;
            Console.WriteLine("While forward");
            while (counter < arr.Length)
            {
                Console.WriteLine(arr[counter]);
                counter++;
            }
            Console.WriteLine("For reverse");
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.WriteLine(arr[i]);
            counter = arr.Length - 1;
            Console.WriteLine("While reverse");
            while (counter >= 0)
            {
                Console.WriteLine(arr[counter]);
                counter--;
            }
            string[] aaa = { "\"arr\"", "base\t", "c\n" };
            int[] aaaa = { 1, 2, 3, 4, 56, 5 };
            char[] aa = { 'a', 'b', 'n' };
            if (aaa.Length == aaaa.Length && aa.Length > aaaa.Length || aa.Length < aaa.Length && !(aa.Length < aaa.Length))
            { }
        }
    }
}
