using System;

public class TicketCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== Ticket Price Calculator ===");
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age <= 12 || age >= 65)
            {
                Console.WriteLine("You qualify for a discounted ticket. Price: GHC7");
            }
            else
            {
                Console.WriteLine("Standard ticket price: GHC10");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
