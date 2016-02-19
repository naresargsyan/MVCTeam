using MVC.HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.HelloWorld.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pizza(int page=1)
        {
            ViewBag.page = page;
            ViewData["page"] = page;
            for (int i = 0; i < 10; i++)
            {
                ViewData[$"data{i}"] = i;
            }
            var count = 10;
            var list = ModelFactory.GetPizzaList();
            var model = list
                .Skip((page - 1) * count)
                .Take(count)
                .Select(p => ModelFactory.Create(p));
            return View(model);
        }
    }
}