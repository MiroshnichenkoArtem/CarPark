using CarPark.BaseClasses;
using System;

namespace CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            RentingCenter center = new RentingCenter();
            center.OutputCars();
        }
    }
}
