using System;
using System.Collections.Generic;

namespace Lab_2_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage(new List<Car> { new Car(), new Car(), new Car() });
            Washer washer = new Washer();
            Action<Car> washDelegate = washer.Wash;

            foreach (var car in garage)
            {
                washDelegate(car);
            }
        }
    }
}
