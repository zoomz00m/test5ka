using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatyorochka.Products
{
    class Alcohol : Product
    {
        public double ABV { get; set; }

        public Alcohol(double aBV, double price, string name, string manufacturer)
        {
            ABV = aBV;
            Price = price;
            Name = name;
            Manufacturer = manufacturer;
        }

        public override double getPriceWithCoupon(double discount)
        {
            return Price;
        }
    }
}
