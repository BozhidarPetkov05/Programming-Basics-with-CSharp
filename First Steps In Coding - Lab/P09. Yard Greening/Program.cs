using System;

namespace P09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = 7.61;
            double discount = area * price * 0.18;

            double totalPrice = area * price - discount;
            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
