using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace CSharpTraining.Collection
{
    class CollectionSample
    {
        public List<int> GetPrimeNumbers(int below)
        {
            Console.WriteLine(DateTime.Now);
            List<int> primeNumbers = new List<int>();
            for (int i = 2; i < below; i++)
            {
                if (i == 2)
                {
                    primeNumbers.Add(i);
                }
                else
                {
                    int counter = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                            break;
                        }
                    }
                    if (counter == 0)
                        primeNumbers.Add(i);
                }
            }
            Console.WriteLine(DateTime.Now);
            return primeNumbers;
        }

        public Dictionary<int, string> GetNameAndNumbers()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            try
            {
                dict.Add(1, "Lakshmi");
                dict.Add(2, "Murali");
                dict.Add(3, "Radha");
                dict.Add(3, "Radha");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.GetType());
            }
            return dict;
        }
        public long Factorial(int number)
        {
            long factorial = 1;

            for (int i = number; i > 0; i--)
                factorial *= i;

            return factorial;
        }
        public long FactorialRecursion(int number)
        {
            long output;
            if (number == 0 || number == 1)
                return 1;
            output = number * FactorialRecursion(number - 1);
            return output;
        }
    }
}   