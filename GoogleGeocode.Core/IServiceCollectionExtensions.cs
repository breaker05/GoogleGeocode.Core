using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace GoogleGeocode.Core
{
    public static class IServiceCollectionExtensions
    {
        private const string Identifier = "GoogleGeocodeCore";

        public static IServiceCollection AddGoogleGeocodeCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.Configure<GoogleGeocodeCoreOptions>(configuration.GetSection(Identifier));
            services.TryAddTransient<IGoogleGeocodeCoreClient>((sp) =>
            {
                var options = sp.GetService<IOptions<GoogleGeocodeCoreOptions>>().Value;
                return new GoogleGeocodeCoreClient(options);
            });

            return services;
        }
    }
}
