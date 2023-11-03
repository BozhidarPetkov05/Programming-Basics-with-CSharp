using System;

namespace P01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double firstPipe = double.Parse(Console.ReadLine());
            double secondPipe = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double firstPipeHour = firstPipe * hours;
            double secondPipeHour = secondPipe * hours;
            double total = firstPipeHour + secondPipeHour;

            if (total <= volume)
            {
                double percentPool = (total * 100) / volume;
                double firstPipePercent = (firstPipeHour * 100) / total;
                double secondPipePercent = (secondPipeHour * 100) / total;
                Console.WriteLine($"The pool is {percentPool:f2}% full. Pipe 1: {firstPipePercent:f2}%. Pipe 2: {secondPipePercent:f2}%.");
            }
            else
            {
                double overflow = total - volume;
                Console.WriteLine($"For {hours} hours the pool overflows with {overflow} liters.");
            }
        }
    }
}
