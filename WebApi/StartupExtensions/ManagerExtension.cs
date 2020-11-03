using Business.Interfaces;
using Business.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.StartupExtensions
{
    internal static class ManagerExtension
    {
        public static IServiceCollection AddManagers(this IServiceCollection services)
        {
            services.AddTransient<IUserLoginManager, UserLoginManager>();


            return services;
        }
    }
}
