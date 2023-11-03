using System;

namespace P01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double poolChairPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            int umbrellaCount = (int)Math.Ceiling(peopleCount / 2.0);
            int poolChairCount = (int)Math.Ceiling(peopleCount * 0.75);

            double totalPrice = peopleCount * ticketPrice + poolChairPrice * poolChairCount + umbrellaPrice * umbrellaCount;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
