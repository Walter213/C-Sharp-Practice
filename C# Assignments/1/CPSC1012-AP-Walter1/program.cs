using System;

namespace CPSC1012_AP_Walter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 0;
            double Weight = 0, LiquidByAge = 0, LiquidByWeight = 0;
            bool RightInput = true;

            Console.WriteLine("*****************");
            Console.WriteLine("* Fever Control *");
            Console.WriteLine("*****************");

            while (RightInput == true)
            {
                bool Input = true;

                while (Input == true)
                {
                    Weight = GetDouble("Enter the children's weight in pounds: ");

                    if (Weight > 95 || Weight < 24)
                    {
                        Console.WriteLine("Invalid weight for child acetaminophen. Weight must be between 24 and 95 lbs.");
                    }
                    else
                    {
                        Input = false;
                    }
                }

                bool OtherInput = true;

                while (OtherInput == true)
                {
                    Age = GetInt("Enter the children's age in years: ");

                    if (Age < 2 || Age > 11)
                    {
                        Console.WriteLine("Invalid age for children acetaminophen. Age must be between 2 and 11.");
                    }
                    else
                    {
                        Console.WriteLine("Weight: {0,2} lbs, Age: {1,1} years old", Weight, Age);
                        OtherInput = false;
                    }
                }

                Console.Write("Is the information above about the children correct (Y/N) >> ");
                char cInput = Convert.ToChar(Console.ReadLine());

                if (cInput == 'n' || cInput == 'N')
                {
                    Console.Write("Do you want to restart this program? [Y/N] >> ");
                    char OutInput = Convert.ToChar(Console.ReadLine());

                    if (OutInput == 'y' || OutInput == 'Y')
                    {
                        RightInput = true;
                        OtherInput = true;
                        Input = true;
                    }

                    if (OutInput == 'n' || OutInput == 'N')
                    {
                        RightInput = false;
                        Console.WriteLine("See ya later");
                    }
                }

                if (cInput == 'y' || cInput == 'Y')
                {
                    Acetaminophen Liquid = new Acetaminophen();

                    LiquidByWeight = Liquid.LiquidDosageByWeight(Weight);

                    LiquidByAge = Liquid.LiquidDosageByAge(Age);

                    Console.WriteLine("Dosage by weight ({0,2}lbs) is: {1,1} ml", Weight, LiquidByWeight);

                    Console.WriteLine("Dosage by age ({0,1} years) is: {1,1}", Age, LiquidByAge);

                    Console.Write("Do you want to restart this program? [Y/N] >> ");
                    char OutInput = Convert.ToChar(Console.ReadLine());

                    if (OutInput == 'y' || OutInput == 'Y')
                    {
                        RightInput = true;
                        OtherInput = true;
                        Input = true;
                    }

                    if (OutInput == 'n' || OutInput == 'N')
                    {
                        RightInput = false;
                        Console.WriteLine("See ya later");
                    }
                }

            }
        }        

        static int GetInt(string prompt)
        {
            int value = 0;
            bool bValid = false;
            while (bValid == false) 
            {
                try
                {
                    Console.Write(prompt);
                    value = Convert.ToInt32(Console.ReadLine());
                    bValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input... try again.\n");
                }
            }
            return value;
        } // closes GetDouble

        static double GetDouble(string prompt)
        {
            double value = 0.0;
            bool bValid = false;
            while (!bValid) // bValid == false
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
        } // closes GetDouble
    }
}