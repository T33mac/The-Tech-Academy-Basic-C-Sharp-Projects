using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nEnter a whole number in decimal form:");
        string number1 = Console.ReadLine();
        long Num1 = Convert.ToInt64(number1);
        long product = Num1 * 50;
        Console.WriteLine("\n" + number1 + " * 50 = " + product);

        Console.WriteLine("\n\nEnter another whole number in decimal form:");
        string number2 = Console.ReadLine();
        long Num2 = Convert.ToInt64(number2);
        long total = Num2 + 25;
        Console.WriteLine("\n" + number2 + " + 25 = " + total);

        Console.WriteLine("\nEnter another whole number in decimal form:");
        string number3 = Console.ReadLine();
        long Num3 = Convert.ToInt64(number3);
        double quotient = Num3 / 12.5;
        Console.WriteLine("\n" + number3 + " / 12.5 = " + quotient);

        Console.WriteLine("\nEnter another whole number in decimal form:");
        string number4 = Console.ReadLine();
        long Num4 = Convert.ToInt64(number4);
        bool trueFalse = Num4 > 50;
        Console.WriteLine("\nIs " + number4 + " greater than 50?\n\t\"" + trueFalse + "\"");

        Console.WriteLine("\nEnter another whole number in decimal form:");
        string number5 = Console.ReadLine();
        long Num5 = Convert.ToInt64(number5);
        long remainder = Num5 % 7;
        Console.WriteLine("\nThe remainder of " + number5 + " divided by 7 = " + remainder);
        Console.ReadLine();
    }
}

