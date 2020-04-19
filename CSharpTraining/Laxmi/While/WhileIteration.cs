using System;
using System.Collections.Generic;
using System.Text;

namespace Laxmi.While
{
    class WhileIteration
    {
        static void main(string[] args)
        {
            bool displayMenu = true;
            While(displayMenu == true);

            {
               // displayMenu = MainMenu();

            }


        }

        private static void While(bool v)
        {
            throw new NotImplementedException();
        }

        public void MainMenu()
        {
            Console.WriteLine("choose option");
            Console.WriteLine("1.Option 1");
            Console.WriteLine("2.Option 2");
            Console.WriteLine("3.Exit ");
            string result = Console.ReadLine();
            if( result=="1")
            {

            }
            else if(result=="2")
            {

            }
            else if (result == "3")
            {

            }
            else
            {

            }
        }
    }
}
