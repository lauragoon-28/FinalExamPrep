using System;
using System.Collections.Generic;

namespace Homework6Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> order = new List<string>();
            string answer = "";
            double price = 0;
            double total = 0;

            do
            {
                string menu = GetMenu();
                Console.WriteLine(menu);
                Console.WriteLine();

                Console.WriteLine("What would you like to order?");
                answer = Console.ReadLine().ToLower();
                order.Add(answer);

                price = CalculatePrice(answer);
                total = total + price;
                ShowReceipt(price);

                Console.WriteLine("Would you like to order anything else? (yes or no)");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");
            bool isFirst = true;
            for (int i = 0; i < order.Count; i++)
            {
                if (isFirst)
                {
                    Console.Write(order[i]);
                    isFirst = false;
                }
                else
                {
                    Console.Write("," + order[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Order Total: {total.ToString("C")}");

            Console.WriteLine("Thank you for playing Coffee Shop!");

           
        }

        static string GetMenu()
        {
            string menu = "Coffee Shop Menu" +
                "\nFresh Coffee ... $2.25" +
                "\nCafe au lait ... $3.72" +
                "\nLatte ... $4.03" +
                "\nHot Chocolate ... $3.51" +
                "\nPumpkin Spice ... $7.30";
            return menu;
        }
        static double CalculatePrice(string item)
        {
            double price = 0;
            if (item.ToLower() == "fresh coffee")
            {
                price = 2.25;
            }
            else if (item.ToLower() == "cafe au lait")
            {
                price = 3.72;
            }
            else if (item.ToLower() == "latte")
            {
                price = 4.03;
            }
            else if (item.ToLower() == "hot chocolate")
            {
                price = 3.51;
            }
            else if (item.ToLower() == "pumpkin spice")
            {
                price = 7.30;
            }
            else
            {
                price = 0;
            }
            return price;
        }
        static void ShowReceipt(double subtotal)
        {
            double taxRate = 0.085;
            double tax = subtotal * taxRate;
            double total = subtotal + tax;
            Console.WriteLine($"Subtotal: {subtotal.ToString("C")} Tax:{tax.ToString("C")} Total: {total.ToString("C")}");
        }
    }
}
