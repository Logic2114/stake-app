using Microsoft.AspNetCore.Mvc;

namespace StakeApp.Web.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}