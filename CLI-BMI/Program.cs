using System;

namespace CLI_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckCommand(args);
            RunComand(args);
        }


        static void InvalidComand()
        {
            System.Console.WriteLine("Invalid Command :(");
            System.Console.WriteLine("Use --helps  switch to show help");
            Environment.Exit(0);

        }

        static void CheckCommand(string[] array)
        {
            if (array.Length == 0 || array[0] != "bmi")
            {
                InvalidComand();
                Environment.Exit(0);
            }
            else if (array.Length == 1)
            {
                InvalidComand();
                Environment.Exit(0);
            }
            else if (array.Length == 2)
            {
                if (array[1] == "--version")
                {
                    ShowVersion();

                }
                else if (array[1] == "--helps")
                {
                    ShowHelps();

                }
                else
                {
                    InvalidComand();
                    Environment.Exit(0);

                }
            }
            else if (array.Length != 5)
            {
                InvalidComand();
                Environment.Exit(0);

            }
        }

        static void ShowVersion()
        {
            System.Console.WriteLine("Current Version is 1.0.1");
            Environment.Exit(0);

        }

        static void ShowHelps()
        {
            System.Console.WriteLine("Use these switch to run program:");
            System.Console.WriteLine("--height \t Your height (meters)");
            System.Console.WriteLine("--weight \t Your weight (kolograms)");
            System.Console.WriteLine("--version \t Show current version");
            System.Console.WriteLine("--helps \t Show helps");
            Environment.Exit(0);

        }

        static void CalculateBmi(double height, double weight)
        {
            var bmi = weight / (height * height);
            if (bmi < 18.5)
            {
                System.Console.WriteLine("Underweight");

            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                System.Console.WriteLine("Normal weight");
            }
            else if (bmi >= 25)
            {
                System.Console.WriteLine("Overweight");
            }

        }
        static void RunComand(string[] array)
        {
            var switchOne = array[1];
            var switchTwo = array[3];
            var valOne = Convert.ToDouble(array[2]);
            var valTwo = Convert.ToDouble(array[4]);


            if (switchOne == "--height" && switchTwo == "--weight")
            {
                // Convert centimeter to meter
                valOne = valOne / 100;
                System.Console.WriteLine(valOne);
                System.Console.WriteLine(valTwo);
                CalculateBmi(valOne, valTwo);

            }
            else if (switchTwo == "--height" && switchOne == "--weight")
            {
                // Convert centimeter to meter
                valTwo = valTwo / 100;
                CalculateBmi(valTwo, valOne);
            }
            else
            {
                InvalidComand();
                Environment.Exit(0);

            }

        }

    }
}

