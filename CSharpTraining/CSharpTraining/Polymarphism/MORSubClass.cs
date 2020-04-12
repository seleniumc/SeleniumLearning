using CSharpTraining.Inheritance;
using System;
namespace CSharpTraining.Polymarphism
{
    class MORSubClass : MORSuperClass,INterfaceSample
    {
        public new void SuperClassMethod()
        {
            base.SuperClassMethod();
            Console.WriteLine("Sub class");  
        }

        public void InterfaceMethod()
        {

        }
    }
}
