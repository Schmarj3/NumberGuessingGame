using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random r = new Random();
            
            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number inbetween 0 and 100:  ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too High!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too Low!");
                }
                else if ( i == winNum)
                {
                    Console.WriteLine($"You Got It! The winning number is {winNum}");
                    win = true;
                }
                else
                {
                    Console.WriteLine("Uh oh, looks like you didn't enter an integer between 0 and 100 or another error occurred.");
                }

                Console.WriteLine(); // adds a blank line

            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to exit the game.");
            Console.ReadKey(true);
        
        }
    }
}
