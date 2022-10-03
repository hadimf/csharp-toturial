using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;


            do
            {
                var number = random.Next(1, 101);
                bool win = true;
                var round = 0;
                while (win)
                {

                    System.Console.WriteLine("Guess a Number 1-100 :");
                    var guess = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine($"Guess: {guess}");

                    if (guess > number)
                    {
                        System.Console.WriteLine("Your Number is too big!");


                    }
                    else if (guess < number)
                    {
                        System.Console.WriteLine("Your Number is too small!");

                    }
                    win = guess == number ? false : true;
                    round++;
                }
                Console.Clear();
                System.Console.WriteLine($"The number is {number}");
                System.Console.WriteLine($"Rounds: {round}");
                System.Console.WriteLine("Do u want to play again? (y/n)");
                var answer = Console.ReadLine().ToLower();
                playAgain = answer == "y" ? true : false;
                Console.Clear();
            } while (playAgain);



            System.Console.WriteLine("Thanks for playing ^_^");
        }
    }
}
