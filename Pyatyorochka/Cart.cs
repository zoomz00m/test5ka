using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatyorochka
{
    class Cart
    {
        public double PurchaseAmount { get; private set; }
        public List<string> ProductNamesInCart { get; set; }
        public Cart()
        {
            ProductNamesInCart = new List<string>();
            PurchaseAmount = 0;
        }

        public void AddToCart(Product product, double discount)
        {
            PurchaseAmount += product.getPriceWithCoupon(discount);
            
            ProductNamesInCart.Add(product.Name);
            Console.WriteLine($"Товар {product.Name} добавлен в корзину. Сумма к оплате с учетом скидки: {PurchaseAmount}");
        }

        public void ClearCart()
        {
            PurchaseAmount = 0;
            ProductNamesInCart.Clear();
            Console.WriteLine("Корзина очищена.");
        }

        public void Buy(User user)
        {
            user.ReduceBalance(PurchaseAmount);
            
            Console.WriteLine($"Был приобритён следующий товар на сумму {PurchaseAmount}:");
            foreach (string name in ProductNamesInCart)
                Console.WriteLine($"{name}");

            ClearCart();

            Console.WriteLine($"Твой баланс: {user.Balance}");
            Console.WriteLine("чтобы выйти нажми крестик или набирай новую корзину.\n");
        }
    }
}
