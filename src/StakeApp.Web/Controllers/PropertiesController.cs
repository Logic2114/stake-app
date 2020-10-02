using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StakeApp.Web.Interfaces;
using StakeApp.Web.Models;

namespace StakeApp.Web.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly IPropertyService _propertyService; 
        public PropertiesController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var properties = _propertyService.GetAllProperties();
            return View(properties);
        }
        [HttpGet]

        public IActionResult Add()
        {
            return View();
        }
        public async Task<IActionResult> Add(PropertyModel model)
        {
            try
            {
                await _propertyService.AddProperty(model);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}