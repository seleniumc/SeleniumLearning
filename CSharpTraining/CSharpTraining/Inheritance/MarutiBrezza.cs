using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.Inheritance
{
    class MarutiBrezza : ICar
    {
        private string batchNumber,make,model,year;
        public string getBatchNumber()
        {
            return batchNumber;
        }

        public string getMake()
        {
            return make;
        }

        public string getModel()
        {
            return model;
        }

        public string getYear()
        {
            return year;
        }
    }
}
