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
    /// Message
    /// </summary>
    [DataContract]
    public partial class Message :  IEquatable<Message>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Message() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="Severity">An indicator of the importance of this message as part of the flow. May be ERROR or INFO. (required).</param>
        /// <param name="Type">An indicator of the source or type of message that has been generated. May be USER or SYSTEM. (required).</param>
        /// <param name="_Message">A free text message that provides more information. (required).</param>
        public Message(string Severity = default(string), string Type = default(string), string _Message = default(string))
        {
            // to ensure "Severity" is required (not null)
            if (Severity == null)
            {
                throw new InvalidDataException("Severity is a required property for Message and cannot be null");
            }
            else
            {
                this.Severity = Severity;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Message and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "_Message" is required (not null)
            if (_Message == null)
            {
                throw new InvalidDataException("_Message is a required property for Message and cannot be null");
            }
            else
            {
                this._Message = _Message;
            }
        }
        
        /// <summary>
        /// An indicator of the importance of this message as part of the flow. May be ERROR or INFO.
        /// </summary>
        /// <value>An indicator of the importance of this message as part of the flow. May be ERROR or INFO.</value>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public string Severity { get; set; }

        /// <summary>
        /// An indicator of the source or type of message that has been generated. May be USER or SYSTEM.
        /// </summary>
        /// <value>An indicator of the source or type of message that has been generated. May be USER or SYSTEM.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// A free text message that provides more information.
        /// </summary>
        /// <value>A free text message that provides more information.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string _Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Message: ").Append(_Message).Append("\n");
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
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="input">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this._Message == input._Message ||
                    (this._Message != null &&
                    this._Message.Equals(input._Message))
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
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this._Message != null)
                    hashCode = hashCode * 59 + this._Message.GetHashCode();
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
