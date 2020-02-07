using System;

//lms #72
class Program
{
    static void Main()
    {
        Console.WriteLine("\nThe Tech Academy\nStudent Daily Report\n\nWhat course are you on?:");
        string courseOn = Console.ReadLine();
        Console.WriteLine("\nWhat page number?:");
        string pageOn = Console.ReadLine();
        int pageNum = Convert.ToInt32(pageOn);
        Console.WriteLine("\nDo you need help with anything? Please answer “true” or “false”:");
        string needHelp = Console.ReadLine();
        bool helpBool = Convert.ToBoolean(needHelp);
        Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics:");
        string posEx = Console.ReadLine();
        Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific:");
        string feedBack = Console.ReadLine();
        Console.WriteLine("\nHow many hours did you study today?:");
        string dayHours = Console.ReadLine();
        byte hoursDay = Convert.ToByte(dayHours);
        Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly.\n\n\t\t\t\tHAVE A GREAT DAY!");
        Console.ReadLine();
    }
}

