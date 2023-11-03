using System;

namespace P07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int people;
            double musalaPeople = 0;
            double monblanPeople = 0;
            double kilimandjaroPeople = 0;
            double ktwoPeople = 0;
            double everestPeople = 0;
            double totalPeople = 0;
            for (int i = 1; i <= groups; i++)
            {
                people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    musalaPeople += people;
                }
                else if (people <= 12)
                {
                    monblanPeople += people;
                    
                }
                else if (people <= 25)
                {
                    kilimandjaroPeople += people;
                    
                }
                else if (people <= 40)
                {
                    ktwoPeople += people;
                    
                }
                else
                {
                    everestPeople += people;
                }
                
            }
            totalPeople += musalaPeople + monblanPeople + kilimandjaroPeople + ktwoPeople + everestPeople;
            Console.WriteLine($"{musalaPeople / totalPeople*100:f2}%");
            Console.WriteLine($"{monblanPeople / totalPeople * 100:f2}%");
            Console.WriteLine($"{kilimandjaroPeople / totalPeople * 100:f2}%");
            Console.WriteLine($"{ktwoPeople / totalPeople * 100:f2}%");
            Console.WriteLine($"{everestPeople / totalPeople * 100:f2}%");
        }
    }
}
