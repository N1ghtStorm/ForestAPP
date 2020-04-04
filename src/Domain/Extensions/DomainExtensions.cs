using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class DomainExtensions
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddAutoMapper();
        }
    }
}
