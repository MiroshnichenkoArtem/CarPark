using CarPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.BaseClasses
{
    [Serializable]
    public class RentableElectricCar : ElectricCar, IRentable
    {
        
       
        public bool IsRentingNow  { get; set; }
       
        public double DailyPayment
        {
            get;set;
        }
       

        public double CalculateRentPayment(IRentable car, int days)
        {
            return DailyPayment * days;
        }
        public RentableElectricCar(string carBrand, string carModel, string vin,
                      int yearOfIssue, double milleage, double carCost,
                      int amountOfPassengers, double acceleretionTo100KmphTime, double batteryCapacity,
                      double energyFor100Km, int chargeTime)
                    : base(carBrand, carModel, vin, yearOfIssue, milleage, carCost, amountOfPassengers, acceleretionTo100KmphTime,batteryCapacity,energyFor100Km,chargeTime)
        {
            BatteryCapacity = batteryCapacity;
            EnergyFor100Km = energyFor100Km;
            ChargeTime = chargeTime;
            MaxDistanse = CalculateMaxDistanse();
            IsRentingNow = false;
        }
        public override string ToString()
        {
            return base.ToString() + "\nIs renting now: " + IsRentingNow + " \nDailyPayment: ";
        }
        public RentableElectricCar()
        {

        }
    }
}
