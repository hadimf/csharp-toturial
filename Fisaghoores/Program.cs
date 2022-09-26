using System;

namespace Fisaghoores
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Side A: ");
            var sideA = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Enter Side B: ");
            var sideB = Convert.ToDouble(Console.ReadLine());

            var result = (sideA * sideA) + (sideB * sideB);

            var sideC = Math.Sqrt(result);

            System.Console.WriteLine($"side C is {sideC}");
        }
    }
}
