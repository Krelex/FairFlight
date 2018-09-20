/* 
 * Amadeus Travel Innovation Sandbox
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Reservation
    /// </summary>
    [DataContract]
    public partial class Reservation :  IEquatable<Reservation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reservation" /> class.
        /// </summary>
        /// <param name="FlightTickets">FlightTickets.</param>
        /// <param name="UnticketedFlights">The flight itineraries in this reservation that have not yet been ticketed or priced..</param>
        /// <param name="Cars">The rental cars reserved..</param>
        /// <param name="Hotels">The hotel room bookings in this reservation..</param>
        /// <param name="Others">Free text information to represent other travel items that may be considered part of the travel itinerary in this reservation..</param>
        public Reservation(FlightTicket FlightTickets = default(FlightTicket), List<FlightReservationBound> UnticketedFlights = default(List<FlightReservationBound>), List<CarReservation> Cars = default(List<CarReservation>), List<HotelReservation> Hotels = default(List<HotelReservation>), List<OtherReservation> Others = default(List<OtherReservation>))
        {
            this.FlightTickets = FlightTickets;
            this.UnticketedFlights = UnticketedFlights;
            this.Cars = Cars;
            this.Hotels = Hotels;
            this.Others = Others;
        }
        
        /// <summary>
        /// Gets or Sets FlightTickets
        /// </summary>
        [DataMember(Name="flight_tickets", EmitDefaultValue=false)]
        public FlightTicket FlightTickets { get; set; }

        /// <summary>
        /// The flight itineraries in this reservation that have not yet been ticketed or priced.
        /// </summary>
        /// <value>The flight itineraries in this reservation that have not yet been ticketed or priced.</value>
        [DataMember(Name="unticketed_flights", EmitDefaultValue=false)]
        public List<FlightReservationBound> UnticketedFlights { get; set; }

        /// <summary>
        /// The rental cars reserved.
        /// </summary>
        /// <value>The rental cars reserved.</value>
        [DataMember(Name="cars", EmitDefaultValue=false)]
        public List<CarReservation> Cars { get; set; }

        /// <summary>
        /// The hotel room bookings in this reservation.
        /// </summary>
        /// <value>The hotel room bookings in this reservation.</value>
        [DataMember(Name="hotels", EmitDefaultValue=false)]
        public List<HotelReservation> Hotels { get; set; }

        /// <summary>
        /// Free text information to represent other travel items that may be considered part of the travel itinerary in this reservation.
        /// </summary>
        /// <value>Free text information to represent other travel items that may be considered part of the travel itinerary in this reservation.</value>
        [DataMember(Name="others", EmitDefaultValue=false)]
        public List<OtherReservation> Others { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reservation {\n");
            sb.Append("  FlightTickets: ").Append(FlightTickets).Append("\n");
            sb.Append("  UnticketedFlights: ").Append(UnticketedFlights).Append("\n");
            sb.Append("  Cars: ").Append(Cars).Append("\n");
            sb.Append("  Hotels: ").Append(Hotels).Append("\n");
            sb.Append("  Others: ").Append(Others).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Reservation);
        }

        /// <summary>
        /// Returns true if Reservation instances are equal
        /// </summary>
        /// <param name="input">Instance of Reservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reservation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlightTickets == input.FlightTickets ||
                    (this.FlightTickets != null &&
                    this.FlightTickets.Equals(input.FlightTickets))
                ) && 
                (
                    this.UnticketedFlights == input.UnticketedFlights ||
                    this.UnticketedFlights != null &&
                    this.UnticketedFlights.SequenceEqual(input.UnticketedFlights)
                ) && 
                (
                    this.Cars == input.Cars ||
                    this.Cars != null &&
                    this.Cars.SequenceEqual(input.Cars)
                ) && 
                (
                    this.Hotels == input.Hotels ||
                    this.Hotels != null &&
                    this.Hotels.SequenceEqual(input.Hotels)
                ) && 
                (
                    this.Others == input.Others ||
                    this.Others != null &&
                    this.Others.SequenceEqual(input.Others)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FlightTickets != null)
                    hashCode = hashCode * 59 + this.FlightTickets.GetHashCode();
                if (this.UnticketedFlights != null)
                    hashCode = hashCode * 59 + this.UnticketedFlights.GetHashCode();
                if (this.Cars != null)
                    hashCode = hashCode * 59 + this.Cars.GetHashCode();
                if (this.Hotels != null)
                    hashCode = hashCode * 59 + this.Hotels.GetHashCode();
                if (this.Others != null)
                    hashCode = hashCode * 59 + this.Others.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
