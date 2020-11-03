using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Repository.Repositories;

namespace WebApi.StartupExtensions
{
    internal static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserLoginRepository, UserLoginRepository>();

            return services;
        }
    }
}
