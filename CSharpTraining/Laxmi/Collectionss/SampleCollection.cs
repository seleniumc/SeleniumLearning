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

        internal void GetNumbers()
        {
            throw new NotImplementedException();
        }

        //
        /// internal List<int> GetPrimeNumbers(long v)

        //  throw new NotImplementedException();
        public List<int> GetNumbers(int bello )
        {
            List<int> myrNumber = new List<int>();
            int m = 0;
            Console.WriteLine("Even Number");

            for (m = 1; m < bello; m++)
            {
                if (m % 2 == 0)
                {
                    Console.WriteLine(m + " ");
                    myrNumber.Add(m);


                }
                Console.WriteLine("Odd Number");

                for (m = 1; m < bello; m++)
                {
                    if (m % 2 != 0)
                    {
                        Console.WriteLine(m + " ");
                        myrNumber.Add(m);
                    }
                }
                //  return myrNumber;
            }

            return myrNumber;
        }
    }
}

