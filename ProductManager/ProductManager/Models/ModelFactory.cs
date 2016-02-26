using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManager.Models
{
    class ModelFactory
    {
        public static Category Create(CategoryViewModel model)
        {
            return new Category
            {
                ID = model.ID,
                Name = model.Name,


            };
        }
    }
}