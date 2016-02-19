using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.HelloWorld.Models
{
    class ModelFactory
    {
        public static PizzaViewModel Create (Pizza pizza)
        {
            return new PizzaViewModel { Name = pizza.Name, Price = pizza.Price };
        }
        public static List<Pizza> GetPizzaList()
        {
            var list = new List<Pizza>()
            {
                new Pizza
                {
                ID =Guid.NewGuid().ToString(),
                Name="Peperoni",
                Price =3000
                },
                 new Pizza
                {
                ID =Guid.NewGuid().ToString(),
                Name="Tashir",
                Price =4500
                },
            };
            return list;
        }
    }
}
