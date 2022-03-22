using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practices.ClassandObject
{
    internal class Fruit
    {
        public string color, name;

        public Fruit(string color, string n)
        {
            this.color = color;
            name = n;
        }

        public void FruitDetails()
        {
            Console.WriteLine($"Fruit name is : {name}\nColor name is : {color}\n");

        }
    }
}
