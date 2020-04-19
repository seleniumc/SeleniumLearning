using Laxmi.Arrays;
using Laxmi.Collectionss;
using Laxmi.Condtions;
using Laxmi.Swichs;
using Laxmi.While;
using System;
using System.Collections.Generic;

namespace Laxmi
{


    class Program : Basicclass
    {
        static void Main(string[] args)
        {

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
            List<int> pn = cse.GetPrimeNumbers(Convert.ToInt32(Console.ReadLine()));
            foreach (int primeNumber in pn)
                Console.WriteLine(primeNumber);
            SampleCollection ps = new SampleCollection();
            ps.GetNumbers();
            Console.WriteLine();


        }
        }
        
}
