using CarPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.BaseClasses
{
    [Serializable]
   public class PassengerPetrolTaxi : PetrolCar, ITaxiCar
    {
        public double CostPerUnit { get ; set ; }

        public double CalculatePayment(int amountOfKm)
        {
            return CostPerUnit * amountOfKm;
        }
        public PassengerPetrolTaxi(string carBrand, string carModel, string vin,
                      int yearOfIssue, double milleage, double carCost,
                      int amountOfPassengers, double acceleretionTo100KmphTime,
                      double canVolume, double engineVolume, double fuelConsumptionFor100Km,double costPerUnit)
                      :base(carBrand,carModel, vin,
                      yearOfIssue, milleage, carCost,
                      amountOfPassengers, acceleretionTo100KmphTime,
                      canVolume,  engineVolume, fuelConsumptionFor100Km)
        {
            CostPerUnit = costPerUnit;
        }
        public PassengerPetrolTaxi()
        {

        }
    }
}
