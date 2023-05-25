/*
 * Goddard iPaaS Leads API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FranchiseePortal.LeadsWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.LeadsWebApiClient.Model
{
    /// <summary>
    /// ChildLead
    /// </summary>
    [DataContract(Name = "ChildLead")]
    public partial class ChildLead : IEquatable<ChildLead>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildLead" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChildLead() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildLead" /> class.
        /// </summary>
        /// <param name="schoolChildLeadId">schoolChildLeadId.</param>
        /// <param name="dateOfBirth">dateOfBirth (required).</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        public ChildLead(long? schoolChildLeadId = default(long?), DateTime dateOfBirth = default(DateTime), string firstName = default(string), string lastName = default(string))
        {
            this.DateOfBirth = dateOfBirth;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for ChildLead and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for ChildLead and cannot be null");
            }
            this.LastName = lastName;
            this.SchoolChildLeadId = schoolChildLeadId;
        }

        /// <summary>
        /// Gets or Sets SchoolChildLeadId
        /// </summary>
        [DataMember(Name = "schoolChildLeadId", EmitDefaultValue = true)]
        public long? SchoolChildLeadId { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name = "dateOfBirth", IsRequired = true, EmitDefaultValue = false)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChildLead {\n");
            sb.Append("  SchoolChildLeadId: ").Append(SchoolChildLeadId).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChildLead);
        }

        /// <summary>
        /// Returns true if ChildLead instances are equal
        /// </summary>
        /// <param name="input">Instance of ChildLead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChildLead input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SchoolChildLeadId == input.SchoolChildLeadId ||
                    (this.SchoolChildLeadId != null &&
                    this.SchoolChildLeadId.Equals(input.SchoolChildLeadId))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
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
                if (this.SchoolChildLeadId != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolChildLeadId.GetHashCode();
                }
                if (this.DateOfBirth != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfBirth.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}