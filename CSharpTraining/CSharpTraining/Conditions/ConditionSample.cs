using CSharpTraining.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpTraining.Conditions
{
    class ConditionSample
    {
        public void Conditions()
        {
            int a = 1, b = 2, c = 3, d = 4, e = 5;
            if (a == b)
            {
                Console.WriteLine(a == b);
            }
            else if (b == c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("Enter day of the week");
            int expression = Convert.ToInt32(Console.ReadLine());
            switch (expression)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
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
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
            EnumSample.Color j = new EnumSample.Color();
            if(j==EnumSample.Color.Green)
            {

            }
            else if(j==EnumSample.Color.Black)
            {

            }
            else
            {

            }
        }

    }
}
