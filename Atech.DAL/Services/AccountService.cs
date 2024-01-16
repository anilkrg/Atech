using Atech.DAL.Interface;
using Atech.ObjectModel;
using Atech.ObjectModel.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atech.DAL.Services
{
    public class AccountService : IAccountUser
    {

        private readonly ApplicationDbContext _dbContext;
        public AccountService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public Task<Tbl_User> GetEmailbyID(string Email)
        {
            throw new NotImplementedException();
        }

        public async Task<Tbl_User> SignIn(SignInModel signInModel)
        {
            try
            {


                var res = await _dbContext.tbl_Users.SingleOrDefaultAsync(e => e.Email == signInModel.Email && e.Password == signInModel.Password);
                if (res != null)
                {
                    return res;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Tbl_User> SignUp(SignUpModel signUpModel)
        {
            try
            {

                var newUser = new Tbl_User
                {
                    Name = signUpModel.Name,
                    Email = signUpModel.Email,
                    Password = signUpModel.Password,
                    Phone = signUpModel.Phone,
                    Address = signUpModel.Address,
                    Gender = signUpModel.Gender,
                };

                // Add the new user to the database
                _dbContext.tbl_Users.Add(newUser);
                await _dbContext.SaveChangesAsync();
                return newUser;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
