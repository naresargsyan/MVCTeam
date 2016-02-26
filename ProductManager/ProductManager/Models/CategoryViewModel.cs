using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductManager.Models
{
    public class CategoryViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Barev")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
    }
}