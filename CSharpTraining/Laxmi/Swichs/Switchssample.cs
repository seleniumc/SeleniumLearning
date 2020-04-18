using System;
using System.Collections.Generic;
using System.Text;

namespace Laxmi.Swichs
{
    class Switchssample

    {
        public void Switchs()
        { 
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
            Console.ReadLine();

}

}
}
