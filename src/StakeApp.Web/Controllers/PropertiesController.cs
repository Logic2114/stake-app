using Microsoft.AspNetCore.Mvc;

namespace StakeApp.Web.Controllers
{
    public class PropertiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}