using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vitality.Application.Common.Interfaces;
using Vitality.Infrastructure.Persistence;

namespace Vitality.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VitalityDbContext>(options => options.UseSqlServer
            (
                connectionString: configuration.GetConnectionString("VitalityConStr")
            ));
            services.AddScoped<IVitalityDbContext>(provider => provider.GetService<VitalityDbContext>());
            services.AddScoped<DbContext>(provider => provider.GetService<VitalityDbContext>());

            return services;
        }
    }
}