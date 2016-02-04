using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon", "Fresh solman with butter",25.50);
            summerMenu.AddMenuItem("Taco", "Everyone eats Taco on Friday", 10);
            summerMenu.HospitalDirections = "Right around the corner of 5th street.";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code";
            outsideDrinks.AddMenuItem("Dew", "Energy Drink", 10);
            outsideDrinks.AddMenuItem("Coke", "Good in taste", 15);

            Order hungryGuestOrder = new Order();

            for (int x = 0; x < summerMenu.items.Count; x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
                Console.WriteLine("Total bill is: " + hungryGuestOrder.Total);
                try
                {
                    outsideDrinks.AddMenuItem("Sprite", "A very good drink", 0);
                }

                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
