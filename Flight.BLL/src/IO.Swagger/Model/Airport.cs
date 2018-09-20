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
    /// Airport
    /// </summary>
    [DataContract]
    public partial class Airport :  IEquatable<Airport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Airport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Airport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Airport" /> class.
        /// </summary>
        /// <param name="_Airport">The 3 character &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA airport code&lt;/a&gt; of the airport in question for this flight (required).</param>
        /// <param name="Terminal">The terminal identifier at which this flight will arrive or depart in the given airport.</param>
        public Airport(string _Airport = default(string), string Terminal = default(string))
        {
            // to ensure "_Airport" is required (not null)
            if (_Airport == null)
            {
                throw new InvalidDataException("_Airport is a required property for Airport and cannot be null");
            }
            else
            {
                this._Airport = _Airport;
            }
            this.Terminal = Terminal;
        }
        
        /// <summary>
        /// The 3 character &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA airport code&lt;/a&gt; of the airport in question for this flight
        /// </summary>
        /// <value>The 3 character &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA airport code&lt;/a&gt; of the airport in question for this flight</value>
        [DataMember(Name="airport", EmitDefaultValue=false)]
        public string _Airport { get; set; }

        /// <summary>
        /// The terminal identifier at which this flight will arrive or depart in the given airport
        /// </summary>
        /// <value>The terminal identifier at which this flight will arrive or depart in the given airport</value>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public string Terminal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Airport {\n");
            sb.Append("  _Airport: ").Append(_Airport).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
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
            return this.Equals(input as Airport);
        }

        /// <summary>
        /// Returns true if Airport instances are equal
        /// </summary>
        /// <param name="input">Instance of Airport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Airport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Airport == input._Airport ||
                    (this._Airport != null &&
                    this._Airport.Equals(input._Airport))
                ) && 
                (
                    this.Terminal == input.Terminal ||
                    (this.Terminal != null &&
                    this.Terminal.Equals(input.Terminal))
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
                if (this._Airport != null)
                    hashCode = hashCode * 59 + this._Airport.GetHashCode();
                if (this.Terminal != null)
                    hashCode = hashCode * 59 + this.Terminal.GetHashCode();
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
