using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsP_235Assmt
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            try
            {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());
                bool okAge = age > 0;
                if (!okAge)
                {
                    throw new AgeException();
                }
                DateTime yearBorn = now.AddYears(-age);
                Console.WriteLine("Your were born in " + yearBorn.Year);
                Console.ReadLine();
                return;
            }
            catch (AgeException)
            {
                Console.WriteLine("Please enter a positive number greater than zero:");
                int age = Convert.ToInt32(Console.ReadLine());
                DateTime yearBorn = now.AddYears(-age);
                Console.WriteLine("Your were born in " + yearBorn.Year);
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something you've entered is not working. Try using numbers only:");
                int age = Convert.ToInt32(Console.ReadLine());
                DateTime yearBorn = now.AddYears(-age);
                Console.WriteLine("Your were born in " + yearBorn.Year);
                Console.ReadLine();
                return;
            }
        }
    }
}
