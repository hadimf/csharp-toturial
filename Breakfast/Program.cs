using System;
using Breakfast.Classes;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Breakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cup = MakeCoffe();

            var eggsTask = EggFryinAsync(3);
            var baconsTask = BaconFryingAsync(2);
            var toastsTask = ToastWithJamAndButter();

            var listTasks = new List<Task>() { eggsTask, baconsTask, toastsTask };


            while (listTasks.Count > 0)
            {
                var finishTask = await Task.WhenAny(listTasks);
                if (finishTask == eggsTask)
                {
                    Console.WriteLine("Eggs done!");
                }
                else if (finishTask == baconsTask)
                {
                    Console.WriteLine("Bacons done!!");
                }
                else if (finishTask == toastsTask)
                {
                    Console.WriteLine("Toasts with Jam and Butter is Ready.!!!");
                }
                listTasks.Remove(finishTask);
            }
            var glass = MakeJuice();

            Console.WriteLine("Beakfast is ready.!");


        }
        private static Coffee MakeCoffe()
        {
            Console.WriteLine("Puring the Coffee.");
            Console.WriteLine("Coffee is ready.");
            Thread.Sleep(3750);

            return new Coffee();
        }
        private static async Task<Egg> EggFryinAsync(int eggs)
        {
            Console.WriteLine("Warwing pan for Eggs.");
            for (int egg = 1; egg <= eggs; egg++)
            {
                Console.WriteLine("Broke the Egg.");
            }
            await Task.Delay(2000);
            Console.WriteLine("Frying the Eggs");
            await Task.Delay(1750);

            return new Egg();
        }
        private static async Task<Bacon> BaconFryingAsync(int bacons)
        {
            Console.WriteLine("Warwing pan for Bacons.");
            for (int bacon = 1; bacon <= bacons; bacon++)
            {
                Console.WriteLine("Frying the Bacon");
                Console.WriteLine("Flipping the Bacon.");
                await Task.Delay(1500);
            }
            await Task.Delay(750);

            return new Bacon();
        }
        private static async Task<Toast> ToastWithJamAndButter()
        {
            var toasts = await ToastBread();
            Task.WaitAll(PutButter(), PutJam());

            return toasts;
        }

        private static async Task<Toast> ToastBread()
        {
            Console.WriteLine("Put First slice of bread.");
            Console.WriteLine("Put Second slice of bread.");
            Console.WriteLine("Toasting....");
            await Task.Delay(2000);
            Console.WriteLine("Breads are Toasted.!");
            await Task.Delay(1750);

            return new Toast();
        }
        private static async Task PutButter()
        {
            Console.WriteLine("Put Butter  on Bread.");
            await Task.Delay(3750);
        }
        private static async Task PutJam()
        {
            Console.WriteLine("Put Jam on Bread.");
            await Task.Delay(3750);
        }
        private static Juice MakeJuice()
        {
            Console.WriteLine("Poure the Juice.");
            Thread.Sleep(3750);

            return new Juice();
        }
    }
}
