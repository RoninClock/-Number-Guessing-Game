using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Practice
{
    static class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "🎮 Number Guessing Game";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 1000;
            int guess;
            int num;
            int attempts;
            string input;

            while (playAgain)
            {
                guess = 0;
                attempts = 0;
                input = "";
                num = random.Next(min, max + 1);
                while (guess != num)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"🎯 Guess a number between {min} and {max}: ");
                    guess = Convert.ToInt32(Console.ReadLine());


                    if (guess < num)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(guess + " is too low🔻.");
                    }
                    else if (guess > num)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(guess + " is too high🔺.");
                    }
                    attempts++; 
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("🎯 Guess: " + guess);
                Console.WriteLine("⏳ Attempts: " + attempts);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("🎊Congratulations: YOU WIN🎊");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Do you want to play again ♻️ (y/n)");
                input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else
                {
                    playAgain = false;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("🙏 Thank you for playing| 🎮 |  ");
                    Console.Clear();
                }
            }
        }                                            
    }
}

 