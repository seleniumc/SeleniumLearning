using System;
using System.Collections.Generic;
using System.Text;

namespace Laxmi.Collectionss
{
    class SampleCollection
    {
        public List<int> GetPrimeNumbers(int below)
        {
            List<int> primberNumber = new List<int>();
            for (int i = 2; i < below; i++)
            {
                if (i == 2)
                {
                    primberNumber.Add(i);
                }
                else
                {
                    int counter = 0;
                    for (int n = 2; n < i; n++)
                    {
                        if (i % n == 0)
                        {
                            counter++;
                            break;
                        }
                        if (counter == 0)
                        {
                            primberNumber.Add(i);

                        }

                    }
                    //  return primberNumber;

                }

            }
            return primberNumber;
        }


        public List<int> GetNumbers(int bello, string typeofNumbers)
        {
            List<int> myrNumber = new List<int>();
            int m = 0;
            Console.WriteLine("Even Number");

            for (m = 1; m < bello; m++)
            {
                if (typeofNumbers.Equals("even"))

                {
                    if (m % 2 == 0)
                    {
                        // Console.WriteLine(m + " ");
                        myrNumber.Add(m);

                    }

                }
                else
                {

                    if (m % 2 != 0)
                    {
                        // Console.WriteLine(m + " ");
                        myrNumber.Add(m);
                    }

                }

            }

            return myrNumber;
        }
          public List<int> GetSumofNumbers()
        {
            List<int> sumofNumbers = new List<int>();
            int k, n, sum = 0;
                double avg;

                Console.Write("\n\n");
                Console.Write("Read 10 numbers and calculate sum and average:\n");
                Console.Write("----------------------------------------------");
                Console.Write("\n\n");

                Console.Write("Input the 10 numbers : \n");
                for (k = 1; k <= 10; k++)
                {
                    Console.Write("Number-{0} :", i);

                    n = Convert.ToInt32(Console.ReadLine());
                    sum += n;
                sumofNumbers.Add(k);

                }
                avg = sum / 10.0;
                Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);
        }
        
    }
              return sumofNumbers;
           
}

