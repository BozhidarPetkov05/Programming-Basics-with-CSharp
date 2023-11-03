using System;

namespace P05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int opened = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 0; i <= opened; i++)
            {
                string tab = Console.ReadLine();
                if (tab == "Facebook")
                {
                    salary -= 150;
                }
                if (tab == "Instagram")
                {
                    salary -= 100;
                }
                if (tab == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
