using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Methods
{
    class MethodSamples
    {
        public void SimpleMethod()
        {
            Console.WriteLine("This is a simple method");
            SimpleIntMethod();
            SimpleAdd(1,4);
        }

        public int SimpleIntMethod()
        {
            return 1;
        }

        public static int SimpleAdd(int a, int b)
        {
            Sample();
            return a + b;
        }

        public static void Sample()
        {
            SimpleAdd(4,1);
        }

        public string SimpleStringMethod(string a)
        {
            Console.WriteLine("This is simple string method with string parameter");
            return a;
        }

        public int SimpleStringMethod(string a,string b,int c)
        {
            Console.WriteLine("This is simple string method with string parameter");
            return c;
        }

        public string SimpleStringMethod(string a,string b)
        {
            Console.WriteLine("This is simple string method with string parameter");
            return a+b;
        }

        public MethodSamples ReturnObject()
        {
            return new MethodSamples();
        }

        public MethodSamples()
        {
            Console.WriteLine("");
        }

       public MethodSamples(int a)
        {

        }

        public MethodSamples(int a,int b)
        {

        }
        public void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

    }
}
