using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.BaseClasses
{
    public abstract class Car
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string VIN { get; set; }
        public int YearOfIssue { get; set; }
        public double Milleage { get; set; }
        public double CarCost { get; set; }
        public int AmountOfPassengers { get; set; }
       
        public double AcceleretionTo100KmphTime { get; set; }
        public abstract string GetCarInfo();
        public abstract double CalculateMaxDistanse();

        public Car(string carBrand, string carModel, string vin,
                      int yearOfIssue, double milleage, double carCost,
                      int amountOfPassengers, double acceleretionTo100KmphTime)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            VIN = vin;
            YearOfIssue = yearOfIssue;
            Milleage = milleage;
            CarCost = carCost;
            AmountOfPassengers = amountOfPassengers;
            AcceleretionTo100KmphTime = acceleretionTo100KmphTime;
        }

        public override string ToString()
        {
            return "Car Model: " + CarBrand + " CarModel " + CarModel + " VIN Number: " + VIN + " Year Of Issue: " +
                   YearOfIssue + "Milleage: " + Milleage + " Car Cost: " + CarCost + " Amount Of Passengers: " + AmountOfPassengers;
        }
    }
}
