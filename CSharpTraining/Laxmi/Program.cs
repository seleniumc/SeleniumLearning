using Laxmi.Arrays;
using Laxmi.Condtions;
using Laxmi.Swichs;
using Laxmi.While;
using System;

namespace Laxmi
{


    class Program : Basicclass
    {
        static void Main(string[] args)
        {

            // condition
            ConditionSample cs = new ConditionSample();
            cs.Conditoins();

            //switchs
            Switchssample sw = new Switchssample();
            sw.Switchs();

            //Arrays
            SampleArrays sa = new SampleArrays();
            sa.Arrayss();

            //while ita
            WhileIteration wi = new WhileIteration();

                wi.MainMenu();
            


        }
        }
        
}
