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
    /// TrainSearchItinerary
    /// </summary>
    [DataContract]
    public partial class TrainSearchItinerary :  IEquatable<TrainSearchItinerary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainSearchItinerary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrainSearchItinerary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainSearchItinerary" /> class.
        /// </summary>
        /// <param name="Trains">The array of trains that will be required to complete the given itinerary. Since the cache currently only contains direct itineraries, there will be only one object in this array. (required).</param>
        public TrainSearchItinerary(List<TrainSearchSegment> Trains = default(List<TrainSearchSegment>))
        {
            // to ensure "Trains" is required (not null)
            if (Trains == null)
            {
                throw new InvalidDataException("Trains is a required property for TrainSearchItinerary and cannot be null");
            }
            else
            {
                this.Trains = Trains;
            }
        }
        
        /// <summary>
        /// The array of trains that will be required to complete the given itinerary. Since the cache currently only contains direct itineraries, there will be only one object in this array.
        /// </summary>
        /// <value>The array of trains that will be required to complete the given itinerary. Since the cache currently only contains direct itineraries, there will be only one object in this array.</value>
        [DataMember(Name="trains", EmitDefaultValue=false)]
        public List<TrainSearchSegment> Trains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainSearchItinerary {\n");
            sb.Append("  Trains: ").Append(Trains).Append("\n");
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
            return this.Equals(input as TrainSearchItinerary);
        }

        /// <summary>
        /// Returns true if TrainSearchItinerary instances are equal
        /// </summary>
        /// <param name="input">Instance of TrainSearchItinerary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrainSearchItinerary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Trains == input.Trains ||
                    this.Trains != null &&
                    this.Trains.SequenceEqual(input.Trains)
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
                if (this.Trains != null)
                    hashCode = hashCode * 59 + this.Trains.GetHashCode();
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
