using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000
{
    public class Menu
    {
        public Menu()
        {
            items = new List<MenuItem>();

        }

        public void AddMenuItem(string Title, string Discription, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Discription = Discription;
            item.Price = Price;
            items.Add(item);
        }

        public string Name;
        public List<MenuItem> items;
    }
}
