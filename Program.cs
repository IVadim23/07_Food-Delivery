using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add nubers of chicken menus:");
            int chickenMenus = int.Parse(Console.ReadLine());
            double chickenMenusPrice = chickenMenus * 10.35;
            Console.WriteLine("Add nubers of fish menus:");
            int fishMenus = int.Parse(Console.ReadLine());
            double fishMenuPrice = fishMenus * 12.40;
            Console.WriteLine("Add nubers of vegetarian menus:");
            int vegetarianMenus = int.Parse(Console.ReadLine());
            double vegetarianMenusPrice = vegetarianMenus * 8.15;
            double sum = chickenMenusPrice + fishMenuPrice + vegetarianMenusPrice;
            double PriceOfDessert = sum * 0.20;
            double finalSum = sum + PriceOfDessert + 2.50;

            Console.WriteLine("Final sum is:\n {0:f2}",finalSum);
        }
    }
}
