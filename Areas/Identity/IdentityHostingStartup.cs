using System;
using FagElGamous.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Sqlite;

[assembly: HostingStartup(typeof(FagElGamous.Areas.Identity.IdentityHostingStartup))]
namespace FagElGamous.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<FagElGamousContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FagElGamousContextConnection")));

                services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddDefaultUI()
                    .AddEntityFrameworkStores<FagElGamousContext>()
                    .AddDefaultTokenProviders();
                services.AddControllersWithViews();
                services.AddRazorPages();

                services.AddAuthorization(options =>
                {
                    options.AddPolicy("readpolicy",
                        builder => builder.RequireRole("Admin", "Researcher"));
                    options.AddPolicy("writepolicy",
                        builder => builder.RequireRole("Admin", "Researcher"));
                    options.AddPolicy("both",
                        builder => builder.RequireRole("Admin", "Researcher"));
                    options.AddPolicy("admin",
                        builder => builder.RequireRole("Admin"));
                });
            });
        }
    }
}