using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class CreateRole
    {
        [Required]
        public string RoleName { get; set; }
    }
}
