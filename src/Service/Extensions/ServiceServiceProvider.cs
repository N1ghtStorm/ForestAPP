using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Extensions
{
    public static class ServiceServiceProvider
    {
        public static void AddBusinessLogicLayer(this IServiceCollection services)
        {
            services.AddScoped<IForestService, ForestService>();
        }
    }
}
