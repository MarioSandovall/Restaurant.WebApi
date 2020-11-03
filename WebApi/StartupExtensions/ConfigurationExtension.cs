using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model.Settings;

namespace WebApi.StartupExtensions
{
    internal static class ConfigurationExtension
    {
        public static IServiceCollection AddConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtConfiguration>(configuration.GetSection("Jwt"));

            return services;
        }
    }
}
