using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Pizza_Time
{
    
    public enum PizzaType
        {
            Sicilian,
            Chicago,
            Greek,
            Pineapple,            
        }
    class Program
    {
        
        static void Main(string[] args)
        {
            Pizzeria PizzaHut = new Pizzeria();

            Customer customer1 = new Customer("Mark");
            Customer customer2 = new Customer("Albert");
            
            customer1.PizzaOrdering(PizzaHut, PizzaType.Sicilian);
            Console.WriteLine();
            customer2.PizzaOrdering(PizzaHut, PizzaType.Chicago);
        }
                
    }
}
