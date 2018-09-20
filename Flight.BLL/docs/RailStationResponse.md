# IO.Swagger.Model.RailStationResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of this station, as provided in the request | 
**Type** | **string** | The type of code to which this station refers. Some codes represent agglomeration of multiple stations, whereas others represent an individual station. Possible values are AGGLOMERATION and STATION. | 
**Name** | **string** | The name of this station. | 
**ShortName** | **string** | The shortened name of this station (20 characters max) which may be used in certain cases. | 
**Country** | **string** | The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2\&quot;&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt; in which this station can be found. | 
**Location** | [**Geolocation**](Geolocation.md) | This stations&#39;s approximate geolocation.  | 
**Traffic** | **string** | An indication of the level of Intercity traffic passing through this station. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

