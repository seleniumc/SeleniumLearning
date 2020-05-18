using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace suvarna.Collections
{
    class CollectionSamples
    {
        public List<int> GetFibonacci(int below)
        {
            List<int> Fibonacci = new List<int>();
            int previous = 0, current = 1, next = previous + current;
            for (int i = 0; i < below; i++)
            {

                if (i == 0)
                {
                    Fibonacci.Add(previous);
                    Fibonacci.Add(current);



                }
                else
                {
                    next = previous + current;

                    Fibonacci.Add(next);
                    previous = current;
                    current = next;




                }


            }
            return Fibonacci;
        }
        public List<List<int>> GetEvennumber(int below)
        {
            List<int> Evennumber = new List<int>();
            List<int> Oddnumber = new List<int>();
            for (int i = 0; i < below; i++)
            {
                if (i % 2 == 0)
                    Evennumber.Add(i);
                else
                    Oddnumber.Add(i);
            }
            List<List<int>> nList = new List<List<int>>();
            nList.Add(Evennumber);
            nList.Add(Oddnumber);
            return nList;
        }            
        

}
}
