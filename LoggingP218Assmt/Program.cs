using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingP218Assmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string text1 = Console.ReadLine();
            File.WriteAllText(@"C:\Users\trmcg\Logs\log1.txt", text1);
            string text2 = File.ReadAllText(@"C:\Users\trmcg\Logs\log1.txt");
            Console.WriteLine("You've entered \"{0}\". It is now logged.", text2);
            Console.Read();
        }
    }
}
