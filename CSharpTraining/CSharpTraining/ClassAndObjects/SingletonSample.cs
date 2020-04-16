using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.ClassAndObjects
{
    class SingletonSample
    {
        private static SingletonSample sgObj=null;
        private SingletonSample()
        {

        }

        public static SingletonSample CreateSingletonObject()
        {
            if (sgObj == null)
                sgObj= new SingletonSample();
            return sgObj;
        }
    }
}
