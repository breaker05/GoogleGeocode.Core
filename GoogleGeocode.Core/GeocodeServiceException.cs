using System;

namespace GoogleGeocode.Core
{
    public class GeocodeServiceException : Exception
    {
        public GeocodeServiceException()
        {
        }

        public GeocodeServiceException(string message)
            : base(message)
        {
        }

        public GeocodeServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
