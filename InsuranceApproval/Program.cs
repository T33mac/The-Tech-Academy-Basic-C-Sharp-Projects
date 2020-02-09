using System;


    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();
        int Age = Convert.ToInt32(age);
        Console.WriteLine("Have you ever had a DUI?(Answer \"true\" or \"false\")");
        string dui = Console.ReadLine();
        bool DUI = Convert.ToBoolean(dui);
        Console.WriteLine("How many speeding tickets do you have?");
        string tickets = Console.ReadLine();
        int Tickets = Convert.ToInt32(tickets);

        bool isQualified = (Age > 15 && DUI == false && Tickets <= 3);
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);
        Console.ReadLine();
    }
}

