using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SampleTestProject
{
    class SampleTestClass
    {
        [Test, TestCaseSource("GetDataFromCSV")]
        public void SampleTestCase(string a, int b, string c, int d)
        {
            Console.WriteLine(a + "\t" + b + "\t" + c + "\t" + d);
        }
        [Test, TestCaseSource("GetDataFromCSVInt")]
        public void SampleTestCaseIntegerDataSource(int a, int b,int c, int d)
        {
            Console.WriteLine(a + "\t" + b + "\t" + c + "\t" + d);
        }

        //Method to get data from CSV file
        private static IEnumerable<object[]> GetDataFromCSV()
        {
            CsvReader reader = new CsvReader("data.csv");
            while (reader.Next())
            {
                string column1 = (reader[0]);
                int column2 = Convert.ToInt32(reader[1]);
                string column3 = (reader[2]);
                int column4 = Convert.ToInt32(reader[3]);
                yield return new object[] { column1, column2, column3, column4 };
            }
        }

        //Method to get data from CSV file as integers
        private static IEnumerable<int[]> GetDataFromCSVInt()
        {
            CsvReader reader = new CsvReader("data2.csv");
            while (reader.Next())
            {
                int column1 = Convert.ToInt32(reader[0]);
                int column2 = Convert.ToInt32(reader[1]);
                int column3 = Convert.ToInt32(reader[2]);
                int column4 = Convert.ToInt32(reader[3]);
                yield return new int[] { column1, column2, column3, column4 };
            }
        }
    }
}
