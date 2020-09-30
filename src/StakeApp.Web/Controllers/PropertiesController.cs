using System;
using Microsoft.AspNetCore.Mvc;
using StakeApp.Web.Models;

namespace StakeApp.Web.Controllers
{
    public class PropertiesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Add(PropertyModel model)
        {
            throw new NotImplementedException();
        }
    }
}