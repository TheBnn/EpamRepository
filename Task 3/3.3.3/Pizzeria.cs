using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Pizza_Time
{
    class Pizzeria
    {
        public void Receive(Order order)
        {
            Console.WriteLine("Thanks for your order! Wait a bit, please.");
            
            Cooking(order);
        }

        public void Cooking(Order order)
        {
            Console.WriteLine($"{order.CustomerName}, you can take your {order.Type}.");
            Console.WriteLine();
            order.Ready();
        }
    }
}
