using Atech.ObjectModel.ViewModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Atech.Utility;
using Atech.DAL.Interface;

namespace Atech.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountUser _accountUser;
        private readonly ILogger<AccountController> _logger;
        public AccountController(IAccountUser accountUser, ILogger<AccountController> logger)
        {
            _accountUser = accountUser;
            _logger = logger;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(SignUpModel signUpModel)
        {
            try
            {
                var result = await _accountUser.SignUp(signUpModel);
                if (result != null)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
                _logger.LogError(ex.Message);
            }


        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Login(SignInModel signInModel)
        {
            
                var result = await _accountUser.SignIn(signInModel);
                if (result != null)
                {

                    var claims = new List<Claim>() {

                        new Claim(ClaimTypes.Name, signInModel.Email),
                    };


                    //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme    
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
                    var principal = new ClaimsPrincipal(identity);
                    //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
                    {
                        IsPersistent = signInModel.RememberMe
                    });
                    return RedirectToAction("Dash", "Dash");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login credential");
                    
                }
                
            
            return View(signInModel);


        }
    }
}
