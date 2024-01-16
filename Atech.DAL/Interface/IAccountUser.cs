using Atech.ObjectModel.ViewModel;
using Atech.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atech.DAL.Interface
{
    public interface IAccountUser
    {
        Task<Tbl_User> SignUp(SignUpModel signUpModel);
        Task<Tbl_User> SignIn(SignInModel signInModel);
        Task<Tbl_User> GetEmailbyID(string Email);
    }
}
