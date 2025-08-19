using Application.Microservices.Services.AuthAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Application.Microservices.Services.AuthAPI.Data
{
    public class AppDbContext :IdentityDbContext<ApplicationUser> // Inherit from IdentityDbContext to use Identity features
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; } // DbSet for ApplicationUser if needed

    }
}
