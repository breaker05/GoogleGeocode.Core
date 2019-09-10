using GoogleGeocode.Core.Models;
using System.Threading.Tasks;

namespace GoogleGeocode.Core
{
    public interface IGoogleGeocodeCoreClient
    {
        Task<GeoAddress> Geocode(string address);
    }
}
