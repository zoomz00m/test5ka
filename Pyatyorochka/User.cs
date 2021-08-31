using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatyorochka
{
    class User
    {
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public double Discount { get; private set; }
        public int Age { get; private set; }

        public User(string name, double balance, double discount, int age)
        {
            Name = name;
            Balance = balance;
            Discount = discount;
            Age = age;
        }

        public void ReduceBalance(double amount)
        {
            Balance -= amount;
        }
    }
}
