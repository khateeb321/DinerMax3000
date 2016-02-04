using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000
{
    public class MenuItem
    {
        public string Title;
        public string Discription;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }

                else
                {
                    throw new ApplicationException("You connot have negative or free item.");
                }
            }
        }
        private double _price;
    }
}
