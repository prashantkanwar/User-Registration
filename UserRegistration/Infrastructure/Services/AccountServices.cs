using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AccountServices: IAccountServices
    {
        
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountServices(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(Register register)
        {
            var user = new ApplicationUser 
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                UserName = register.Email,
                Email = register.Email 
            };
            var result = await _userManager.CreateAsync(user, register.Password);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(Login login)
        {
            return await _signInManager.PasswordSignInAsync(login.Email, login.Password,
                                       login.RememberMe, false);
        }


        public async Task SignOutAsync()
        {

            await _signInManager.SignOutAsync();
            
        }

        
    }
}
