using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace CarPark.BaseClasses
{
     public class FileParser
    {
        private string _connectionStirng = System.IO.Path.Combine(Environment.CurrentDirectory, "cars.txt");

        private List<Car> _allCars;

        public FileParser()
        {
            _allCars = new List<Car>();
            var allRecords = File.ReadLines(_connectionStirng);
            foreach(var record in allRecords)
            {
                var currentRecord = record.Split(' ');
                Car car;
                switch (currentRecord[0])
                {
                    case "RentableElectricCar":
                        car = new RentableElectricCar(currentRecord[1], currentRecord[2], currentRecord[3], Convert.ToInt32(currentRecord[4]),
                                                       Convert.ToDouble(currentRecord[5]), Convert.ToDouble(currentRecord[6]), Convert.ToInt32(currentRecord[7]),
                                                       Convert.ToInt32(currentRecord[8]), Convert.ToInt32(currentRecord[9]), Convert.ToInt32(currentRecord[10]),
                                                       Convert.ToInt32(currentRecord[11]));
                        _allCars.Add(car);
                        break;

                    case "RentablePetrolCar":
                        car = new RentablePetrolCar(currentRecord[1], currentRecord[2], currentRecord[3], Convert.ToInt32(currentRecord[4]),
                                                       Convert.ToDouble(currentRecord[5]), Convert.ToDouble(currentRecord[6]), Convert.ToInt32(currentRecord[7]),
                                                       Convert.ToDouble(currentRecord[8]), Convert.ToDouble(currentRecord[9]), Convert.ToDouble(currentRecord[10]),
                                                       Convert.ToDouble(currentRecord[11]));
                        _allCars.Add(car);
                        break;
                    default:
                        break;
                }
            }
        }
        public IEnumerable<Car> GetAllCars()
        {
            return _allCars;
        }


        
    }
}
