using System;



class Program
{
    static void Main()
    {
        Console.WriteLine("Rate how you're feeling from 1-100");
        int number = Convert.ToInt32(Console.ReadLine());
        bool happy = number >= 80;
        bool okay = number > 64 && number < 80;
        bool beenBetter = number > 29 && number < 65;
        bool miserable = number < 30;
        
        while (happy)
        {
            Console.WriteLine("Your a Happy boy/girl!");
            Console.Read();
            break;
        }

        while (beenBetter)
        {
            do
            {
                switch (number)
                {
                    case 50:
                        Console.WriteLine("Wow! right in the middle!");
                        break;

                    default:
                        Console.WriteLine("Buck up, little Buckaroo!");
                        break;
                }
            }
            while (happy);
            Console.Read();
        }

        while (okay)
        {
            Console.WriteLine("If you were graded on your feelings, you'd get a C.");
            Console.Read();
            break;
        }

        while (miserable)
        {
            Console.WriteLine("You have failed. Go play in the road :( ");
            Console.Read();
        }
    }
}
