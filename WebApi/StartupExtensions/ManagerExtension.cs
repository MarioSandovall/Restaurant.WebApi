using Microsoft.Extensions.DependencyInjection;

namespace WebApi.StartupExtensions
{
    internal static class ManagerExtension
    {
        public static IServiceCollection AddManagers(this IServiceCollection services)
        {

            return services;
        }
    }
}
