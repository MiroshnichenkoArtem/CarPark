using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Interfaces
{
    public interface ITaxiCar
    {
        double CostPerUnit { get; set; }
        double CalculatePayment(int amountOfUnits);
    }
}
