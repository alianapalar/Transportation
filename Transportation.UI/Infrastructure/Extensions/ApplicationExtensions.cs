using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Transportation.DataAccessLayer.Context;
using Transportation.EntityLayer.Entities;

namespace Transportation.UI.Infrastructure.Extensions
{
    public static class ApplicationExtensions
    {
        public static async void ConfigureDefaultAdminUser(this IApplicationBuilder app)
        {
            const string adminUser = "Admin";
            const string adminPassword = "Admin123456+";
            UserManager<AppUser> userManager = app.
                ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<UserManager<AppUser>>();
            RoleManager<AppRole> roleManager=app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<RoleManager<AppRole>>();

            AppUser user=await userManager.FindByNameAsync(adminUser);
            if (user == null)
            {
                user = new AppUser()
                {
                    Email = "deneme@mail.com",
                    PhoneNumber = "350872737574",
                    UserName = adminUser
                };
                var result = await userManager.CreateAsync(user, adminPassword);
                if (!result.Succeeded)
                    throw new Exception("Admin user not created");
                var roleResult = await userManager.AddToRolesAsync(user, roleManager.Roles.Select(r => r.Name).ToList());
                if (!roleResult.Succeeded)
                    throw new Exception("System have problems with role definition for admin");
            }
        }

        public static void ConfigureCheckAndMigration(this IApplicationBuilder app)
        {
            TransportationContext context = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<TransportationContext>();

            if (context.Database.GetPendingMigrations().Any())
                context.Database.Migrate();
        }
    }
}
