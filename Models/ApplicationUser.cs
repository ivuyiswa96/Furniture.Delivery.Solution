using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchMe.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int PersonId { get; set; }
        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
