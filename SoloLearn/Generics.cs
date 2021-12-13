using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    /* Problem Explanation
     * Coffee Time


A coffee shop manager is running a promotion and wants to offer a discount for coffee drinks.
The program you are given takes the discount value as input and defines a dictionary, where the names of the coffee drinks are set as keys, and their prices are set as values.
Write a program to discount all of the prices and output a new price list in the format shown below.

Sample Input
10

Sample Output
Americano: 45
Latte: 63
Flat White: 54
Espresso: 54
Cappuccino: 72
Mocha: 81
Use coffee.Keys.ToArray() inside the foreach loop.
Note the space after the ":" in the output.
     * 
     * 
     */

    public class Generics
    {
        static void Main8(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here
            double discount2 = discount;

            var list = coffee.Keys.ToArray();

            foreach (var item in list)
            {
                double price = coffee[item];

                price = price - (price * (discount2 / 100));
                price = Math.Round(price, MidpointRounding.AwayFromZero);
                Console.WriteLine(item + ": " + price);
            }
        }
        public static List<string> Discount(Dictionary<string, int> coffee, double discount2)
        {
            var list = coffee.Keys.ToArray();
            List<string> discounts = new List<string>();

            foreach (var item in list)
            {
                double price = coffee[item];

                price = price - (price * (discount2 / 100));
                price = Math.Round(price, MidpointRounding.AwayFromZero);
                Console.WriteLine(item + ": " + price);
                discounts.Add(item + ": " + price);
            }

            return discounts;

        }

    }
}
