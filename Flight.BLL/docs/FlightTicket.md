# IO.Swagger.Model.FlightTicket
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Uniquely identifies this ticket in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record. | 
**Price** | [**Amount**](Amount.md) | The cost of this ticket. | 
**TravelerIds** | **List&lt;string&gt;** | Traveler identifiers to indicate the travelers to whom this ticket applies. | 
**FlightBounds** | [**List&lt;FlightReservationBound&gt;**](FlightReservationBound.md) | The flight itinerary for this ticket. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

