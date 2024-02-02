using System;
using Task2Calculator;

namespace Task1Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = null;
            int option = -1;

            while (option != 14)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create a Single Object of Calculator");
                Console.WriteLine("2. Change Values of Attributes");
                Console.WriteLine("3. Add");
                Console.WriteLine("4. Subtract");
                Console.WriteLine("5. Multiply");
                Console.WriteLine("6. Divide");
                Console.WriteLine("7. Modulo");
                Console.WriteLine("8. Square Root");
                Console.WriteLine("9. Exponential Function");
                Console.WriteLine("10. Logarithm");
                Console.WriteLine("11. Sine");
                Console.WriteLine("12. Cosine");
                Console.WriteLine("13. Tangent");
                Console.WriteLine("14. Exit");
                Console.Write("Enter option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        if (calculator == null)
                        {
                            calculator = new Calculator();
                            Console.WriteLine("Calculator object created with default values (20 and 20).");
                        }
                        else
                        {
                            Console.WriteLine("Calculator object already exists.");
                        }
                        break;
                    case 2:
                        if (calculator != null)
                        {
                            Console.Write("Enter new value for number1: ");
                            double newValue1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter new value for number2: ");
                            double newValue2 = double.Parse(Console.ReadLine());
                            calculator.Number1 = newValue1;
                            calculator.Number2 = newValue2;
                            Console.WriteLine("Values updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 3:
                        if (calculator != null)
                        {
                            Console.WriteLine("Addition result: " + calculator.Add());
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 4:
                        if (calculator != null)
                        {
                            Console.WriteLine("Subtraction result: " + calculator.Subtract());
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 5:
                        if (calculator != null)
                        {
                            Console.WriteLine("Multiplication result: " + calculator.Multiply());
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 6:
                        if (calculator != null)
                        {
                            Console.WriteLine("Division result: " + calculator.Divide());
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 7:
                        if (calculator != null)
                        {
                            Console.WriteLine("Modulo result: " + calculator.Modulo());
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 8:
                        if (calculator != null)
                        {
                            Console.Write("Enter a number to calculate square root: ");
                            double number = double.Parse(Console.ReadLine());
                            Console.WriteLine("Square root: " + calculator.Sqrt(number));
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 9:
                        if (calculator != null)
                        {
                            Console.Write("Enter an exponent: ");
                            double exponent = double.Parse(Console.ReadLine());
                            Console.WriteLine("Exponential function result: " + calculator.Exp(exponent));
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 10:
                        if (calculator != null)
                        {
                            Console.Write("Enter a number to calculate logarithm: ");
                            double number = double.Parse(Console.ReadLine());
                            Console.WriteLine("Logarithm result: " + calculator.Log(number));
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 11:
                        if (calculator != null)
                        {
                            Console.Write("Enter an angle in degrees to calculate sine: ");
                            double angle = double.Parse(Console.ReadLine());
                            Console.WriteLine("Sine result: " + calculator.Sin(angle));
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 12:
                        if (calculator != null)
                        {
                            Console.Write("Enter an angle in degrees to calculate cosine: ");
                            double angle = double.Parse(Console.ReadLine());
                            Console.WriteLine("Cosine result: " + calculator.Cos(angle));
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 13:
                        if (calculator != null)
                        {
                            Console.Write("Enter an angle in degrees to calculate tangent: ");
                            double angle = double.Parse(Console.ReadLine());
                            Console.WriteLine("Tangent result: " + calculator.Tan(angle));
                        }
                        else
                        {
                            Console.WriteLine("Calculator object not created yet. Please create one first.");
                        }
                        break;
                    case 14:
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
