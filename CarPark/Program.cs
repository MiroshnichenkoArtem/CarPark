using CarPark.BaseClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //  List<Car> cars = new List<Car>();

            //  Serializer serializer = new Serializer();
            //  PassengerPetrolTaxi taxi = new PassengerPetrolTaxi("BMW", "X-5", "01234", 2001, 2500.5, 35000.25, 3 ,4.3, 5.6, 50.4, 3.5, 10.5);
            //  cars.Add(taxi);
            //  RentableElectricCar rentableElectricCar = new RentableElectricCar("Tesla", "Model Y", "43210", 2018, 12.50, 18000.50, 3, 4.5, 2500.25, 12.23, 23);
            //  cars.Add(rentableElectricCar);
            ////  RentablePetrolCar rentablePetrol = new RentablePetrolCar("") 
            //  Serializer.SerializeCars(cars);
            CarPark carPark = new CarPark();
           // carPark.SortCarsByFuelConsumption();
            //carPark.OutputAllCars();

            //carPark.FindCarsBySpeedRange(0,5);
            Console.WriteLine(carPark.CalculateTotalPriceOfCars());
            // carPark.OutputAllCars();


        }
    }
}
