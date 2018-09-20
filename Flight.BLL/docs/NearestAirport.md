# IO.Swagger.Model.NearestAirport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Airport** | **string** | The 3 letter IATA airport code of this given airport. You can use this as an input parameter for a low-fare flight search, to get more specific results than the city code, but inspiration search works best using the city code. | 
**AirportName** | **string** | The name of this airport, in UTF-8 format | 
**City** | **string** | The three letter &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; of the city of the city in which this airport is located. | 
**CityName** | **string** | The English name of the city in which this airport is located | 
**State** | **string** | The state code of this city, if applicable | [optional] 
**Distance** | **decimal?** | The distance in km from the point specified in the query, to this location | 
**Location** | [**Geolocation**](Geolocation.md) |   An object containing the longitude and latitude of the given airport. | 
**AircraftMovements** | **int?** | The annual number of aircraft movements at that airport. | [optional] 
**Timezone** | **string** | The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/List_of_tz_database_time_zones\&quot;&gt;Olson format&lt;/a&gt; name of the timezone in which this airport is located | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

