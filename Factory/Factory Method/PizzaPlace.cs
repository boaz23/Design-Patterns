using System;

namespace Factory.FactoryMethod {
    public abstract class PizzaPlace {
        protected abstract Pizza MakePizza(string[] toppings);

        public void OrderPizza(string[] toppings, string address) {
            Pizza pizza = this.MakePizza(toppings);
            this.DeliverPizza(pizza, address);
        }

        protected virtual void DeliverPizza(Pizza pizza, string address) {
            Console.WriteLine("An " + pizza.Type + " was delivered to " + address);
        }
    }
}