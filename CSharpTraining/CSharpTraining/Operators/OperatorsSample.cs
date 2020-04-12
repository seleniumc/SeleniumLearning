using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Operators
{
    class OperatorsSample
    {
        
        public int Modulus(int a,int b)
        {
            Console.WriteLine("Remainder is "+(a%b));
            return a % b;
        }

        public bool IfAGreaterThanB(int a, int b)
        {
            return a > b;
        }

        public bool IfAEqualsB(int a, int b)
        {
            return a == b;
        }
    }
}
