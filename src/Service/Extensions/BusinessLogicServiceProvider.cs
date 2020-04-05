using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace Service.Extensions
{
    public static class BusinessLogicServiceProvider
    {
        public static void AddBusinessLogicLayer(this IServiceCollection services)
        {
            services.AddScoped<IForestService, ForestService>();
            services.AddScoped<ITreeService, TreeService>();
        }
    }
}
