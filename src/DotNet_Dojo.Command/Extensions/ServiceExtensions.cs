using DotNet_Dojo.Command.UseCases.Reference.Handlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DotNet_Dojo.Domain.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddMediatorReferences(this IServiceCollection services)
        {
            var mediatrAssembly = Assembly.GetAssembly(typeof(GetExampleReference));
            
            return services.AddMediatR(mediatrAssembly);
        }
    }
}
