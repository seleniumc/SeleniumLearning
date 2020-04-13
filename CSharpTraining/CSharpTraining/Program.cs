﻿using CSharpTraining.Arrays;
using CSharpTraining.Conditions;
using CSharpTraining.Inheritance;
using CSharpTraining.Loops;
using CSharpTraining.Operators;
using CSharpTraining.Polymarphism;
using CSharpTraining.StaticAndObjectVariables;
using CSharpTraining.Strings;
using CSharpTraining.Variables;
using System;

namespace CSharpTraining
{
    class Program : BaseClass
    {
        static void Main(string[] args)
        {
            /* Program p = new Program();
             p.BaseClassMethod();

             //Method overloading
             MethodOverLoading mol = new MethodOverLoading();
             mol.Add(1, 2);
             mol.Add(1, 2.3);

             //Method overriding
             MORSubClass mor = new MORSubClass();
             mor.SuperClassMethod();

             //Variables sample
             VariableSamples vs = new VariableSamples();
             vs.SampleMethod();

             //Input reading
             InputReading ir = new InputReading();
             ir.ReadInteger();

             //Operators sample
             OperatorsSample os = new OperatorsSample();
             os.Modulus(4, 3);
             int a = 10;
             a %= 5;
             Console.WriteLine(a);
             Console.WriteLine(os.IfAGreaterThanB(1, 6));
             Console.WriteLine(os.IfAEqualsB(1, 1));

             int b = (1 == 2) ? 2 : 1;
             Console.WriteLine(b);
             b = (1 == 1) ? 2 : 1;
             Console.WriteLine(b);

             Console.WriteLine(Math.Floor(12.1));
             Console.WriteLine(Math.Ceiling(12.1));

             //String samples
             StringSamples ss = new StringSamples();
             string firstName = "John";
             string lastName = "Doe";
             string name = $"My full name is: {firstName} {lastName}";
             Console.WriteLine(name);

             //Condition samples
             ConditionSample cs = new ConditionSample();
             cs.Conditions();

             //Loop samples
             LoopSamples ls = new LoopSamples();
             ls.Loop();*/

            //Statci variable samples
            Console.WriteLine("Static variable value is "+StcObjVariables.a);
            StcObjVariables stcObj = new StcObjVariables(), stcObj1 = new StcObjVariables();
            Console.WriteLine("Object1 variable value is " + stcObj.b);
            Console.WriteLine("Object2 variable value is " + stcObj1.b);
            stcObj.b = 10;
            Console.WriteLine("Object1 variable value is " + stcObj.b);
            Console.WriteLine("Object2 variable value is " + stcObj1.b);
            stcObj.ContinueAndBreak();


            //ArraySamples
            new ArraySamples().ArraySamplesMethod();

        }

        public Program()
        {
            Console.WriteLine("Inherited class costructor");
        }

    }
}