using DotNet_Dojo.Application.Services;
using DotNet_Dojo.Application.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace DotNet_Dojo.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServiceReferences(this IServiceCollection services)
        {
            services.AddSingleton<IReferenceService, ReferenceService>();

            return services;
        }
    }
}
