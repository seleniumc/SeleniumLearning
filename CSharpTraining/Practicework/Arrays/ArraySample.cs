using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.Arrays
{
    class ArraySample
    {
        public void arrmethod()
        {
            int[] n = new int[10]; 
            int i, j;

            
            for (i = 0; i < 5; i++)
            {
                n[i] = i + 10;
            }

            
            for (j = 0; j < 5; j++)
            {
                Console.WriteLine("Array[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();

        }
    }
}
