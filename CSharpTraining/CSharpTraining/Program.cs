using CSharpTraining.Arrays;
using CSharpTraining.ClassAndObjects;
using CSharpTraining.Conditions;
using CSharpTraining.Files;
using CSharpTraining.Inheritance;
using CSharpTraining.Loops;
using CSharpTraining.Methods;
using CSharpTraining.Operators;
using CSharpTraining.Polymarphism;
using CSharpTraining.StaticAndObjectVariables;
using CSharpTraining.Strings;
using CSharpTraining.Variables;
using System;
using System.IO;

namespace CSharpTraining
{
    class Program : BaseClass
    {
        static void Main(string[] args)
        {
            //Singleton sample
            SingletonSample sgs = SingletonSample.CreateSingletonObject();
            SingletonSample sgs1 = SingletonSample.CreateSingletonObject();
            FileSamples fs1 = new FileSamples();
            FileSamples fs2 = new FileSamples();

            Console.WriteLine(sgs.GetHashCode()+"\t"+sgs1.GetHashCode());
            Console.WriteLine(fs1.GetHashCode() + "\t" + fs2.GetHashCode());
            //File Samples
            FileSamples fs = new FileSamples();
            fs.WriteTextToFile("C:\\Users\\v-mukri\\Desktop\\SampleFiles\\1.txt", "Hello");
            fs.AppendToFile("C:\\Users\\v-mukri\\Desktop\\SampleFiles\\1.txt", "\nAppending");
            string[] fileLines = fs.ReadAllLines("C:\\Users\\v-mukri\\Desktop\\SampleFiles\\1.txt");
            string fileContent = fs.ReadAllText("C:\\Users\\v-mukri\\Desktop\\SampleFiles\\1.txt");
            try
            {
                File.Copy("C:\\Users\\v-mukri\\Desktop\\SampleFiles\\1.txt", "C:\\Users\\v-mukri\\Desktop\\SampleFiles\\2.txt");
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.GetType());
                if (e.Message.Contains("already exists"))
                    Console.WriteLine("Please choose a different file name");
                try
                {
                    throw new ArithmeticException();
                }
                catch
                {
                    Console.WriteLine("We have never dealt with this kind of exception, we are investigating into it, Arithmetic");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("We have never dealt with this kind of exception, we are investigating into it");
            }
            finally
            {
                Console.WriteLine("Mandatory code to be executed");
            }
            File.Delete("C:\\Users\\v-mukri\\Desktop\\SampleFiles\\1.txt");
            File.Delete("C:\\Users\\v-mukri\\Desktop\\SampleFiles\\1.txt");
            foreach (string samplestring in fileLines)
            {
                Console.WriteLine(samplestring);
            }
            Console.WriteLine(fileContent);

            Program p = new Program();
            p.BaseClassMethod();

            //Classes and Object
            Fruit mango = new Fruit();
            Console.WriteLine("Name:" + mango.name + "\tColor:" + mango.color + "\tTaste:" + mango.taste);
            mango.name = "Mango";
            mango.color = "Yello";
            mango.taste = "sweet";
            Console.WriteLine("Name:" + mango.name + "\tColor:" + mango.color + "\tTaste:" + mango.taste);
            Fruit orange = new Fruit("Orange", "Soar", "Orange");
            Console.WriteLine("Name:" + orange.name + "\tColor:" + orange.color + "\tTaste:" + orange.taste);

            //Access specifiers
            PPPInheritance ppp = new PPPInheritance();
            PrivateAndProtected pnp = new PrivateAndProtected();
            int a = pnp.publicVariabel;

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
            a = 10;
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
            ls.Loop();

            //Statci variable samples
            Console.WriteLine("Static variable value is " + StcObjVariables.a);
            StcObjVariables stcObj = new StcObjVariables(), stcObj1 = new StcObjVariables();
            Console.WriteLine("Object1 variable value is " + stcObj.b);
            Console.WriteLine("Object2 variable value is " + stcObj1.b);
            stcObj.b = 10;
            Console.WriteLine("Object1 variable value is " + stcObj.b);
            Console.WriteLine("Object2 variable value is " + stcObj1.b);
            stcObj.ContinueAndBreak();

 


            //ArraySamples
            new ArraySamples().ArraySamplesMethod();

            //Method Samples
            MethodSamples ms = new MethodSamples();
            MethodSamples ms1 = new MethodSamples(2);
            MethodSamples ms2 = new MethodSamples(1, 2);
            int a1 = ms2.SimpleIntMethod();
            string b1 = ms2.SimpleStringMethod("a");
            int v = MethodSamples.SimpleAdd(1, 3);
            ms2.MyMethod();
            ms2.MyMethod("India");
        }

        public Program()
        {
            Console.WriteLine("Inherited class costructor");
        }

    }
}