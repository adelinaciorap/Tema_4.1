using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Pizza
    {
        public string Name { get; set; }
        public double Total = 0;
        PizzaBase pizzabase;
        List<PizzaTopping> Toppings = new List<PizzaTopping>();

        public Pizza(string PizzaName, PizzaBase crust)
        {
            this.Name = PizzaName;
            this.pizzabase = crust;
            Total += crust.ExtraCost;
        }

        public void AddTopping(string ToppingName, double Cost)
        {
            PizzaTopping topping = new PizzaTopping();

            topping.Topping = ToppingName;
            topping.Cost = Cost;
              
            Toppings.Add(topping);

        }
        public void Print()
        {
            Console.WriteLine("=====Pizza " + Name +"=====");
            Console.WriteLine($"Crust {pizzabase.BaseName} : {pizzabase.ExtraCost}");
            Console.WriteLine("Toppings: ");
            
            foreach (PizzaTopping topping in Toppings)
            {
                Total += topping.Cost;
                Console.WriteLine($"--{topping.Topping} (${topping.Cost})");
                
            }
             
            Console.WriteLine($"Total cost: $({Total})");
            Console.WriteLine("");
        }

        internal void PrintTopping()
        {
            throw new NotImplementedException();
        }
    }

}
