using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarPark.BaseClasses
{
    [Serializable]
    [XmlInclude(typeof(ElectricCar))]
    [XmlInclude(typeof(PetrolCar))]
    [XmlInclude(typeof(RentableElectricCar))]
    [XmlInclude(typeof(RentablePetrolCar))]
    [XmlInclude(typeof(PassengerPetrolTaxi))]
   
    public abstract class Car
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string VIN { get; set; }
        public int YearOfIssue { get; set; }
        public double Milleage { get; set; }
        public double CarCost { get; set; }
        public int AmountOfPassengers { get; set; }

        //public abstract double MaxDistanse { get; private set; }
       
        public double AcceleretionTo100KmphTime { get; set; }
        public virtual string GetCarInfo()
        {
            return ToString();
        }
        //public abstract double CalculateMaxDistanse();

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
            return "Car Model: " + CarBrand + " \nCarModel " + CarModel + " \nVIN Number: " + VIN + " \nYear Of Issue: " +
                   YearOfIssue + "\nMilleage: " + Milleage + " \nCar Cost: " + CarCost + " \nAmount Of Passengers: " + AmountOfPassengers + "\nAcceleration:" + AcceleretionTo100KmphTime ;
        }
        public Car()
        {

        }
    }
}
