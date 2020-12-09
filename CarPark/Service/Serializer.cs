using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CarPark.BaseClasses
{
    public class Serializer
    {
        private IEnumerable<Car> _allCars;
        private string _connectionPath = "cars.xml";

        public Serializer()
        {
           _allCars = DeserializeAllCars(_connectionPath);
        }
        public static void SerializeCars(IEnumerable<Car> cars)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
            using (FileStream fs = new FileStream("cars.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, cars);
                
            }
           
        }

        public IEnumerable<Car> DeserializeAllCars(string filePath)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Car>));
            List<Car> cars = new List<Car>();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                cars = (List<Car>)formatter.Deserialize(fs);
            }
            return cars;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _allCars;
        }
    }
}
