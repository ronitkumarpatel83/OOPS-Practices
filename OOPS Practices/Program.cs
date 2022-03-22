
using OOPS_Practices.ClassandObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Fruit fruit = new Fruit("red","Apple");
            fruit.FruitDetails();


            Car car = new Car("Camaro","Yellow");
            car.CarDetails();

            Phone phone = new Phone("Samsung", "White");
            phone.PhoneDetails();
        }
    }
}
