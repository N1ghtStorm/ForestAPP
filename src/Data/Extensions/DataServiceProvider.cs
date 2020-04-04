using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Extensions
{
    public static class DataServiceProvider
    {
        public static void AddForestDbContextMSSQL(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ForestDbContext>(opt => opt.UseSqlServer(connectionString), ServiceLifetime.Transient);
        }

        public static void AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddScoped<IForestRepository, ForestRepository>();
        }
    }
}
