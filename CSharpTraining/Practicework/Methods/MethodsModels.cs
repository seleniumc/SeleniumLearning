using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.Methods
{
    class MethodsModels
    {
        public void methodsample()
        {
            Console.WriteLine("this is a sample method");
            Intmethod();
            simple();
        }
        public int Intmethod()
        {
            return 1;
        }
        public static int simpleadd(int a,int b)
        {
            return (a+b);
        }
        public static void simple()
        {
          
            simpleadd(8,4);
        }
        public string stringmethod(string n)
        {
            Console.WriteLine("this is the string method");
            return n;
        }
        public int stringmethod(int b,string c,int d)
        {
            return(b+d);
        }
        public MethodsModels robj()
        {
            return new MethodsModels();
        }
        public MethodsModels()
        {
            Console.WriteLine("");
        }

        public MethodsModels(int a)
        {

        }

        public MethodsModels(int a, int b)
        {

        }
        public double stringmethod(string s,double t)
        {
            return  t;
        }
        public void Myname(string name = "RADHA")
        {
            Console.WriteLine(name);
        }

    }
}
