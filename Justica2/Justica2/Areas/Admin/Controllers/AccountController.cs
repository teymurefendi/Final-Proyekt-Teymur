using Justica2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "SuperAdmin,Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)

        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(VmLogin model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    //if (!(_userManager.Users.Any(x=>x.Email==model.Email))&& !(_userManager.Users.Any(y => y.PasswordHash == model.Password)))
                    //{
                    //    ModelState.AddModelError("", "Invalid both of input.");
                    //}
                    //if(_userManager.Users.Any(y => y.PasswordHash == model.Password) && !_userManager.Users.Any(x => x.Email == model.Email))
                    //{
                    //    ModelState.AddModelError("", "Invalid email.");
                    //}
                    //else if (_userManager.Users.Any(x=>x.Email==model.Email) && !_userManager.Users.Any(y => y.PasswordHash == model.Password))
                    //{
                    //    ModelState.AddModelError("", "Invalid password.");
                    //}
                    //else
                    //{
                    //    ModelState.AddModelError("", "Invalid both of input.");
                    //}
                    //bool password = _signInManager.UserManager.Users.Any(y => y.PasswordHash == model.Password);
                    bool user = _signInManager.UserManager.Users.Any(x => x.UserName == model.Email);



                    switch (user)
                    {
                        case (true):
                            ModelState.AddModelError("", "Invalid password.");
                            break;
                        case (false):
                            ModelState.AddModelError("", "Invalid email.");
                            break;
                            //case(false,false):
                            //    ModelState.AddModelError("", "Invalid both of input.");
                            //    break;
                    }
                }
            }
            return View();
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(VmRegister model)
        {
            if (ModelState.IsValid)
            {
                var User = new IdentityUser() { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(User, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(User, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
