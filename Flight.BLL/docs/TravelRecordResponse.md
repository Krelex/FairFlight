# IO.Swagger.Model.TravelRecordResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecordLocator** | **string** | 6 character identifier of this travel record on the Amadeus system. | 
**Header** | [**TravelRecordHeader**](TravelRecordHeader.md) | Summarized metadata on the record that has been retrieved. | [optional] 
**Messages** | [**List&lt;Message&gt;**](Message.md) | Functional or technical messages associated with the retrieval of this travel record. | [optional] 
**Travelers** | [**List&lt;Traveler&gt;**](Traveler.md) | Information about each traveler who may be included as part of this travel record. | [optional] 
**Reservation** | [**Reservation**](Reservation.md) | Details about the itineraries that have been reserved as part of this travel record. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

