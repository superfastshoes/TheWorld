using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        // Find, Render, then return that view to the user
        public IActionResult Index()
        {
            return View();
        }
    }
}
