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
    /// AffiliatePayout
    /// </summary>
    [DataContract]
    public partial class AffiliatePayout :  IEquatable<AffiliatePayout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliatePayout" /> class.
        /// </summary>
        /// <param name="CPC">See https://en.wikipedia.org/wiki/Pay_per_click for commission earned when the provided deep link is clicked.</param>
        /// <param name="CPA">See https://en.wikipedia.org/wiki/Cost_per_action for commission earned for a given action from the provided deep link.</param>
        /// <param name="CPS">See https://en.wikipedia.org/wiki/Pay_per_sale for commission earned as a result of a booking made from the provided deep link.</param>
        public AffiliatePayout(Amount CPC = default(Amount), Amount CPA = default(Amount), Amount CPS = default(Amount))
        {
            this.CPC = CPC;
            this.CPA = CPA;
            this.CPS = CPS;
        }
        
        /// <summary>
        /// See https://en.wikipedia.org/wiki/Pay_per_click for commission earned when the provided deep link is clicked
        /// </summary>
        /// <value>See https://en.wikipedia.org/wiki/Pay_per_click for commission earned when the provided deep link is clicked</value>
        [DataMember(Name="CPC", EmitDefaultValue=false)]
        public Amount CPC { get; set; }

        /// <summary>
        /// See https://en.wikipedia.org/wiki/Cost_per_action for commission earned for a given action from the provided deep link
        /// </summary>
        /// <value>See https://en.wikipedia.org/wiki/Cost_per_action for commission earned for a given action from the provided deep link</value>
        [DataMember(Name="CPA", EmitDefaultValue=false)]
        public Amount CPA { get; set; }

        /// <summary>
        /// See https://en.wikipedia.org/wiki/Pay_per_sale for commission earned as a result of a booking made from the provided deep link
        /// </summary>
        /// <value>See https://en.wikipedia.org/wiki/Pay_per_sale for commission earned as a result of a booking made from the provided deep link</value>
        [DataMember(Name="CPS", EmitDefaultValue=false)]
        public Amount CPS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliatePayout {\n");
            sb.Append("  CPC: ").Append(CPC).Append("\n");
            sb.Append("  CPA: ").Append(CPA).Append("\n");
            sb.Append("  CPS: ").Append(CPS).Append("\n");
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
            return this.Equals(input as AffiliatePayout);
        }

        /// <summary>
        /// Returns true if AffiliatePayout instances are equal
        /// </summary>
        /// <param name="input">Instance of AffiliatePayout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliatePayout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CPC == input.CPC ||
                    (this.CPC != null &&
                    this.CPC.Equals(input.CPC))
                ) && 
                (
                    this.CPA == input.CPA ||
                    (this.CPA != null &&
                    this.CPA.Equals(input.CPA))
                ) && 
                (
                    this.CPS == input.CPS ||
                    (this.CPS != null &&
                    this.CPS.Equals(input.CPS))
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
                if (this.CPC != null)
                    hashCode = hashCode * 59 + this.CPC.GetHashCode();
                if (this.CPA != null)
                    hashCode = hashCode * 59 + this.CPA.GetHashCode();
                if (this.CPS != null)
                    hashCode = hashCode * 59 + this.CPS.GetHashCode();
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
