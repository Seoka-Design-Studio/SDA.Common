using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace SDA.Common.Configuration.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Configures the service collection by adding AutoMapper and Fluent Validation from the executing assembly.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to configure.</param>
        /// <returns>The configured <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection ConfigureMappingAndValidators(this IServiceCollection services)
        {
            return services
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
