using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab13George.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {
        [Route("Error")]
        public IActionResult Index() => View();
    }
}