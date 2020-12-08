using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Interfaces
{
    interface IElectircCar
    {
        double BatteryCapacity { get; set; }
        double EnergyFor100Km { get; set; }
        double ChargeTime { get; set;}


    }
}
