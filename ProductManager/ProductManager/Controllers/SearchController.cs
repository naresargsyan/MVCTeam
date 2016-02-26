using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProductManager.Controllers
{
    public class SearchController : Controller
    {
        private ProductManagerDbContext db = new ProductManagerDbContext();
        // GET: Search
        public async Task<ActionResult> Index(string ID)
        {
            var products = await db.Products.Where(p => p.Name.Contains(ID)).ToListAsync();
            return View(products);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}