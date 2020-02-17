using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {
        string[] strArray = { "Bike", "Dog", "Cheese", "House", "Camel" };
        int[] intArray = { 12, 2, 18, 300, 80 };
        int result1 = strArray.GetLength(0);
        int result2 = intArray.GetLength(0);
        //Console.WriteLine("Total Elements: {0}", result2);
        Console.WriteLine("Input an index number");
        int ans1 = Convert.ToInt32(Console.ReadLine());
        bool isOK = ans1 < result1;
        //bool isOk = ans2 < result2;
        if (isOK)
        {
            Console.WriteLine("The string Element is " + strArray[(ans1)]);
            Console.WriteLine("\nInput another index number:");
            int ans2 = Convert.ToInt32(Console.ReadLine());
            bool isOk = ans2 < result2;
            if (isOk)
            {
                Console.WriteLine("The number Element is " + intArray[(ans2)]);
                Console.WriteLine("\nChoose an element number from a list item below:");
            }
            else
            {
                Console.WriteLine("Try entering a number under " + result2);
                int ans4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number Element is " + intArray[(ans4)]);
                Console.WriteLine("\nChoose an element number from a list item below:");
            }
        }
        else
        {
            Console.WriteLine("Try entering a number under " + result1);
            int ans3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The string Element is " + strArray[(ans3)]);
            Console.WriteLine("\nInput another index number:");
            int ans2 = Convert.ToInt32(Console.ReadLine());
            bool isOk = ans2 < result2;
            if (isOk)
            {
                Console.WriteLine("The number Element is " + intArray[(ans2)]);
                Console.WriteLine("\nChoose an element number from a list item below:");
            }
            else
            {
                Console.WriteLine("Try entering a number under " + result2);
                int ans4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number Element is " + intArray[(ans4)]);
                Console.WriteLine("\nChoose an element number from a list item below:");
            }
        }
        //make a list here lms p.136
        List<string> strList = new List<string>();
        strList.Add("4");
        strList.Add("Donkey");
        strList.Add("Left Shoe");
        strList.Add("Hammer");
        strList.Add("Bike");
        strList.Add("Dirt");
        foreach (string i in strList)
        {
            Console.WriteLine("\t" + i);
        }
        int chosen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You chose the " + strList[(chosen)]);
        Console.ReadLine();
    } 
}

