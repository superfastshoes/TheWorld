using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWorld.Services;
using TheWorld.ViewModels;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;

        // Constructor
        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }

        // Find, Render, then return that view to the user
        public IActionResult Index()
        {
            return View();
        }

    public IActionResult Contact()
        {
            return View();
        }

    [HttpPost]
    public IActionResult Contact(ContactViewModel model)
        {
            _mailService.SendMail("eddie@gmail.com", model.Email, "From TheWorld", model.Message);
            return View();
        }

    public IActionResult About()
        {
            return View();
        }
    }
}
