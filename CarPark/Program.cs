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
            List<Car> cars = new List<Car>();
            
            Serializer serializer = new Serializer();
            PassengerPetrolTaxi taxi = new PassengerPetrolTaxi("brand", "model", "123", 12, 123.3, 2333.33, 21 ,4.3, 123.4, 12.4, 23.3, 1.3);
            cars.Add(taxi);
            RentableElectricCar rentableElectricCar = new RentableElectricCar("asd", "asd", "asd", 123, 12.3, 12.3, 2, 23.4, 23.4, 12.23, 23);
            cars.Add(rentableElectricCar);
            Serializer.SerializeCars(cars);
           
        }
    }
}
