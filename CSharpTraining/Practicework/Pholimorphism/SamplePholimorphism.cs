using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.Pholimorphism
{
    class SamplePholimorphism
    {
        public void Num(int a, int b)
        {
            Console.WriteLine("The number of substraction is" + (a - b));
        }
        public void Num(int c, double d)
        {
            Console.WriteLine("the number of multiplication is" + (c * d));
        }
    }
   
        
}
