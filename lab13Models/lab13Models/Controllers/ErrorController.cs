using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab13Models.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error")]
        public ViewResult Index()
        {
            string errorMessage = "Opps, something went wrong!";
            ViewData["msg"] = errorMessage;
            return View();
        }
    }
}
