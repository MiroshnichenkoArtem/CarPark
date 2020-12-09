using CarPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.BaseClasses
{
    class RentablePetrolCar : PetrolCar,IRentable
    {
        public bool IsRentingNow { get; set; }

        public double DailyPayment
        {
            get; set;
        }
       
        public double CalculateRentPayment(IRentable car, int days)
        {
            return DailyPayment * days;
        }
        public RentablePetrolCar(string carBrand, string carModel, string vin,
                      int yearOfIssue, double milleage, double carCost,
                      int amountOfPassengers, double acceleretionTo100KmphTime,
                      double canVolume, double engineVolume, double fuelConsumptionFor100Km)
            : base(carBrand, carModel, vin, yearOfIssue, milleage, carCost, amountOfPassengers, acceleretionTo100KmphTime,canVolume,engineVolume,fuelConsumptionFor100Km)
        {
            CanVolume = canVolume;
            EngineVolume = engineVolume;
            FuelConsumptionFor100km = fuelConsumptionFor100Km;
            MaxDistanse = CalculateMaxDistanse();
            IsRentingNow = false;
        }
        public override string ToString()
        {
            return base.ToString() + "\nIs renting now: " + IsRentingNow + " \nDailyPayment: ";
        }
    }
}
