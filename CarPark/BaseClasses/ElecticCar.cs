using CarPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.BaseClasses
{
    public class ElecticCar : Car, IElectircCar
    {
        public double BatteryCapacity { get; set ; }
        public double EnergyFor100Km { get; set;}
        public double ChargeTime { get ; set; }

        public override double CalculateMaxDistanse()
        {
            return BatteryCapacity / EnergyFor100Km;
        }

        public override string GetCarInfo()
        {
            return ToString();
        }
        public ElecticCar(string carBrand, string carModel, string vin,
                      int yearOfIssue, double milleage, double carCost,
                      int amountOfPassengers, double acceleretionTo100KmphTime, double batteryCapacity,
                      double energyFor100Km, int chargeTime)
                    : base(carBrand, carModel, vin, yearOfIssue,milleage,carCost,amountOfPassengers,acceleretionTo100KmphTime)
        {
            BatteryCapacity = batteryCapacity;
            EnergyFor100Km = energyFor100Km;
            ChargeTime = chargeTime;
        }

        public override string ToString()
        {
            return base.ToString() + " BatteryCapasity " + BatteryCapacity + " EnergyFor100Km: " + EnergyFor100Km
                                   + " ChargeTime: " + ChargeTime;
        }
    }
}
