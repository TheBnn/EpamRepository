using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Pizza_Time
{
    class Customer
    {
        public string Name { get; set; } 
        
        public Customer(string name)
        {
            Name = name;
        }

        public void PizzaOrdering(Pizzeria pizzeria, PizzaType customerChoice)
        {
            Console.WriteLine($"{Name}: hello, i want to buy {customerChoice}");
            Console.WriteLine();
            Order order = new Order(Name, customerChoice);
            order.OnReady += OrderTaking;
            pizzeria.Receive(order);
        }

        public void OrderTaking(Order order)
        {
            Console.WriteLine($"{Name}: thanks, it was very fast");
            order.OnReady -= OrderTaking;
        }
    }
}
