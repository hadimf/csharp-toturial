using System;

namespace Television
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = 0;
            bool watching = false;

            do
            {
                Console.Clear();
                System.Console.WriteLine($"channel: {++channel}");
                System.Console.WriteLine("do u want to watching? (y/n)");
                var answer = Console.ReadLine().ToLower();
                watching = answer == "n" ? true : false;

            } while (watching);

            System.Console.WriteLine($"Thanks For Watching channel {channel} ...");
        }
    }
}
