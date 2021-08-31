using System;
using System.Collections.Generic;
using Pyatyorochka.Products;

namespace Pyatyorochka
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Никита",
                10000,
                0.15,
                18);

            Alcohol Beer = new Alcohol(
                4.5,
                50,
                "Жигули Барное",
                "Россия");

            Alcohol Vodka = new Alcohol(
                40,
                2500,
                "Grey Goose",
                "Франция");

            Household FloorCleaner = new Household(
                300,
                "Mr. Proper",
                "Россия");

            Household ToiletPaper = new Household(
                200,
                "Zewa",
                "Россия");

            Veges Cucumber = new Veges(
                DateTime.Parse("10.08.2021"),
                100,
                "Огурцы Луховицкие",
                "Россия"
                );

            Veges Cabbage = new Veges(
                DateTime.Parse("25.08.2021"),
                49,
                "Кабачки Фрэш",
                "Россия"
                );

            List<Product> products = new List<Product>()
            {
                Beer, Vodka, FloorCleaner, ToiletPaper, Cucumber, Cabbage
            };

            Cart cart = new Cart();
            SecuritySystem security = new SecuritySystem();

            Console.WriteLine($"Привет, {user.Name}, у тебя на счету: {user.Balance}\n");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Товар {i}: {products[i].Name} Цена: {products[i].Price}");
            }
            Console.WriteLine("\nВведите номер товара, чтобы добавить его в корзину, 9 - очистить корзину, 10 - оплатить товар из корзины");
            
            while (true)
            {
                string str = Console.ReadLine();
                int code = -1;
                try
                {
                    code = Convert.ToInt32(str);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Не удалось считать цифру, проверьте правильность написания");
                }

                if (code >= 0 && code < products.Count)
                {
                    Product chosenProduct = products[code];
                    if (chosenProduct is Alcohol)
                        if (security.OldEnough(user))
                            cart.AddToCart(chosenProduct, user.Discount);
                        else
                            Console.WriteLine("Слишком молод для такого");
                    else
                        cart.AddToCart(chosenProduct, user.Discount);
                }
                else if (code == 9)
                {
                    cart.ClearCart();
                }
                else if (code == 10)
                {
                    cart.Buy(user);
                }
            }
        }
    }
}