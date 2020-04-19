using System;
using System.Collections.Generic;
using System.Text;

namespace Laxmi.Arrays
{
    class SampleArrays
    {
        public void Arrayss()
        {
             string[] names = new string[] { "lax", "Mod", "rao" };


             for (int i = 0; i < names.Length; i++)

              {
                  Console.WriteLine(names[i]);



              }
              Console.ReadLine();
            foreach  ( string name in names)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
