using System;
using System.Collections.Generic;
using System.Text;

namespace CPSC1012_AP_Walter2
{
    class RoomCarpet
    {
        public double CostPerSquareFoot;
        RoomDimension Room = new RoomDimension();

        public RoomCarpet()
        {
            CostPerSquareFoot = 0.0;
        }

        public void SetCost(double param)
        {
            CostPerSquareFoot = param;
        }

        public double GetCost()
        {
            return CostPerSquareFoot;
        }

        public double TotalCost(double Area)
        {
            double TotalCost = 0;

            TotalCost = Area * CostPerSquareFoot;

            return TotalCost;
        }
    }
}
