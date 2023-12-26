using Atech.BAL.Interface;
using Atech.DAL;
using Atech.ObjectModel;
using Atech.ObjectModel.ViewModel;
using Atech.Utility;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Tbl_User> GetEmailbyID(string Id)
		{

            throw new NotImplementedException();
            //var res = await _dbContext.tbl_Users.SingleOrDefaultAsync(Id);
            //if (res != null)
            //{
            //	return res;	
            //}
            //else
            //{
            //	return null;
            //}
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
            catch(Exception ex)
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
