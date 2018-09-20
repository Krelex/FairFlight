# IO.Swagger.Model.Reservation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FlightTickets** | [**FlightTicket**](FlightTicket.md) |  | [optional] 
**UnticketedFlights** | [**List&lt;FlightReservationBound&gt;**](FlightReservationBound.md) | The flight itineraries in this reservation that have not yet been ticketed or priced. | [optional] 
**Cars** | [**List&lt;CarReservation&gt;**](CarReservation.md) | The rental cars reserved. | [optional] 
**Hotels** | [**List&lt;HotelReservation&gt;**](HotelReservation.md) | The hotel room bookings in this reservation. | [optional] 
**Others** | [**List&lt;OtherReservation&gt;**](OtherReservation.md) | Free text information to represent other travel items that may be considered part of the travel itinerary in this reservation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

