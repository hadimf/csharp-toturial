using System;

namespace Calculator
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        private double _result;
        private string _operand;
        public string Operand { set { _operand = value; } }

        public void ShowOperands()
        {
            Console.WriteLine("Operands: ");
            Console.WriteLine("\t + : Add");
            Console.WriteLine("\t - : Subtract");
            Console.WriteLine("\t * : Multiply");
            Console.WriteLine("\t / : Divide");
        }

        public void processing()
        {
            switch (_operand)
            {
                case "+":
                    _result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    _result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    _result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    _result = FirstNumber / SecondNumber;
                    break;

                default:
                    throw new Exception("That was not valid operand.");
            }
        }

        public override string ToString()
        {
            return $"The result is : {FirstNumber} {_operand} {SecondNumber} = {_result}";
        }
    }
}
