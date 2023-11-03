using System;

namespace P08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int reps = 0;
            double markSum = 0;
            while (grade <= 12)
            {
                double currentMark = double.Parse(Console.ReadLine());
                if (currentMark < 4)
                {
                    reps++;
                    if (reps > 1)
                    {
                        break;
                    }
                    continue;
                    
                }
                markSum += currentMark;
                grade++;
                
            }
            if (reps > 1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                double averageMark = markSum / (grade - 1);
                Console.WriteLine($"{name} graduated. Average grade: {averageMark:f2}");
            }
        }
    }
}
