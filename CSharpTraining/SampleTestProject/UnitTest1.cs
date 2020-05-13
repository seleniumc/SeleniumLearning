using NUnit.Framework;
using System;

namespace SampleTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup method");
        }
        [TearDown]
        public void Destroy()
        {
            Console.WriteLine("Teardown method");
        }
        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1 method");
        }
        [Test]
        public void SampleTest()
        {
            Console.WriteLine("Sample Test method");
        }        
    }
}