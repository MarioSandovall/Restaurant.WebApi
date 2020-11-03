using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.StartupExtensions
{
    internal static class DbContextExtension
    {
        public static IServiceCollection AddRestaurantDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<RestaurantContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Restaurant")));
        }
    }
}
