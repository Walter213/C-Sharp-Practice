using System;
using System.Collections.Generic;
using System.Text;

namespace CPSC1012_AP_Walter2
{
    class RoomDimension
    {
        public double Length;
        public double Width;

        public RoomDimension()
        {
            Length = 0.0;
            Width = 0.0;
        }

        public void SetLength(double param)
        {
            Length = param;
        }

        public double GetLength()
        {
            return Length;
        }

        public void SetWidth(double param)
        {
            Width = param;
        }

        public double GetWidth()
        {
            return Width;
        }

        public double Area()
        {
            double Area = 0;

            Area = Length * Width;

            return Area;
        }
    }
}
