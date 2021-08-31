using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatyorochka.Products
{
    class Household : Product
    {
        public Household(double price, string name, string manufacturer)
        {
            Price = price;
            Name = name;
            Manufacturer = manufacturer;
        }
    }
}
