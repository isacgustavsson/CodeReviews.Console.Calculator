using CalcLib;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("--------------------------");

            Calculator calculator = new Calculator();

            while (!endApp)
            {
                string? numInput1 = "";
                string? numInput2 = "";
                double cleanNum1 = 0;
                double cleanNum2 = 0;
                double result = 0;

                Console.WriteLine("Enter a number and press Enter:");
                numInput1 = Console.ReadLine();

                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Enter another number and press Enter:");
                numInput2 = Console.ReadLine();

                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an operator:");
                Console.WriteLine("a - Add");
                Console.WriteLine("s - Subtract");
                Console.WriteLine("m - Multiply");
                Console.WriteLine("d - Divide");

                string? op = Console.ReadLine();

                if (op == null || (op != "a" && op != "s" && op != "m" && op != "d"))
                {
                    Console.WriteLine("Invalid operator, try again.");
                }
                else
                {
                    try
                    {
                        result = calculator.DoOperation(cleanNum1, cleanNum2, op);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("This operation will result in a mathematical error.");
                        }
                        else
                        {
                            Console.WriteLine("Your result: {0:0.##}\n", result);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: An exception occurred - " + e.Message);
                    }
                }

                Console.Write("Press 'n' to exit, or any other key to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine(); // spacing
            }
                calculator.Finish();
        }
    }
}