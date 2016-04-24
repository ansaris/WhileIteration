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
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("Goodbye.");
                Console.ReadLine();
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand.");
                Console.ReadLine();
                return true;
            }
        }
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= result)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();

            int randomNumber = myRandom.Next(1, 10);

            int guesses = 0;

            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess my number between 1 and 10: ");
                string guess = Console.ReadLine();
                if (guess == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong");
                guesses++;
            } while (incorrect);
            Console.WriteLine("Correct! It only took you {0} guesses", guesses);
            /*
            while (guesses < 3)
            {
                Console.WriteLine();
                Console.Write("Guess my number between 1 and 11: ");
                int guess = int.Parse(Console.ReadLine());
                if (randomNumber == guess)
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }
                else if (randomNumber != guess && guesses < 3)
                {
                    Console.WriteLine("You have {0} tries left.", 2 - guesses);
                }
                else
                {
                    Console.WriteLine("Sorry, you lose.");
                }
                guesses++;
            }
            */




            Console.ReadLine();
        }
    }
}
