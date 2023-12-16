using Atech.BAL.Interface;
using Atech.DAL;
using Atech.Model;
using Atech.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atech.BAL.Services
{
	public class AccountServices : IAccountUser
	{
		private readonly ApplicationDbContext _dbContext;
        public AccountServices(ApplicationDbContext context)
        {
				_dbContext = context;
        }

        public Task<Tbl_User> GetEmailbyID(string Email)
		{
			throw new NotImplementedException();
		}

		public Task<Tbl_User> SignIn(SignInModel signInModel)
		{
			throw new NotImplementedException();
		}

		public Task<Tbl_User> SignUp(SignUpModel signUpModel)
		{
			throw new NotImplementedException();
		}
	}
}
