using System;

public class TriangleIdentifier
{
    public static void Run()
    {
        Console.WriteLine("=== Triangle Type Identifier ===");

        Console.Write("Enter side A: ");
        string aInput = Console.ReadLine();

        Console.Write("Enter side B: ");
        string bInput = Console.ReadLine();

        Console.Write("Enter side C: ");
        string cInput = Console.ReadLine();

        if (double.TryParse(aInput, out double a) &&
            double.TryParse(bInput, out double b) &&
            double.TryParse(cInput, out double c))
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("This is an Equilateral triangle.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("This is an Isosceles triangle.");
                }
                else
                {
                    Console.WriteLine("This is a Scalene triangle.");
                }
            }
            else
            {
                Console.WriteLine("The sides do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
