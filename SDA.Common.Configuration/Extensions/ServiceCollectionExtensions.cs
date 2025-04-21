using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SDA.Common.Configuration.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureMappingAndValidators(this IServiceCollection services)
        {
            return services
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
