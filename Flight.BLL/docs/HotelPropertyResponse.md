# IO.Swagger.Model.HotelPropertyResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyCode** | **string** | The 8 character property code of this given hotel. The first 2 characters of this code are the chain code that can be specified in the input. The remaining elements are proprietary to each hotel chain. | 
**PropertyName** | **string** | The name of this hotel. | 
**Location** | [**Geolocation**](Geolocation.md) |  | 
**Address** | [**Address**](Address.md) |  | [optional] 
**TotalPrice** | [**Amount**](Amount.md) | The lowest price of a stay, from the given check in date to the given check out date. | 
**MinDailyRate** | [**Amount**](Amount.md) | The lowest price per day that the hotel offers between the given check-in and check-out dates. Extra taxes may apply to this rate. | 
**Contacts** | [**List&lt;Contact&gt;**](Contact.md) | An array of contact objects to tell the user how to contact the hotel. Typically includes a phone and fax number | [optional] 
**Amenities** | [**List&lt;Amenity&gt;**](Amenity.md) | An array of amenity objects to the user what facilities this hotel might provide, such as a pool or parking.  If this array is empty, it does not necessarily mean that there are no amenities available at this hotel, it could also mean that the hotel does not list their amenities in our search!  | [optional] 
**Awards** | [**List&lt;Award&gt;**](Award.md) | An array of hotel award objects to give the user an expectation of the service quality at this hotel. This can be used to indicate, for example, the star rating of a hotel. If this array is empty, it does not necessarily mean that the hotel has no awards, it could simply mean that they didn&#39;t tell us about them! | [optional] 
**Images** | [**List&lt;Image&gt;**](Image.md) | A selection of image objects, showing pictures of the hotel building, the entrance or some rooms, to give an indication of what to expect at this hotel. Note that redistribution of images outside Amadeus products requires licensing from our image providers: Leonardo and Ice Portal. Thus image links are returned for whitelisted Amadeus users only. | [optional] 
**Rooms** | [**List&lt;HotelRoom&gt;**](HotelRoom.md) | Information on currently available rooms at this hotel. | [optional] 
**MoreRoomsAtThisHotel** | [**Link**](Link.md) | Provides a ready-to-use link to make a follow up request to find more available rooms at this hotel | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

