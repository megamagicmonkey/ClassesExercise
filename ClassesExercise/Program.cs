using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.make = "Nissan";
            myCar.model = "Altima";
            myCar.year = 2012;

            Console.WriteLine($"{myCar.year} {myCar.make} {myCar.model}");
        }
    }
}
