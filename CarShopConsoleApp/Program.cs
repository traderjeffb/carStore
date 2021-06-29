using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Nissan","Sentra", 7322);
            Car d = new Car("Ford", "Mustang", 9200);

            Console.WriteLine("car d is as follows:" + c.Make +" " + c.Model + " " + c.Price);
            Console.WriteLine("car D is as follows:" + d.Make + " " + d.Model + " " + d.Price);
            Store s = new Store();

            s.ShoppingList.Add(c);
            s.ShoppingList.Add(d);

            decimal total = s.Checkout();

            Console.WriteLine("Store value is:" + total);

            Console.ReadLine();
        }
    }
}
