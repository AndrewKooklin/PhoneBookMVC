using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PhoneBookMVC.Controllers
{
    public class NotFoundController : Controller
    {
        public IActionResult NoData()
        {
            return View();
        }
    }
}
