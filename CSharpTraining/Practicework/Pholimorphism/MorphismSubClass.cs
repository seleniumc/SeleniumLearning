using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.Pholimorphism
{
    class MorphismSubClass:MorSuperClass,IInterface
    {
        public new void SuperClass()
        {
            base.SuperClass();
            Console.WriteLine("Sub class");
        }
    }
}
