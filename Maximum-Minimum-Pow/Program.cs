using System;

namespace Maximum_Minimum_Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Two numbers to power it:");
            System.Console.WriteLine("Enter Number 1:");
            var numberOne = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Number 2:");
            var numberTwo = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(Power(numberOne, numberTwo));
            Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Enter 5 Numbers :");
            var numbers = new double[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            System.Console.WriteLine($"Maximum number is : {Maximum(numbers)}");
            System.Console.WriteLine($"Minimum number is : {Minimum(numbers)}");
        }
        static int Power(int number1, int number2)
        {
            int result = 1;
            for (int i = 1; i <= number2; i++)
            {
                result *= number1;
            }

            return result;
        }

        static double Maximum(double[] numbers)
        {
            var result = numbers[0];
            foreach (var number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }

            return result;
        }

        static double Minimum(double[] numbers)
        {

            var result = numbers[0];
            foreach (var number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }

            return result;
        }
    }
}
