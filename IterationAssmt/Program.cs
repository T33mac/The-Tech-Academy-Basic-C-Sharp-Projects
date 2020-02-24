using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        //string[] things = { "Nacho", "Camper", "Mouse", "80", "Grippo" };
        //Console.WriteLine("Please Enter a good introduction to the string of the day:");
        //string message = Console.ReadLine();
        //bool skoob = message.Length < 10;
        //if (skoob == false)
        //{
        //    for (int thing = 0; thing < things.Length; thing++)               // Iterating the array using < Operator
        //    {
        //        Console.WriteLine(message + ": \"" + things[thing] + "\"");  // This will write a message for each element
        //    }
        //    Console.ReadLine();
        //}
        //while (skoob == true)                                  // Creates an infinite loop if the message is too short                  
        //{
        //    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter) break;
        //    Console.WriteLine("\tPress enter!\n");
        //}
        //for (int thing = 0; thing < things.Length; thing++)               // Iterating the array again
        //{
        //    Console.WriteLine("Current array items: \"" + things[thing] + "\"");   // This will write a message for each element
        //}
        //Console.WriteLine("\nI don't like grippos or nachos, let's print a better list\n");

        //for (int thing = 1; thing <= things.Length - 2; thing++) // Iterating the array again using <= operator
        //{
        //    Console.WriteLine("Better array: \"" + things[thing] + "\"");
        //}
        //Console.ReadLine();


        //List<string> dogNames = new List<string> { "charlie", "rover", "otto", "lola", "joshy", "andy", "milo", "clipper", "ava" };
        //Console.WriteLine("\n\nSearch for a dog in the database. Enter the dog's name: ");
        //string findIt = Console.ReadLine().ToLower();

        //for (int name = 0; name < dogNames.Count; name++)
        //{
        //    if (dogNames.Contains(findIt))            // Stops loop when match is found
        //    {
        //        Console.WriteLine(findIt + " is in our database");
        //        Console.ReadLine();
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sorry, " + findIt + " is not in our database");
        //        Console.ReadLine();
        //        break;

        //    }
        //}


        List<string> appendages = new List<string> { "left hand", "right hand", "left foot", "left foot", "right foot" }; //*List with two of the same string*
        Console.WriteLine("\n\nEnter a body part with fingers or toes : ");
        string parts = Console.ReadLine().ToLower();
        List<string> trues = new List<string> { };
        foreach (string i in appendages)
        {
            bool isIt = i.Contains(parts);            
            if (isIt == true)
            {
                trues.Add(i);
                int count = trues.Count;               
                if (count > 0)
                {
                    Console.WriteLine(i + " is in our database!");
                    Console.WriteLine(count);
                }
                if (count == 0)               
                {
                    Console.WriteLine("Sorry " + parts + " is not in our database.");
                }
            }
        }
        Console.ReadLine();
    }
}

