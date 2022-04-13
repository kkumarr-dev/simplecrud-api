using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thalavali.API.Controllers
{
    public class MVCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
