using CarPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarPark.BaseClasses
{
   public class CarDatabase
   {
        private  Serializer _serializer;
        private IEnumerable<Car> _allCars;
        public CarDatabase()
        {
            _serializer = new Serializer();
            _allCars = _serializer.GetAllCars();
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _allCars;
        }
        public IEnumerable<Car> GetAllTaxiCars()
        {
            return _allCars.Where(i => i is ITaxiCar);
        }

        public IEnumerable<Car> GetAllElectricCars()
        {
            return _allCars.Where(i => i is IElectricCar);
        } 
        public IEnumerable<Car> GetAllPetrolCars()
        {
            return _allCars.Where(i => i is IPetrolCar);
        }
   }
}
