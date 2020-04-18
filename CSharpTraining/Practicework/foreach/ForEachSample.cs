using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.foreac

{
    class ForEachSample
    {
        public void foreachmethod()
        {
            int[] n = { 1, 2, 3, 4 };
            string[] m = { "a", "b", "c" };
            /*for(int i=0;i<5;i++)
            {
                n[i] = i + 10;
            }*/
            foreach (string i in m)
                Console.WriteLine(i);
            int counter = 0;
            foreach (int k in n)
            {
                n[counter] = counter+1;
                counter++;
            }

            foreach (int k in n)
                Console.WriteLine(k);
            
        }
    }
}

