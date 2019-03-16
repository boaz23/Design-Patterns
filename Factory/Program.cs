#define WINDOWS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.FactoryMethod;
using Factory.AbstractFactory.Example1;
using Factory.AbstractFactory.Example2;

namespace Factory {
    public static class Program {
        private static void Main(string[] args) {
            AbstractFactory_Example2();
        }

        private static void FactoryMethod() {
            var israeliPizzaPlace = new IsraeliPizzaPlace();
            israeliPizzaPlace.OrderPizza(new string[] { "Olives" }, "Tel Aviv");

            Console.WriteLine();

            var italianPizzaPlace = new ItalianPizzaPlace();
            italianPizzaPlace.OrderPizza(new string[] { "Onion" }, "Milano");

            Console.WriteLine();
        }

        private static void AbstractFactory_Example1() {
            var israeliPizzaPlace = new AbstractFactory.Example1.PizzaPlace(new IsraeliPizzaMaker());
            israeliPizzaPlace.OrderPizza(new string[] { "Extra Cheese", "Mushrooms" }, "Ramat Gan");

            Console.WriteLine();

            var italianPizzaPlace = new AbstractFactory.Example1.PizzaPlace(new ItalianPizzaMaker());
            italianPizzaPlace.OrderPizza(new string[] { "Corn" }, "Rome");

            Console.WriteLine();
        }

        private static void AbstractFactory_Example2() {
            IGuiControlsFactory guiControlsFactory;
#if WINDOWS
            guiControlsFactory = new WindowsControlsFactory();
#elif LINUX
            guiControlsFactory = new LinuxControlsFactory();
#elif MAC
            guiControlsFactory = new MacControlsFactory();
#else
            throw new NotImplementedException("Code should not reach here.");
#endif

            IButton button = guiControlsFactory.CreateButton();
            button.Text = "My Button";
            button.Draw();
        }
    }
}