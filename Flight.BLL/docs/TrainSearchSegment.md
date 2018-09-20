# IO.Swagger.Model.TrainSearchSegment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DepartsAt** | **string** | The &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date-time of the train&#39;s departure in the local time zone of the departure station, in the format YYYY-MM-DDTHH:mm. | 
**ArrivesAt** | **string** | The &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date-time of the train&#39;s arrival in the local time zone of the arrival station, in the format YYYY-MM-DDTHH:mm. | 
**DepartureStation** | [**Station**](Station.md) | The station object representing the station at which the passenger should board this train in order to complete this part of the itinerary. | 
**ArrivalStation** | [**Airport**](Airport.md) | The station object representing the station at which the passenger should disembark this train in order to complete this part of the itinerary. | 
**MarketingCompany** | **string** | The name of the train company selling this train journey. This is the name you should see printed on your ticket. | 
**OperatingCompany** | **string** | The name of the train company operating this train journey. This is the name you should see written on the train. | 
**TrainNumber** | **string** | The identifying number of this train service. Usually the marketing company will only operate on train per day with this train number. | 
**TrainType** | **string** | The type of train that you may expect for this journey. For example&amp;colon; InterCity, Regional... | [optional] 
**Prices** | [**List&lt;TrainSearchPricing&gt;**](TrainSearchPricing.md) | Possible pricing for this train journey. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

