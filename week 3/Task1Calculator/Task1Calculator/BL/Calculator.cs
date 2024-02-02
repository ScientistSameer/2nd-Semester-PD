using System;

namespace Task1Calculator
{
    public class Calculator
    {
        public double Number1;
        public double Number2;

        public Calculator(double number1 = 20, double number2 = 20)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public double Add()
        {
            return Number1 + Number2;
        }

        public double Subtract()
        {
            return Number1 - Number2;
        }

        public double Multiply()
        {
            return Number1 * Number2;
        }

        public double Divide()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
            }
            return Number1 / Number2;
        }

        public double Modulo()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
            }
            return Number1 % Number2;
        }
    }
}

    