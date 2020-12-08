using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Interfaces
{
    interface IPetrolCar
    {
        double CanVolume { get; set; }
        double EngineVolume { get; set; }

        double FuelConsumptionFor100km { get; set; }      
        //pertrol type
    }
}
