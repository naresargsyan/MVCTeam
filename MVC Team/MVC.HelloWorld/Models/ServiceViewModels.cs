﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.HelloWorld.Models
{
    public class Pizza
    {
       public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
    public class PizzaViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
        
    
}
