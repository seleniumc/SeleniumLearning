using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.ClassAndObjects
{
    class Fruit
    {
        public string name { get; set; }
        public string taste { get; set; }
        public string color { get; set; }

        public Fruit()
        {

        }
        public Fruit(string fruitName, string fruitTaste, string fruitColor)
        {
            this.color = fruitColor;
            this.name = fruitName;
            this.taste = fruitTaste;
        }

    }
}
