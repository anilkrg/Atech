using Atech.BAL.Interface;
using Atech.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Atech.Controllers
{
	public class AccountController : Controller
	{

		private readonly IAccountUser _user;

        public AccountController(IAccountUser user)
        {
				_user = user;
        }
        public IActionResult Register()
		{
			return View();	
		}

		[HttpPost]
		public IActionResult Regitser(SignUpModel signUpModel)
		{
			return View();
		}



		public IActionResult Login()
		{
			return View();	
		}
		[HttpPost]
		public IActionResult Login(SignInModel signInModel)
		{
			return View();	
		}
	}
}
