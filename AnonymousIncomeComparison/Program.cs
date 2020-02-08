using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine("\nPerson 1");
        Console.WriteLine("Hourly Rate?");
        string p1rate = Console.ReadLine();
        int hourly1 = Convert.ToInt32(p1rate);

        Console.WriteLine("Hours worked per week?");
        string hoursWkd1 = Console.ReadLine();
        int worked1 = Convert.ToInt32(hoursWkd1);

        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        string p2rate = Console.ReadLine();
        int hourly2 = Convert.ToInt32(p2rate);

        Console.WriteLine("Hours worked per week?");
        string hoursWkd2 = Console.ReadLine();
        int worked2 = Convert.ToInt32(hoursWkd2);

        int salary1 = (worked1 * 52) * hourly1;
        int salary2 = (worked2 * 52) * hourly2;
        
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(salary1);
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(salary2);

        Console.WriteLine("Does Person 1 make more money than person 2?");
        bool makeMore = salary1 > salary2;
        Console.WriteLine("\"" + makeMore + "\"");
        Console.ReadLine();
    }
}

