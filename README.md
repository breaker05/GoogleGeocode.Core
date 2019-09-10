# GoogleGeocode.Core
Google API Wrapper dotnet core 2.2


### Configuration

Add Google Api key in the root of your appsettings.json inside of a subsection :

<pre>
{  
  <b>"GoogleGeocodeCore": {
    "ApiKey": "your_api_key",
  }</b>
}
</pre>

Add AddGoogleGeocodeCore service in your Startup.cs file :
<pre>

public void ConfigureServices(IServiceCollection services)
{
    services.AddGoogleGeocodeCore(Configuration); 
}
</pre>
        
### Service injection
Inside of a class, be sure to inject the client
<pre>
private readonly IGoogleGeocodeCoreClient _googleGeocodeClient;

public GeocodeController(IGoogleGeocodeCoreClient googleGeocodeClient)
{
    _googleGeocodeClient = googleGeocodeClient;
}
</pre>

Use Geocode method in order to geocode a raw address :
```
[HttpGet]
public async Task<ActionResult<GeoAddress>> Get()
{
    return await _googleGeocodeClient.Geocode(
        "1600 Pennsylvania Ave NW, Washington, DC 20500"
     );
}
```

Output: 
```
{
    Address : "1600 Pennsylvania Ave NW, Washington, DC 20500",
    Street : "1600 Pennsylvania Ave NW",
    StreetNumber : "1600",
    City : "Washington",
    ZipCode : "20500",
    Country : "United States of America",
    Lat : 38.8976763,
    Lng : -77.0365298 
}
```