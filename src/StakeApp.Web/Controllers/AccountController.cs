using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StakeApp.Web.Interfaces;
using StakeApp.Web.Models;
using StakeApp.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace StakeApp.Web.Controllers
{
    public class AccountController : Controller
    {   private readonly IAccountsService _accountsService;
    private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(
            IAccountsService accountsService,
            SignInManager<ApplicationUser> signInManager)
        {
            _accountsService = accountsService; 
            _signInManager = signInManager;           
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return LocalRedirect("~/");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if(!ModelState.IsValid) return View();

            try
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if(!result.Succeeded)
                {
                    
                    ModelState.AddModelError("", "Login failed, please check your details");
                    return View();
                }
                return LocalRedirect("~/");
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
            
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View();

            try
            {
                var user = await _accountsService.CreateUserAsync(model);
                await _signInManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect("~/");
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }

        }
    }
}