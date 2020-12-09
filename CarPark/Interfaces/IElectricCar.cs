﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Interfaces
{
    public interface IElectricCar
    {
        double BatteryCapacity { get; set; }
        double EnergyFor100Km { get; set; }
        double ChargeTime { get; set;}


    }
}
