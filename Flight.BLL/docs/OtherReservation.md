# IO.Swagger.Model.OtherReservation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Uniquely identifies this other reservation in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record. | 
**Date** | **DateTime?** | Date on which this other reservation will begin, in the &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-dd. | 
**Location** | **string** | A 3 letter &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; that identifies where this other reservation will occur. | 
**Description** | **string** | A free-text description of this reservation, that will inform you of its functional meaning. | [optional] 
**TravelerIds** | **List&lt;string&gt;** | Traveler identifiers to indicate the travelers to whom this reservation applies. | 
**BookingInfo** | [**OtherReservationBookingInfo**](OtherReservationBookingInfo.md) | The status of this reservation. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

