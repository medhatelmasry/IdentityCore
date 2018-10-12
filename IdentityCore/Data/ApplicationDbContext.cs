using System;
using System.Collections.Generic;
using System.Text;
using IdentityCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
