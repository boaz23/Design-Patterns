using System;

namespace Factory.AbstractFactory.Example1 {
    public class PizzaPlace {
        public PizzaPlace(IPizzaMaker pizzaMaker) {
            this.PizzaMaker = pizzaMaker;
        }

        private IPizzaMaker PizzaMaker { get; }

        public void OrderPizza(string[] toppings, string address) {
            Pizza pizza = this.PizzaMaker.MakePizza(toppings);
            this.DeliverPizza(pizza, address);
        }

        protected virtual void DeliverPizza(Pizza pizza, string address) {
            Console.WriteLine("An " + pizza.Type + " was delivered to " + address);
        }
    }
}