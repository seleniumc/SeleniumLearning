
using Practicework.Integers;
using System;
using Practicework.Stringss;
using Practicework.Pholimorphism;
using Practicework.Conditions;
using Practicework.Inheritance;
using Practicework.Arrays;
using Practicework.foreac;

namespace Practicework
{
    class Program

    {
        static void Main(string[] args)
        {
           

           /* String s = "      This is radha,pkkondi,kalluru    ";
           
           
                Console.WriteLine("the string is" + s.Trim());
                Console.WriteLine("the string result is" + s.ToLower());
                Console.WriteLine("the string result is" + s.Substring(2, 5));
            Console.WriteLine("the string result is" + s.Remove(15));*/
            Console.WriteLine("integer values");
          
            int a = 10, b = 15;
            Console.WriteLine("this integer is" + ((a-b),(a*b),(a+b),(a/b)));

            Console.WriteLine("integers");
            Integ i = new Integ();
            i.numbers();
            Console.WriteLine("these are strings");
            ExampleStringss str = new ExampleStringss();
            str.Stringss();

            Console.WriteLine("pholimorphism");
            SamplePholimorphism s = new SamplePholimorphism();
            s.Num(1, 2);
            s.Num(5,3.5);
            Console.WriteLine("Overriding");
            MorphismSubClass ms = new MorphismSubClass();
            ms.SuperClass();

           /* Console.WriteLine("Inheritance ");
            Inharits inhert= new Inharits();
            inhert.Inhert();*/
            

            Console.WriteLine("? ");
            int c = (2 == 6) ? 4 : 5;
            Console.WriteLine(c);
            int d = (3 == 3) ? 4 : 5;
            Console.WriteLine(d);

            Console.WriteLine("conditions");
            Conditionss cn = new Conditionss();
            cn.conditonssample();

            Console.WriteLine("Arrays");
            ArraySample ar = new ArraySample();
            ar.arrmethod();
            Console.WriteLine(ar);

            Console.WriteLine("foreach");
            ForEachSample fe = new ForEachSample();
            fe.foreachmethod();
            Console.WriteLine(fe);



        }
    }

}
