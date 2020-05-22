using Laxmi.Arrays;
using Laxmi.Collectionss;
using Laxmi.Condtions;
using Laxmi.Swichs;
using Laxmi.While;
using System;
using System.Collections.Generic;
using Laxmi.SampleFiles;
using System.IO;

namespace Laxmi
{


    class Program : Basicclass
    {
        static void Main(string[] args)
        {
            //fiels
            SampleFiless fs = new SampleFiless();

            fs.WriteTextToFile("C:\\Users\\Lakshmi\\Desktop\\SampleFiles\\1.txt"+"hello");
            fs.AppendToFile("C:\\Users\\Lakshmi\\Desktop\\SampleFiles\\1.txt" + "\nAppending");

            string[] fileLines = fs.ReadAllLines("C:\\Users\\Lakshmi\\Desktop\\SampleFiles\\1.txt");

            string fileContent = fs.ReadAllText("C:\\Users\\Lakshmi\\Desktop\\SampleFiles\\1.txt" );

            try
            {
                File.Copy("C:\\Users\\Lakshmi\\Desktop\\SampleFiles\\1.txt", "C:\\Users\\Lakshmi\\Desktop\\SampleFiles\\2.txt");
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
            File.Delete("C:\\Users\\Lakshmi\\Desktop\\SampleFiles\\1.txt");
            File.Delete("C:\\Users\\Lakshmi\\Desktop\\SampleFiles\\1.txt");
            foreach (string samplestring in fileLines)
            {
                Console.WriteLine(samplestring);
            }
            Console.WriteLine(fileContent);

            //colection

            SampleCollection ps = new SampleCollection();
            Console.WriteLine("Please enter the number till which you want what type of numbers");
            string typeofNumber = Console.ReadLine();
            Console.WriteLine("Please enter the number till which you want Even numbers");

            List<int>   pn = ps.GetNumbers(Convert.ToInt32(Console.ReadLine()),typeofNumber);
            Console.WriteLine("myNumbers");
            foreach (int evenNumber in pn)
                Console.WriteLine(evenNumber);
            // condition
            ConditionSample cs = new ConditionSample();
            cs.Conditoins();

            //switchs
            Switchssample sw = new Switchssample();
            sw.Switchs();

            //Arrays
            SampleArrays sa = new SampleArrays();
            sa.Arrayss();

            //while ita
            WhileIteration wi = new WhileIteration();

                wi.MainMenu();
            //Colletion
            SampleCollection cse = new SampleCollection();
            Console.WriteLine("Please enter the number till which you want prime numbers");
          pn = cse.GetPrimeNumbers(Convert.ToInt32(Console.ReadLine()));
            foreach (int primeNumber in pn)
                Console.WriteLine(primeNumber);
          
        }
        }
        
}
