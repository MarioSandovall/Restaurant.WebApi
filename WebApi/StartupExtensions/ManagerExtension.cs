using Business.Interfaces;
using Business.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.StartupExtensions
{
    internal static class ManagerExtension
    {
        public static IServiceCollection AddManagers(this IServiceCollection services)
        {

            services.AddTransient<ILoginManager, LoginManager>();
            services.AddTransient<IAccountManager, AccountManager>();

            return services;
        }
    }
}
