using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");
        Console.WriteLine("\nPlease enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());
        if (weight <= 50)
        {
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());
            int cost = ((weight * width) * (length * height)) / 100;
            string total = ((width + height + length) <= 50 ? "Your estimated total for shipping this package is: $" + cost + ".00\nThank you!": 
                "Package too big to shipped with Package Express.");
            Console.WriteLine(total);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        }
    }
}

