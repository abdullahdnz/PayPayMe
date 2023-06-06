using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PayPayMe.DTO.DTOs.AppUserDTOs;
using PayPayMe.Entity.Concrete;

namespace PayPayMe.Presentation.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> _userManager)
        {
            this._userManager = _userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDTO appUserRegisterDTO)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = appUserRegisterDTO.Name,
                    Surname = appUserRegisterDTO.Lastname,
                    UserName = appUserRegisterDTO.Username,
                    Email = appUserRegisterDTO.Email
                };
                var value = await _userManager.CreateAsync(appUser, appUserRegisterDTO.Password);
                if (value.Succeeded)
                {
                    return RedirectToAction("Index", "ConfirmMail");
                }
                else
                {
                    foreach (var item in value.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
