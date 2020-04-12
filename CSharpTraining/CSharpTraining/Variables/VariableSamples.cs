
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpTraining.Variables
{
    class VariableSamples
    {
        int myNum = 1111111111,myNum2=0,myNumber3;
        double myDob = 111.1;
        char myChar = 'A';
        string myStr = "Sample";
        bool myBool = true;
        long myLong = 11111111111111111;
        public void SampleMethod()
        {
            Console.WriteLine(myNumber3);
            myNumber3 = 1;
            Console.WriteLine(myNumber3);
            myNum = 9;
            Console.WriteLine("My Number is "+myStr+ myNum);
            Console.WriteLine("Addition is " + (myNum + myDob));
        }
    }
}
