﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Loops
{
    class LoopSamples
    {
        public void Loop()
        {
            int counter = 0;
            while(counter<=0)
            {
                Console.WriteLine("While loop");
                counter++;
            }
            for (counter = 0; counter <= 5; counter++)
                Console.WriteLine("For loop");
            int[] a = { 1,2,3,4};
            foreach (int b in a)
                Console.WriteLine(b);
        }
    }
}
