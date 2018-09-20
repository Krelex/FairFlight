# IO.Swagger.Model.CityInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; of this city. If you intend to make a flight search from the output of this call, I recommend using this as your input parameter as it generally gives the best results. | 
**GeonamesID** | **string** | The ID of this city in the open-sourced Geonames DB | 
**Name** | **string** | The name of this city, in English | 
**State** | **string** | The state code of this city, if applicable | [optional] 
**Country** | **string** | The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2\&quot;&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt; in which this city can be found. | 
**Location** | [**Geolocation**](Geolocation.md) | This city&#39;s approximate geolocation. The exact center of a city is often not an exact location, so be aware that this might not be exact. | 
**Timezone** | **string** | The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/List_of_tz_database_time_zones\&quot;&gt;Olson format&lt;/a&gt; name of the timezone in which this city is located | 
**Currency** | **string** | The ISO-4217 currency code of the official local currency at this location | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

