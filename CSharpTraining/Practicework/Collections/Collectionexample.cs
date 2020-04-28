using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.Collections
{

    class Collectionexample
    {
        public List<int> GetNumbers(int below)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("even number");
            for (int m = 1; m < below; m++)
            {
                if (m % 2 == 0)
                {

                    numbers.Add(m);
                }
            }
            return numbers;

        }      
                 public long  ReverseOrder(int number)
            {
            
                int  r, sum = 0, t;
                Console.Write("Input a reverse number: ");
                number = Convert.ToInt32(Console.ReadLine());
                for (t = number; t != 0; t = t / 10)
                {
                    r = t % 10;
                    sum = sum * 10 + r;

                }               
                return sum;
              
            }
            
           
        }
    
}

