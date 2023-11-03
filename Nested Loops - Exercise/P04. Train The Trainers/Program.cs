using System;

namespace P04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string presentationName;
            int presentationCount = 0;
            double grade = 0;
            double personalGrade = 0;

            while (input != "Finish")
            {
                presentationName = input;
                grade = 0;
                for (int jury = 1; jury <= n; jury++)
                {
                    grade += double.Parse(Console.ReadLine());
                }
                grade /= n;
                Console.WriteLine($"{presentationName} - {grade:f2}.");
                personalGrade += grade;
                presentationCount++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {personalGrade/presentationCount:f2}.");
        }
    }
}
