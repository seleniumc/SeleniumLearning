using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.Conditions
{
    class Conditionss
    {
        public new void conditonssample()
        {
            int a = 4, b = 5, c = 3, d = 8, e = 7, f = 2;
            if (a == b)
            {
                Console.WriteLine(a);
            }
            else if(b==d)
                {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(b);

            }
            Console.WriteLine("switch statements");
            int exp = Convert.ToInt32(Console.ReadLine());
            switch(exp)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednessday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;

            }

        }
    }
}
