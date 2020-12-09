using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Interfaces
{
    public interface IPetrolCar
    {
        double CanVolume { get; set; }
        double EngineVolume { get; set; }

        double FuelConsumptionFor100km { get; set; }      
        
    }
}
