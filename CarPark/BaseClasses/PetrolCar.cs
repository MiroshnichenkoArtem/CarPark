using CarPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.BaseClasses
{
    class PetrolCar : Car, IPetrolCar
    {
        public double CanVolume { get; set; }
        public double EngineVolume { get; set ; }
        public double FuelConsumptionFor100km { get; set; }

        protected double _maxDistanse;
        public double MaxDistanse { 
            get 
            {
                return _maxDistanse;
            }
            protected set 
            {
                //exception??
                _maxDistanse = value;
            } 
        }

        protected  double CalculateMaxDistanse()
        {
            return CanVolume / FuelConsumptionFor100km;
        }

        public override string GetCarInfo()
        {
            return ToString();
        }
        public PetrolCar(string carBrand, string carModel, string vin,
                      int yearOfIssue, double milleage, double carCost,
                      int amountOfPassengers, double acceleretionTo100KmphTime,
                      double canVolume,double engineVolume,double fuelConsumptionFor100Km)
            : base(carBrand, carModel, vin, yearOfIssue, milleage, carCost, amountOfPassengers, acceleretionTo100KmphTime)
        {
            CanVolume = canVolume;
            EngineVolume = engineVolume;
            FuelConsumptionFor100km = fuelConsumptionFor100Km;
            MaxDistanse = CalculateMaxDistanse();
        }
        public override string ToString()
        {
            return base.ToString() + "\nCan volume: " + CanVolume + "\nEngine volume: " + EngineVolume + "\nFuel for 100km" + FuelConsumptionFor100km;
        }
    }
}
