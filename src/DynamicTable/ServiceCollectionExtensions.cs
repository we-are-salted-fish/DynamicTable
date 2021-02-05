using DynamicTable;
using DynamicTable.Shared;


// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDynamicTable(this IServiceCollection services)
        {
            services.AddSingleton<StateContainer>();
            services.AddSingleton<ExampleJsInterop>();
            return services;
        }
        
    }
}