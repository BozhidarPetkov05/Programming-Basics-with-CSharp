using System;

namespace P02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badCurrentGrades = 0;
            double goodGrades = 0;
            double goodGradesNum = 0;
            int solvedProblems = 0;
            string lastTask = string.Empty;
            string task = Console.ReadLine();
            while (task != "Enough")
            {
                
                int grade = int.Parse(Console.ReadLine());
                task = Console.ReadLine();
                if (grade <= 4)
                {
                    
                    badCurrentGrades++;
                    if (badCurrentGrades >= badGrades)
                    {
                        Console.WriteLine($"You need a break, {badCurrentGrades} poor grades.");
                        break;
                    }

                }
                else
                {
                    goodGrades++;
                    goodGradesNum += grade;
                    solvedProblems++;
                    lastTask = task;
                }

            }
            double average = goodGradesNum / goodGrades;
            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {average}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
