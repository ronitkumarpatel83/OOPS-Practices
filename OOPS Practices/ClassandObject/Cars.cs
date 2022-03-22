using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practices.ClassandObject
{
    internal class Car
    {
        public string carName, carColor;

        public Car(string carName, string carColor)
        {
            this.carName = carName;
            this.carColor = carColor;
        }
        public void CarDetails()
        {
            Console.WriteLine($"Car name is : {carName}\nColor name is : {carColor}\n");
        }

    }
}