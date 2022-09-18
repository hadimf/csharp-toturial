using System;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            int playAgain;

            do
            {

                var answerHuman = Ask();
                ShowStatusPlayer(answerHuman);
                var answerComputer = PlayComputer();
                ShowStatusComputer(answerComputer);
                CheckPlay(answerHuman, answerComputer);
                playAgain = PlayAgain();
                Console.Clear();

            } while (playAgain == 1);

            System.Console.WriteLine("Thanks for play with me...");


        }

        static void ShowStatusPlayer(string answer)
        {
            System.Console.WriteLine($"Player: {answer}");
        }

        static string PlayComputer()
        {
            Random rnd = new Random();
            var temp = rnd.Next(0, 3);


            switch (temp)
            {
                case 0:
                    return "sang";
                case 1:
                    return "kaghaz";
                case 2:
                    return "gheichi";
                default:
                    return "Error";
            }

        }

        static void ShowStatusComputer(string answer)
        {
            System.Console.WriteLine($"Computer: {answer}");
        }

        static void CheckPlay(string human, string computer)
        {
            Draw(human, computer);

            switch (human)
            {
                case "sang":
                    Sang(human, computer);
                    break;
                case "kaghaz":
                    Kaghaz(human, computer);
                    break;
                case "gheichi":
                    Gheichi(human, computer);
                    break;
            }
        }

        static void Draw(string human, string computer)
        {
            if (human == computer)
            {
                System.Console.WriteLine("It's Draw");
            }
        }

        static void Sang(string human, string computer)
        {
            if (computer == "gheichi")
            {
                System.Console.WriteLine("You win");
            }
            else if (computer == "kaghaz")
            {

                System.Console.WriteLine("You lose");

            }
        }

        static void Kaghaz(string human, string computer)
        {

            if (computer == "sang")
            {
                System.Console.WriteLine("You win");
            }
            else if (computer == "gheichi")
            {

                System.Console.WriteLine("You lose");

            }
        }

        static void Gheichi(string human, string computer)
        {

            if (computer == "kaghaz")
            {
                System.Console.WriteLine("You win");
            }
            else if (computer == "sang")
            {

                System.Console.WriteLine("You lose");

            }
        }

        static string Ask()
        {
            string human = "";
            while (human != "sang" && human != "kaghaz" && human != "gheichi")
            {
                System.Console.WriteLine("sang, kaghaz, gheichi?");
                human = Console.ReadLine().ToLower();
            }
            return human;

        }

        static int PlayAgain()
        {
            System.Console.WriteLine("would like play again? (1/0)");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
