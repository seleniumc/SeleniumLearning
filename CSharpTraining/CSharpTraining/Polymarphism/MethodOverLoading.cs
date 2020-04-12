using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Polymarphism
{
    class MethodOverLoading
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Addition of "+x+" "+y+" is"+(x+y));
        }
        public void Add(int a, double b)
        {
            Console.WriteLine("Addition of " + a + " " + b + " is" + (a + b));
        }
    }
}