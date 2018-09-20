# IO.Swagger.Model.HotelReservation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Uniquely identifies this hotel room reservation in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record. | 
**CheckIn** | **DateTime?** | Date on which the guest will begin their stay in the hotel, in the &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-dd. | 
**CheckOut** | **DateTime?** | Date on which the guest will end their stay in the hotel, in the &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-dd. | 
**PropertyCode** | **string** | The 8 character property code of this given hotel. The first 2 characters of this code are the chain code that can be specified in the input. The remaining elements are proprietary to each hotel chain. | 
**PropertyName** | **string** | The name of this hotel. | 
**TotalPrice** | [**Amount**](Amount.md) | The total price of this stay, from the given check in date to the given check out date. | [optional] 
**TravelerIds** | **List&lt;string&gt;** | Traveler identifiers to indicate the travelers to whom this hotel room reservation applies. Generally all non-infant room occupants will be marked in this array. | 
**BookingInfo** | [**HotelReservationBookingInfo**](HotelReservationBookingInfo.md) | Additional details and status of this hotel room reservation. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

