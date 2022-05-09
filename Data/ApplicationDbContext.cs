using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using uwierzytelnianie.Models;

namespace uwierzytelnianie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Fizzbuzz> Fizzbuzz { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
    }
}
