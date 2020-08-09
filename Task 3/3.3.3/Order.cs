using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3._3_Pizza_Time
{
    class Order
    {
        public event Action<Order> OnReady = delegate { };
        public string CustomerName { get; private set; }
        public PizzaType Type { get; private set; }

        public Order(string name, PizzaType pizza)
        {
            CustomerName = name;
            Type = pizza;
        }

        public void Ready()
        {
            OnReady(this);
        }
    }
}
