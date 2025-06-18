// // Calculator app

// float num1 = 0;
// float num2 = 0;

// Console.WriteLine("---------------------------------------");
// Console.WriteLine("");
// Console.WriteLine("\tCalculator app");
// Console.WriteLine("");
// Console.WriteLine("---------------------------------------");
// Console.WriteLine("");

// Console.WriteLine("Please enter the first number.");
// // num1 = Convert.ToInt32(Console.ReadLine());
// num1 = float.Parse(Console.ReadLine());

// Console.WriteLine("Please enter the second number.");
// // num2 = Convert.ToInt32(Console.ReadLine());
// num2 = float.Parse(Console.ReadLine());

// Console.WriteLine(@"Choose operation
// A - Addition
// S - Subtraction
// M - Multiplication
// D - Division
// ");

// switch (Console.ReadLine().Trim().ToLower())
// {
//     case "a":
//         Console.WriteLine($"Result: " + (num1 + num2));
//         break;
//     case "s":
//         Console.WriteLine($"Result: " + (num1 - num2));
//         break;
//     case "m":
//         Console.WriteLine($"Result: " + (num1 * num2));
//         break;
//     case "d":
//         while (num2 == 0)
//         {
//             Console.WriteLine("Please enter a non-zero divisor: ");
//             num2 = float.Parse(Console.ReadLine());
//     }
//         Console.WriteLine($"Result: " + (num1 / num2));
//         break;
// }

// Console.WriteLine("Press any key to exit the Calculator.");
// Console.ReadLine();


class Calculator
{
    double result = double.NaN;
    public static double DoOperation(double num1, double num2, string op)
    {
        switch (op)
        {
            case "a":
                result = (num1 + num2);
                break;
            case "s":
                result = (num1 - num2);
                break;
            case "m":
                result = (num1 * num2);
                break;
            case "d":
                if (num2 != 0)
                {
                    result = (num1 / num2);
                }
                break;
            default:
                break;
        }
        return result;
    }
}
