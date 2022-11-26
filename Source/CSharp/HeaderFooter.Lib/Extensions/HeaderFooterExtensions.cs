using HeaderFooter.Lib.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HeaderFooter.Lib.Extensions
{

    public static class HeaderFooterExtensions
    {

        public static IServiceCollection ConfigureNamesArrayDemoServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IFooter, Footer>();
            _ = services.AddTransient<IHeader, Header>();

            return services;
        }

    }

}
