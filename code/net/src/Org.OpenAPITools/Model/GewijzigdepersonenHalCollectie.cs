/* 
 * BRP Update API
 *
 * Met deze API kun je opvragen welke door jou gevolgde personen zijn gewijzigd in de BRP. Je kunt je abonneren op een persoon die je wilt volgen, en je kunt opvragen welke personen door jou worden gevolgd. Je kunt deze API gebruiken in combinatie met de BRP bevragen API, bijvoorbeeld om lokale kopiegegevens actueel te houden.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// GewijzigdepersonenHalCollectie
    /// </summary>
    [DataContract]
    public partial class GewijzigdepersonenHalCollectie :  IEquatable<GewijzigdepersonenHalCollectie>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GewijzigdepersonenHalCollectie" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="burgerservicenummers">burgerservicenummers.</param>
        public GewijzigdepersonenHalCollectie(GewijzigdepersonenHalCollectionLinks links = default(GewijzigdepersonenHalCollectionLinks), List<string> burgerservicenummers = default(List<string>))
        {
            this.Links = links;
            this.Burgerservicenummers = burgerservicenummers;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public GewijzigdepersonenHalCollectionLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Burgerservicenummers
        /// </summary>
        [DataMember(Name="burgerservicenummers", EmitDefaultValue=false)]
        public List<string> Burgerservicenummers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GewijzigdepersonenHalCollectie {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Burgerservicenummers: ").Append(Burgerservicenummers).Append("\n");
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
            return this.Equals(input as GewijzigdepersonenHalCollectie);
        }

        /// <summary>
        /// Returns true if GewijzigdepersonenHalCollectie instances are equal
        /// </summary>
        /// <param name="input">Instance of GewijzigdepersonenHalCollectie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GewijzigdepersonenHalCollectie input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Burgerservicenummers == input.Burgerservicenummers ||
                    this.Burgerservicenummers != null &&
                    input.Burgerservicenummers != null &&
                    this.Burgerservicenummers.SequenceEqual(input.Burgerservicenummers)
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Burgerservicenummers != null)
                    hashCode = hashCode * 59 + this.Burgerservicenummers.GetHashCode();
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
