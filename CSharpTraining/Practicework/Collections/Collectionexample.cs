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
        public List<int> oddnumber(int number)
        {
            List<int>num=new List<int>();
           /* Console.WriteLine("odd number");
            number = Convert.ToInt32(Console.ReadLine());*/
            for (int m = 1; m < number; m++)
            {
                if (m % 2 != 0)
                {

                    num.Add(m);
                }
            }


            return num;


        }
       public Dictionary<int,string>GetNameAndnumbers()
        {
            Dictionary<int, string> dist = new Dictionary<int, string>();
            try
            {
                dist.Add(1,"Hi");
                dist.Add(2,"Hello");
                dist.Add(3,"Ram");
                dist.Add(4,"Ram");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message+e.GetType());
            }
            return dist;
        }

        }
    
}

