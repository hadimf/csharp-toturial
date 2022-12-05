using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            do
            {
                
                Console.Clear();
                Console.WriteLine("******************");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("******************");

                // get numbers from user
                SetNumbers(calculator);

                // show operans
                calculator.ShowOperands();
                
                // get operan from user
                Console.Write("Enter a Operand: ");
                calculator.Operand = Console.ReadLine();

                // validate the operand
                try
                {
                    calculator.processing();
                    Console.WriteLine(calculator);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }


                Console.WriteLine("Do you  want Again? (Y:Yes/ N:No)");

            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("BYE...");
        }

        private static void SetNumbers(Calculator calculator)
        {
            Console.Write("Enter first number: ");
            calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());

        }
    }
}
