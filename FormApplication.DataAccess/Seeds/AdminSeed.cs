using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FormApplication.DataAccess.Seeds
{
    static class AdminSeed
    {
        private const string UserName = "admin";
        private const string Password = "admin";

        public static async Task SeedAsync(IConfiguration configuration)
        {
            var dbContextBuilder = new DbContextOptionsBuilder<FormAppDb>();

            dbContextBuilder.UseSqlServer(configuration.GetConnectionString(FormAppDb.ConnectionName));

            using(FormAppDb context = new(dbContextBuilder.Options))
            {
                if (!context.Users.Any(x=>x.UserName == UserName))
                {
                    await AddAdmin(context);
                }
            }
        }
        private static async Task AddAdmin(FormAppDb context)
        {
            IdentityUser admin = new()
            {
                UserName = UserName,
            };
            admin.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(admin, Password);
            await context.Users.AddAsync(admin);
            await context.SaveChangesAsync();
        }
    }
}
