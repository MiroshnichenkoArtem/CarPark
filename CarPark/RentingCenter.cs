using CarPark.BaseClasses;
using CarPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    public class RentingCenter
    {
        private IEnumerable<Car> _allCars;
        private IEnumerable<IRentable> _rentingCars;

        public RentingCenter()
        {
            FileParser fileParser = new FileParser();
            _allCars = fileParser.GetAllCars();
        }
        public void OutputCars()
        {
            foreach(var car in _allCars)
            {
                Console.WriteLine(car.GetCarInfo()); 
            }
        }
        
    }
}
