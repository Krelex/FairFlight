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
    /// CarReservation
    /// </summary>
    [DataContract]
    public partial class CarReservation :  IEquatable<CarReservation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarReservation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CarReservation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CarReservation" /> class.
        /// </summary>
        /// <param name="Id">Uniquely identifies this car rental reservation in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record. (required).</param>
        /// <param name="PickUp">Date on which the car rental will be collected from the car rental location. &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-ddTHH. (required).</param>
        /// <param name="DropOff">Date at which the car rental will end and the car will be returned to the rental location. &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-ddTHH. (required).</param>
        /// <param name="Provider">Details of the car company offering this rental. (required).</param>
        /// <param name="Origin">This car rental company office location ID. If this is an airport location, this will be the airport&#39;s &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;. Otherwise, this is a custom value provided by the car rental provider. (required).</param>
        /// <param name="Car">A car information object giving further details about the vehicle provided for rental. (required).</param>
        /// <param name="TravelerIds">Traveler identifiers to indicate the travelers to whom this car rental applies. Generally, only drivers of the vehicle will be marked in this array..</param>
        /// <param name="BookingInfo">Additional details the status of this car rental reservation..</param>
        public CarReservation(string Id = default(string), string PickUp = default(string), string DropOff = default(string), Company Provider = default(Company), string Origin = default(string), Vehicle Car = default(Vehicle), List<string> TravelerIds = default(List<string>), CarReservationBookingInfo BookingInfo = default(CarReservationBookingInfo))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CarReservation and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "PickUp" is required (not null)
            if (PickUp == null)
            {
                throw new InvalidDataException("PickUp is a required property for CarReservation and cannot be null");
            }
            else
            {
                this.PickUp = PickUp;
            }
            // to ensure "DropOff" is required (not null)
            if (DropOff == null)
            {
                throw new InvalidDataException("DropOff is a required property for CarReservation and cannot be null");
            }
            else
            {
                this.DropOff = DropOff;
            }
            // to ensure "Provider" is required (not null)
            if (Provider == null)
            {
                throw new InvalidDataException("Provider is a required property for CarReservation and cannot be null");
            }
            else
            {
                this.Provider = Provider;
            }
            // to ensure "Origin" is required (not null)
            if (Origin == null)
            {
                throw new InvalidDataException("Origin is a required property for CarReservation and cannot be null");
            }
            else
            {
                this.Origin = Origin;
            }
            // to ensure "Car" is required (not null)
            if (Car == null)
            {
                throw new InvalidDataException("Car is a required property for CarReservation and cannot be null");
            }
            else
            {
                this.Car = Car;
            }
            this.TravelerIds = TravelerIds;
            this.BookingInfo = BookingInfo;
        }
        
        /// <summary>
        /// Uniquely identifies this car rental reservation in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record.
        /// </summary>
        /// <value>Uniquely identifies this car rental reservation in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Date on which the car rental will be collected from the car rental location. &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-ddTHH.
        /// </summary>
        /// <value>Date on which the car rental will be collected from the car rental location. &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-ddTHH.</value>
        [DataMember(Name="pick_up", EmitDefaultValue=false)]
        public string PickUp { get; set; }

        /// <summary>
        /// Date at which the car rental will end and the car will be returned to the rental location. &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-ddTHH.
        /// </summary>
        /// <value>Date at which the car rental will end and the car will be returned to the rental location. &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format yyyy-MM-ddTHH.</value>
        [DataMember(Name="drop_off", EmitDefaultValue=false)]
        public string DropOff { get; set; }

        /// <summary>
        /// Details of the car company offering this rental.
        /// </summary>
        /// <value>Details of the car company offering this rental.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public Company Provider { get; set; }

        /// <summary>
        /// This car rental company office location ID. If this is an airport location, this will be the airport&#39;s &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;. Otherwise, this is a custom value provided by the car rental provider.
        /// </summary>
        /// <value>This car rental company office location ID. If this is an airport location, this will be the airport&#39;s &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;. Otherwise, this is a custom value provided by the car rental provider.</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }

        /// <summary>
        /// A car information object giving further details about the vehicle provided for rental.
        /// </summary>
        /// <value>A car information object giving further details about the vehicle provided for rental.</value>
        [DataMember(Name="car", EmitDefaultValue=false)]
        public Vehicle Car { get; set; }

        /// <summary>
        /// Traveler identifiers to indicate the travelers to whom this car rental applies. Generally, only drivers of the vehicle will be marked in this array.
        /// </summary>
        /// <value>Traveler identifiers to indicate the travelers to whom this car rental applies. Generally, only drivers of the vehicle will be marked in this array.</value>
        [DataMember(Name="traveler_ids", EmitDefaultValue=false)]
        public List<string> TravelerIds { get; set; }

        /// <summary>
        /// Additional details the status of this car rental reservation.
        /// </summary>
        /// <value>Additional details the status of this car rental reservation.</value>
        [DataMember(Name="booking_info", EmitDefaultValue=false)]
        public CarReservationBookingInfo BookingInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarReservation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PickUp: ").Append(PickUp).Append("\n");
            sb.Append("  DropOff: ").Append(DropOff).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Car: ").Append(Car).Append("\n");
            sb.Append("  TravelerIds: ").Append(TravelerIds).Append("\n");
            sb.Append("  BookingInfo: ").Append(BookingInfo).Append("\n");
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
            return this.Equals(input as CarReservation);
        }

        /// <summary>
        /// Returns true if CarReservation instances are equal
        /// </summary>
        /// <param name="input">Instance of CarReservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarReservation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PickUp == input.PickUp ||
                    (this.PickUp != null &&
                    this.PickUp.Equals(input.PickUp))
                ) && 
                (
                    this.DropOff == input.DropOff ||
                    (this.DropOff != null &&
                    this.DropOff.Equals(input.DropOff))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Car == input.Car ||
                    (this.Car != null &&
                    this.Car.Equals(input.Car))
                ) && 
                (
                    this.TravelerIds == input.TravelerIds ||
                    this.TravelerIds != null &&
                    this.TravelerIds.SequenceEqual(input.TravelerIds)
                ) && 
                (
                    this.BookingInfo == input.BookingInfo ||
                    (this.BookingInfo != null &&
                    this.BookingInfo.Equals(input.BookingInfo))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PickUp != null)
                    hashCode = hashCode * 59 + this.PickUp.GetHashCode();
                if (this.DropOff != null)
                    hashCode = hashCode * 59 + this.DropOff.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Car != null)
                    hashCode = hashCode * 59 + this.Car.GetHashCode();
                if (this.TravelerIds != null)
                    hashCode = hashCode * 59 + this.TravelerIds.GetHashCode();
                if (this.BookingInfo != null)
                    hashCode = hashCode * 59 + this.BookingInfo.GetHashCode();
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
