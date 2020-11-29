using Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAccountServices
    {
        Task<IdentityResult> CreateUserAsync(Register register);
        Task<SignInResult> PasswordSignInAsync(Login login);
        Task SignOutAsync();
        
    }
}
