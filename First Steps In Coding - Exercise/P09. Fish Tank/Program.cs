using System;

namespace P09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * widht * height;
            double volumeInLitres = volume * 0.001;
            double takenSpace = percent / 100;

            double neededLitres = volumeInLitres * (1 - takenSpace);
            Console.WriteLine(neededLitres);
        }
    }
}
