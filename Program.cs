// ITN114 Wireless Internet and Pervasive Computing
// Number Guessing Game Console Project
// Azalea Mae C. Manimog

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool replay = true;
            int minimum = 1;
            int maximum = 1000;
            int number;
            int firstGuess;
            int secondGuess;
            int currentScore = 0;
            string res;

            while (replay)
            {
                firstGuess = 0;
                secondGuess = 0;
                currentScore = 0;
                res = "";
                number = random.Next(minimum, maximum + 1);

                Console.WriteLine("<<<<< WELCOME TO NUMBER GUESSING GAME >>>>>");

                while (firstGuess != number)
                {
                    Console.WriteLine("\nGuess a number between " + minimum + " - " + maximum + ":");
                    firstGuess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\tGuess: " + firstGuess);

                    if (firstGuess == number)
                    {
                        currentScore++;
                    }

                    else if (firstGuess > number)
                    {
                        Console.WriteLine("Your guess is too HIGH! TRY AGAIN!");
                    }
                    else if (firstGuess < number)
                    {
                        Console.WriteLine("Your guess is too LOW! TRY AGAIN!");
                    }
                    secondGuess++;

                }

                Console.WriteLine("\n--- That's CORRECT! YOU WIN! ---");
                Console.WriteLine("\n***** TALLY OF RECORDS *****");
                Console.WriteLine("Correct Guessed Number: " + firstGuess);
                Console.WriteLine("Number of Guesses: " + secondGuess);
                Console.WriteLine("Number of Wrong: " + (secondGuess - 1));
                Console.WriteLine("Score: " + currentScore);

                Console.WriteLine("\nWOULD YOU LIKE TO PLAY AGAIN? \n> Press [Y] to continue. \n> Press [N] to exit.");
                res = Console.ReadLine();
                res = res.ToUpper();

                if (res == "Y")
                {
                    replay = true;
                }
                else
                {
                    replay = false;
                }
            }
            Console.WriteLine("\n>>>>> THANK YOU FOR PLAYING THE NUMBER GUESSING GAME! <<<<<");

            Console.ReadKey();
        }
    }
}
