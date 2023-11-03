using System;

namespace P07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegetarianMenu = 8.15;
            double delivery = 2.50;
            
            int chickenMenuNum = int.Parse(Console.ReadLine());
            int fishMenuNum = int.Parse(Console.ReadLine());
            int vegetarianMenuNum = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenuNum * chickenMenu;
            double fishMenuPrice = fishMenuNum * fishMenu;
            double vegetarianMenuPrice = vegetarianMenuNum * vegetarianMenu;

            double sum = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice;
            double dessert = sum * 0.2;
            double totalPrice = sum + dessert + delivery;

            Console.WriteLine(totalPrice);



        }
    }
}
