using FagElGamous.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Models
{
    public class SeedData
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;



        public SeedData(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async void EnsurePopulated(IApplicationBuilder application)
        {
            FagElGamousContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<FagElGamousContext>();



            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }



            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                        Id = "9e3ba0b1-be63-419e-bcdf-53ce33d49c22"
                    },
                    new IdentityRole
                    {
                        Name = "Researcher",
                        NormalizedName = "RESEARCHER",
                        Id = "26be9a25-2f0d-4391-8d67-a2054fc269cc"
                    }
                );
            }

            /*if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new IdentityUser
                    {
                        Email = "admin@egypt.com",
                        Id = "87de35a9-355e-4899-a94e-2cc50c45bd42",
                        
                    }
                    );
            }
            if (!context.UserRoles.Any())
            {
                context.UserRoles.AddRange(
                    new IdentityUserRole<string>
                    {
                        RoleId = "9e3ba0b1-be63-419e-bcdf-53ce33d49c22",
                        UserId = "87de35a9-355e-4899-a94e-2cc50c45bd42"
                    });
            }*/



            context.SaveChanges();




        }
    }
}
