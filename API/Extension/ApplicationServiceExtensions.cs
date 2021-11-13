using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
         IConfiguration config) {
            //JWT Service
            services.AddScoped<ITokenService, TokenService>();
            // Add services to the container.
            services.AddDbContext<AppDataContext>(options => {
            options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}