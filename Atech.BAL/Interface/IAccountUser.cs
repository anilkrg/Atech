
using Atech.ObjectModel;
using Atech.ObjectModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atech.BAL.Interface
{
	public interface IAccountUser
	{
		Task<Tbl_User>SignUp(SignUpModel signUpModel);	
		Task<Tbl_User>SignIn(SignInModel signInModel);	
		Task<Tbl_User>GetEmailbyID( string Email);	
	}
}
