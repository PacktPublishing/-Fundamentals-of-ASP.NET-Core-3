using System;

namespace ItalyPizza1
{
    internal class Pizza
    {
        private string pizzaName;
        private double totalPrice;

        public Pizza(string pizzaName, double totalPrice)
        {
            this.pizzaName = pizzaName;
            this.totalPrice = totalPrice;
        }

        internal double GetPrice(int controlNum)
        {
            if (controlNum == 1)
            {
                pizzaName = " Peperoni Pizza ";
                totalPrice = 11.99;
            }

            if (controlNum == 2)
            {
                pizzaName = " Sausage Pizza ";
                totalPrice = 12.99;
            }

            return totalPrice;
        }

        internal object GetName()
        {
            return pizzaName;
        }
    }
}