using System;
using System.Collections.Generic;
//C# lms p. 147


class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int> {3, 13, 12, 94, 48, 2, 18};
        string newMessage = "The program is exiting this error and returning to the user input.\nPress enter to continue..";
        try
        {
            Console.WriteLine("Please enter a number.");
            int divisor = Convert.ToInt32(Console.ReadLine());
            foreach (int dividend in nums)
            {
                int quotient = dividend / divisor;
                Console.WriteLine(dividend + " divided by " + divisor + " equals " + quotient );
            }
            Console.WriteLine("\nIf you'd like to try a differnt divisor, press \"Enter\"");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message + "Numbers cannot be divided by zero. \n" + newMessage);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Input requires a whole number in decimal form. " + newMessage);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + newMessage);
        }
        finally
        {
            Console.ReadLine();
            Main(args);
        }
    }
}

