# IO.Swagger.Model.HotelRoom
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BookingCode** | **string** | The booking code identifies a product at the hotel. It can be used to book a room. | 
**RoomTypeCode** | **string** | A 3-letter code to identify a specific room type. | [optional] 
**RatePlanCode** | **string** | A 3 letter code to designate different rates base on traveler type. | [optional] 
**TotalAmount** | [**Amount**](Amount.md) | The total price of staying in this room from the given check-in date to the given check-out date | [optional] 
**Rates** | [**List&lt;PeriodRate&gt;**](PeriodRate.md) | The total price of staying in this room from the given check-in date to the given check-out date | [optional] 
**Descriptions** | **List&lt;string&gt;** | An array of description strings describing room and rate types features | [optional] 
**RoomTypeInfo** | [**RoomInfo**](RoomInfo.md) |  | [optional] 
**RateTypeCode** | **string** | The unique rate code used by the hotel chain to price this room&#39;s rate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

