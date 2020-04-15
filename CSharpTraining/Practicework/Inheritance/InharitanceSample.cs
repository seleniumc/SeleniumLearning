using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.Inheritance
{
    class Inhert
    {
        public Inhert()
        {
            Console.WriteLine("the inherit class ");
        }
       /* public void InherA()
        {
            Console.WriteLine("This is InherA method");
        }*/
        class Inharits:Inhert
        {
            public  void  InherB()
            {
                Console.WriteLine("This is InherB method");
            }


        }
    }
}
