using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreMY.Entity.Concrete.User;
using TraversalCoreMY.UI.Model;

namespace TraversalCoreMY.UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel entity)
        {
            AppUser appUser = new AppUser()
            {
                Name = entity.Name,
                SurName = entity.Surname,
                Email = entity.Mail,
                UserName = entity.Username,
            };

            if (entity.Password == entity.ConfirmPassword)
            {
                IdentityResult identityResult = await _userManager.CreateAsync(appUser,entity.Password);

                if (identityResult.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }
           
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
