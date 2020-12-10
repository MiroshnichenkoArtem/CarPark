using CarPark.BaseClasses;
using CarPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPark
{
    public class CarPark
    {
        public  IEnumerable<Car> AllCars { get; private set; }
        public IEnumerable<Car> ElectricCars { get; private set; }
        public IEnumerable<Car> PetrolCars { get; private set; }

        

        public CarPark()
        {
            CarDatabase carDatabase = new CarDatabase();
            AllCars = carDatabase.GetAllCars();
            ElectricCars = carDatabase.GetAllElectricCars();
            PetrolCars = carDatabase.GetAllPetrolCars();
        }
        public void OutputAllCars()
        {
            foreach(var car in AllCars)
            {
                Console.WriteLine(car.GetCarInfo()); 
            }
        }

        public void SortCarsByFuelConsumption()
        {
            
            var sortedElCars = ElectricCars.Cast<IElectricCar>().OrderBy(o => o.EnergyFor100Km).Cast<Car>();
            var sortedPetrolCars = (IEnumerable<Car>)PetrolCars.Cast<IPetrolCar>().OrderBy(o => o.FuelConsumptionFor100km).Cast<Car>();
            AllCars = sortedElCars.Concat(sortedPetrolCars);

        }
        
        public void FindCarsBySpeedRange(double min, double max)
        {
            var validCars = AllCars.Where(car => car.AcceleretionTo100KmphTime <= max && car.AcceleretionTo100KmphTime >= min);
            foreach(var car in validCars)
            {
                Console.WriteLine(car.GetCarInfo());
            }
        }

        public double CalculateTotalPriceOfCars()
        {
            double totalCost = 0;
            foreach (var car in AllCars)
            {
                totalCost += car.CarCost;
            }
            return totalCost;

        }
    }
}
