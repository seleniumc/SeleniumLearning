using suvarna.Methods;
using System;

namespace suvarna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = "suvarna";
            Console.WriteLine(name);
            int myNum = 15;
            myNum = 20;
            Console.WriteLine(myNum);
            string myText = "Hello";
            Console.WriteLine(myText);
            MethodSamples ms = new MethodSamples();

            ms.SimpleMethod();
            ms.SimpleIntMethod();
            int a1 = ms.SimpleIntMethod();

        }
       
    }
}
