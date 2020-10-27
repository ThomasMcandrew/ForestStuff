using ForestStuff.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForestStuff.Controllers
{ 
    public class HomeController : Controller
    {
        private DatabaseContext dbContext;
        public HomeController(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            RandomThing t = new RandomThing();

            t.stuff = "DF";
            t.otherStuff = "DFDF";

            dbContext.Add(t);
            dbContext.SaveChanges();
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
