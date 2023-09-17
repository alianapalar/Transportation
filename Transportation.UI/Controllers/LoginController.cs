using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Transportation.EntityLayer.Entities;
using Transportation.UI.Models;

namespace Transportation.UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost] 
        public async Task<IActionResult> SignIn(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Default");
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel model)
        {
            AppUser user = new AppUser()
            {
                UserName=model.Username,
                Email=model.Email

            };
            if (model.Password == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("SignIn","Login");
                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Default");
        }
    }
}
