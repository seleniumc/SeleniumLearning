using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Variables
{
    class InputReading
    {
        public void ReadInteger()
        {
            Console.WriteLine("Please enter number");
            string s=Console.ReadLine();
            long a=0;
            try
            {
                a = Convert.ToInt64(s);
                Console.WriteLine("You have entered " + a);
            }
            catch(Exception e)
            {
                Console.WriteLine("You have not entered a valid number");
            }
        }
    }
}
