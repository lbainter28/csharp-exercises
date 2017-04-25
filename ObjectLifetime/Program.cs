using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //            Car myCar = new Car(/*calling the empty constructor method*/);
            //            // Make is set in constructor
            //            myCar.Make = "Pontiac";
            //            myCar.Model = "G6";
            //            myCar.Year = 2007;
            //            myCar.Color = "Black";

            // using the overloaded constructor
            Car myCar = new Car(
                "Pontiac",
                "G6",
                2007,
                "Black"
            );

            Car.MyMethod();

            Car myOtherCar;
            // both variable reference the same object
            // in memory
            myOtherCar = myCar;

            Console.WriteLine(
                "{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color
            );

            // changing a property on one variable will be
            // reflected in the other variable, since they
            // both point to the same object in memory
            myOtherCar.Model = "G7";

            Console.WriteLine(
                "{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color
            );

            // will throw an exception!
            //            myOtherCar = null;
            //            Console.WriteLine(
            //                "{0} {1} {2} {3}",
            //                myOtherCar.Make,
            //                myOtherCar.Model,
            //                myOtherCar.Year,
            //                myOtherCar.Color
            //            );

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Make = "Pontiac";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void MyMethod()
        {
            Console.WriteLine("Called static method");
        }
    }
}
