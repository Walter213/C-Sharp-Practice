using System;

namespace CPSC1012_AP_Walter2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length = 0, Width = 0, Area = 0, TotalCost = 0;

            Console.WriteLine("*********************");
            Console.WriteLine("* Carpet Calculator *");
            Console.WriteLine("*********************");

            bool Test = true;

            while (Test == true)
            {
                Length = GetDouble("Enter the room length in feet: ");

                if (Length <= 0)
                {
                    Console.WriteLine("Enter In A Length Greater Than 0");
                }
                else
                {
                    Test = false;
                }
            }

            Test = true;

            while (Test == true)
            {
                Width = GetDouble("Enter the room width in feet: ");

                if (Width <= 0)
                {
                    Console.WriteLine("Enter In A Width Greater Than 0");
                }
                else
                {
                    Test = false;
                }
            }

            double CostPerSquareFoot = GetDouble("Enter the carpet cost per square foot: ");

            RoomDimension Carpet = new RoomDimension();

            Carpet.SetLength(Length);
            Carpet.SetWidth(Width);

            RoomCarpet Cost = new RoomCarpet();

            Cost.SetCost(CostPerSquareFoot);

            Area = Carpet.Area();

            Console.WriteLine("Length = {0}, Width = {1}, Area = {2}", Carpet.GetLength(), Carpet.GetWidth(), Area);

            TotalCost = Cost.TotalCost(Area);                     //double TotalCost = Area * CostPerSquareFoot;

            Console.WriteLine("The total cost of the carpet is {0:c}", TotalCost);
        }

        static double GetDouble(string prompt)
        {
            double value = 0.0;
            bool bValid = false;
            while (bValid == false)
            {
                try
                {
                    Console.Write(prompt);
                    value = Convert.ToDouble(Console.ReadLine());
                    bValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input... try again.\n");
                }
            }
            return value;
        }
    }
}
