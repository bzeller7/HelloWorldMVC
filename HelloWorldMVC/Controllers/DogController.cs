using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class DogController : Controller
    {
        public IActionResult Dog()
        {
            return View();
        }
    }
}