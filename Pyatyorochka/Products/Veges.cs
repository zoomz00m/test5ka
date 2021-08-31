using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatyorochka.Products
{
    class Veges : Product
    {
        public DateTime ShelfLife { get; set; }

        public Veges(DateTime shelfLife, double price, string name, string manufacturer)
        {
            ShelfLife = shelfLife;
            Price = price;
            Name = name;
            Manufacturer = manufacturer;
        }

        public override double getPriceWithCoupon(double discount)
        {
            if (ShelfLife == DateTime.Today)
                return Price * 0.5;

            return base.getPriceWithCoupon(discount);
        }
    }
}
