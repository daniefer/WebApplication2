using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    public class AnotherController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new Models.Greeting();
            model.CurrentTime = DateTime.Today.AddHours(5);
            model.FirstName = "Peter";
            return View(model);
        }
    }
}
