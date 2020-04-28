using suvarna.Collections;
using suvarna.files;
using suvarna.Methods;
using System;
using System.Collections.Generic;
using System.IO;

namespace suvarna
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collection Samples
            CollectionSamples cs = new CollectionSamples();
            Console.WriteLine("How many fibonacci series you need");
            List<int> fb = cs.GetFibonacci(Convert.ToInt32(Console.ReadLine()));
            foreach (int Fibonacci in fb)
                Console.WriteLine(Fibonacci);
            Console.WriteLine("How many Evennumbers you need");
            List<List<int>> en = cs.GetEvennumber(Convert.ToInt32(Console.ReadLine()));
            foreach (List<int> a in en)
                foreach (int Evennumber in a)
                    Console.WriteLine(Evennumber);
            


            //File Samples
            FileSamples fs = new FileSamples();
            fs.WriteTextToFile("C:\\Users\\bcmss\\Desktop\\SampleFiles\\1.txt", "Hello");
            fs.AppendToFile("C:\\Users\\bcmss\\Desktop\\SampleFiles\\1.txt", "\nAppending");
            string[] fileLines = fs.ReadAllLines("C:\\Users\\bcmss\\Desktop\\SampleFiles\\1.txt");
            string fileContent = fs.ReadAllText("C:\\Users\\bcmss\\Desktop\\SampleFiles\\1.txt");
            try
            {
                File.Copy("C:\\Users\\bcmss\\Desktop\\SampleFiles\\1.txt", "C:\\Users\\bcmss\\Desktop\\SampleFiles\\2.txt");
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.GetType());
                if (e.Message.Contains("already exists"))
                    Console.WriteLine("Please choose a different file name");
                try
                {
                    throw new ArithmeticException();
                }
                catch
                {
                    Console.WriteLine("We have never dealt with this kind of exception, we are investigating into it, Arithmetic");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("We have never dealt with this kind of exception, we are investigating into it");
            }
            finally
            {
                Console.WriteLine("Mandatory code to be executed");
            }
            File.Delete("C:\\Users\\bcmss\\Desktop\\SampleFiles\\1.txt");
            File.Delete("C:\\Users\\bcmss\\Desktop\\SampleFiles\\1.txt");
            foreach (string samplestring in fileLines)
            {
                Console.WriteLine(samplestring);
            }
            Console.WriteLine(fileContent);
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
