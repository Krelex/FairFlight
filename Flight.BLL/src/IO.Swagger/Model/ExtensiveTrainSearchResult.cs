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
    /// ExtensiveTrainSearchResult
    /// </summary>
    [DataContract]
    public partial class ExtensiveTrainSearchResult :  IEquatable<ExtensiveTrainSearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensiveTrainSearchResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtensiveTrainSearchResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensiveTrainSearchResult" /> class.
        /// </summary>
        /// <param name="Origin">Station object with details about the origin station for this search. (required).</param>
        /// <param name="Destination">Station object with details about the destination station for this search. (required).</param>
        /// <param name="Itineraries">Routes from the origin to the destination. (required).</param>
        public ExtensiveTrainSearchResult(Station Origin = default(Station), Station Destination = default(Station), List<TrainSearchItinerary> Itineraries = default(List<TrainSearchItinerary>))
        {
            // to ensure "Origin" is required (not null)
            if (Origin == null)
            {
                throw new InvalidDataException("Origin is a required property for ExtensiveTrainSearchResult and cannot be null");
            }
            else
            {
                this.Origin = Origin;
            }
            // to ensure "Destination" is required (not null)
            if (Destination == null)
            {
                throw new InvalidDataException("Destination is a required property for ExtensiveTrainSearchResult and cannot be null");
            }
            else
            {
                this.Destination = Destination;
            }
            // to ensure "Itineraries" is required (not null)
            if (Itineraries == null)
            {
                throw new InvalidDataException("Itineraries is a required property for ExtensiveTrainSearchResult and cannot be null");
            }
            else
            {
                this.Itineraries = Itineraries;
            }
        }
        
        /// <summary>
        /// Station object with details about the origin station for this search.
        /// </summary>
        /// <value>Station object with details about the origin station for this search.</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public Station Origin { get; set; }

        /// <summary>
        /// Station object with details about the destination station for this search.
        /// </summary>
        /// <value>Station object with details about the destination station for this search.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public Station Destination { get; set; }

        /// <summary>
        /// Routes from the origin to the destination.
        /// </summary>
        /// <value>Routes from the origin to the destination.</value>
        [DataMember(Name="itineraries", EmitDefaultValue=false)]
        public List<TrainSearchItinerary> Itineraries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensiveTrainSearchResult {\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Itineraries: ").Append(Itineraries).Append("\n");
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
            return this.Equals(input as ExtensiveTrainSearchResult);
        }

        /// <summary>
        /// Returns true if ExtensiveTrainSearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensiveTrainSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensiveTrainSearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Itineraries == input.Itineraries ||
                    this.Itineraries != null &&
                    this.Itineraries.SequenceEqual(input.Itineraries)
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
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Itineraries != null)
                    hashCode = hashCode * 59 + this.Itineraries.GetHashCode();
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
