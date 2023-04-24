using FormApplication.DataAccess.Contexts;
using FormApplication.DataAccess.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

namespace FormApplication.DataAccess.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentityCore<BaseUser>(options =>
            {
                //Kullanıcı ayarları..
            })
                .AddEntityFrameworkStores<FormAppDb>();
            return services;
        }
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FormAppDb>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString(FormAppDb.ConnectionName),
                    options => options.EnableRetryOnFailure(
                        10,
                        TimeSpan.FromSeconds(10),
                        null));
                options.UseLazyLoadingProxies();

            });

            return services;
        }
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFormRepository, FormRepository>();
            services.AddScoped<IFieldRepository, FieldRepository>();
            return services;
        }

    }
}
