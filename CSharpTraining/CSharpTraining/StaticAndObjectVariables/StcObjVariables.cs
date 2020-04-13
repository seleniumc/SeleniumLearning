using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.StaticAndObjectVariables
{
    class StcObjVariables
    {
        public static int a = 5;
        public int b = 6;
        public void ContinueAndBreak()
        {
            for (int j = 0; j < 10; j++)
            {
                if (j == 4)
                {
                    continue;
                }
                Console.WriteLine(j);
            }
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }
        }
    }
}
