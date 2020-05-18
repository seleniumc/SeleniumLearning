using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.PrimitiveAndNon
{
    class PNPSamples
    {
        int a = 0;
        Int16 sampleInt = 0;
        Int64 aaa = 0;
        
        public void PrimitiveSamples()
        {
            a = sampleInt;
            sampleInt =(short) a;
            String aa = "";
            string aa1 = "";
            aa1 = aa;
            aa = aa1;
        }
    }
}
