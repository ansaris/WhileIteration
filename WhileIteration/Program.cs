using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.WriteLine("You selected Option 1");
                Console.ReadKey();
            }
            else if (result == "2")
            {
                Console.WriteLine("You selected Option 2");
                Console.ReadKey();
            }
            else if (result == "3")
            {
                Console.WriteLine("Goodbye.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("I didn't understand.");
                Console.ReadKey();
            }
        }
    }
}
