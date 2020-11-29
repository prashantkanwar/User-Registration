using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Core.ViewModels;
using System.Collections;

namespace Core.Interfaces
{
    public interface IAdministrationServices
    {
        Task<IdentityResult> CreateRole(CreateRole createRole);
        
        
    }
}
