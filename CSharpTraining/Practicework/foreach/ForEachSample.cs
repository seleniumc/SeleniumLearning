using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.foreac

{
    class ForEachSample
{
    public void foreachmethod()
    {
        int[] n = new int[5];
            for(int i=0;i<5;i++)
            {
                n[i] = i + 10;
            }



        foreach (int j in n)
        {
            int i = j - 1;
            Console.WriteLine("Arrays[{0}]={1}",i,j);
        }
        Console.ReadKey();
    }
}
}

