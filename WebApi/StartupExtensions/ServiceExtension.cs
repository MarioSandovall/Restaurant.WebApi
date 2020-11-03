using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;
using Service.Services;

namespace WebApi.StartupExtensions
{
    internal static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddTransient<ILoginService, LoginService>();

            return services;
        }
    }
}
