using System;

namespace Task2Calculator
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

        public double Sqrt(double number)
        {
            if (number < 0)
            {
                Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                return 0;
            }
            return Math.Sqrt(number);
        }
        public double Exp(double exponent)
        {
            return Math.Exp(exponent);
        }

        public double Log(double number)
        {
            if (number <= 0)
            {
                Console.WriteLine("Error: Cannot calculate logarithm of a non-positive number.");
                return 0;
            }
            return Math.Log(number);
        }

        public double Sin(double degrees)
        {
            return Math.Sin(degrees * Math.PI / 180); 
        }

        public double Cos(double degrees)
        {
            return Math.Cos(degrees * Math.PI / 180); 
        }

        public double Tan(double degrees)
        {
            return Math.Tan(degrees * Math.PI / 180);
        }
    }
}
