using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatyorochka
{
    class Product
    {
        public double Price { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }

        public virtual double getPriceWithCoupon(double discount)
        {
            if (discount == 0)
                return Price;
            
            return Price - (Price * discount);
        }
    }
}
