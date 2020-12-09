using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Interfaces
{
    public interface IRentable
    {
        bool IsRentingNow { get; set; }
        double DailyPayment { get; set; }
       public double CalculateRentPayment(IRentable car, int days);
    }
}
