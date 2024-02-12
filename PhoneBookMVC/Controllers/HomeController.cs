using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBookMVC.Domain;
using PhoneBookMVC.Domain.Entities;

namespace PhoneBookMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            if(_dataManager == null)
            {
                return RedirectToAction("NoData", "NotFound");
            }
            else
            {
                return View(_dataManager.PhoneBookRecords.GetPhoneBookRecords());
            }
        }
    }
}
