using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string message = "Please enter an actual day of the week.";
            string[] days = Enum.GetNames(typeof(DaysOfTheWeek));   //assigning value of string and creating list
            Console.WriteLine("What day is it today? ");
            string ans = Console.ReadLine().ToLower();

            try
            {
                foreach (string i in days)
                {
                    bool itsGood = i == ans;
                    if (itsGood == true)
                    {                        
                        Console.WriteLine("\nThanks! {0} already?", i);
                    }
                }

                List<string> notEqual = new List<string>();
                foreach (string j in days)
                    if (j != ans)
                    {
                        notEqual.Add(j);
                    }
                if (notEqual.Count == 7)
                {
                    throw new System.ArgumentException("","og");
                }
            }

            catch (System.ArgumentException)
            {
                Console.WriteLine(message);
            }

            finally
            {
                Console.ReadLine();
                Main(args);
            }
        }
        public enum DaysOfTheWeek
        {
            sunday, monday, tuesday,
            wednesday, thursday, friday,
            saturday
        }
    }
}

