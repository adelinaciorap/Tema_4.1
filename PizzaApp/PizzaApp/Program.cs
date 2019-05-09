using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalizing the objects;
            PizzaBase blat1 = new PizzaBase("Italian");
            Pizza pizza1 = new Pizza("Diavola", blat1);

            PizzaBase blat2 = new PizzaBase("Crusty");
            Pizza pizza2 = new Pizza("Carnivore", blat2);

            PizzaBase blat3 = new PizzaBase("Regular");
            Pizza pizza3 = new Pizza("Veggie", blat3);

            // Populating with toppings
            pizza1.AddTopping("Mozzarella", 4.5);
            pizza1.AddTopping("Chicken", 3.1);
            pizza1.AddTopping("Tomato sauce", 1.1);
            pizza1.AddTopping("Pepperoni", 2.3);
            //------------------
            pizza2.AddTopping("Mozzarella", 4.5);
            pizza2.AddTopping("Pepperoni", 3.3);
            pizza2.AddTopping("Salami", 2.3);
            pizza2.AddTopping("Bacon", 3.0);
            pizza2.AddTopping("Ham", 3.3);
            //------------------
            pizza3.AddTopping("Tomato sauce", 1.1);
            pizza3.AddTopping("Mozarella", 4.5);
            pizza3.AddTopping("Mushrooms", 1.8);
            pizza3.AddTopping("Olives", 0.5);
            //------------------

            List<Pizza> Order = new List<Pizza>();
            Order.Add(pizza1);
            Order.Add(pizza2);
            Order.Add(pizza3);

            foreach (Pizza pizza in Order)
                pizza.Print();

            Console.ReadKey();
        }
    }
}
