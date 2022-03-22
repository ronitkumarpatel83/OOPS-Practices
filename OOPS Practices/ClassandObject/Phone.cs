using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practices.ClassandObject
{
    internal class Phone
    {
        public string color, name;

        public Phone(string color, string n)
        {
            this.color = color;
            name = n;
        }

        public void PhoneDetails()
        {
            Console.WriteLine($"Phone name is : {name}\nColor name is : {color}\n");

        }
    }
}
