using System;
using System.Collections.Generic;
using System.Text;

namespace CPSC1012_AP_Walter1
{
    class Acetaminophen
    {
        public int Age;
        public double Weight;

        public Acetaminophen()
        {
            Age = 2;
            Weight = 24; 
        }

        public double LiquidDosageByWeight(double Weight)
        {
            double LiquidByWeight = 0;

            if (Weight >= 24 && Weight <= 35)
            {
                LiquidByWeight = 5;
            }

            if (Weight >= 36 && Weight <= 47)
            {
                LiquidByWeight = 7.5;
            }

            if (Weight >= 48 && Weight <= 59)
            {
                LiquidByWeight = 10;
            }

            if (Weight >= 60 && Weight <= 71)
            {
                LiquidByWeight = 12.5;
            }

            if (Weight >= 72 && Weight <= 95)
            {
                LiquidByWeight = 15;
            }

            return LiquidByWeight;
        }

        public double LiquidDosageByAge(int Age)
        {
            double LiquidByAge = 0;

            if (Age == 2 || Age == 3)
            {
                LiquidByAge = 5;
            }

            if (Age == 4 || Age == 5)
            {
                LiquidByAge = 7.5;
            }

            if (Age == 6 || Age == 7 || Age == 8)
            {
                LiquidByAge = 10;
            }

            if (Age == 9 || Age == 10)
            {
                LiquidByAge = 12.5;
            }

            if (Age == 11)
            {
                LiquidByAge = 15;
            }

            return LiquidByAge;
        }
    }
}
