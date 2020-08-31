/*
 * Data Buffet API
 *
 * API access to Moody's Analytics repository of international and subnational economic and demographic time series data.  To acquire your client_id and client_secret, visit [https://www.economy.com/myeconomy/api-key-info](https://www.economy.com/myeconomy/api-key-info).  If you are not registered, you can register for a free account to retrieve your keys  For more info, see the [documentation](https://github.com/moodysanalytics/databuffet.api.codesamples/blob/master/dataBuffet-api-userguide.md#retrieve-a-single-series) 
 *
 * OpenAPI spec version: v1
 * Contact: maa@moodys.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// request body for oauth token request
    /// </summary>
    [DataContract]
    public partial class ClientCredentialsBody : IEquatable<ClientCredentialsBody>
    { 
        /// <summary>
        /// client Id
        /// </summary>
        /// <value>client Id</value>
        [DataMember(Name="client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// client client_secret
        /// </summary>
        /// <value>client client_secret</value>
        [DataMember(Name="client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// currently supported grant_type is client_credentials
        /// </summary>
        /// <value>currently supported grant_type is client_credentials</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum GrantTypeEnum
        {
            /// <summary>
            /// Enum CredentialsEnum for client_credentials
            /// </summary>
            [EnumMember(Value = "client_credentials")]
            CredentialsEnum = 0        }

        /// <summary>
        /// currently supported grant_type is client_credentials
        /// </summary>
        /// <value>currently supported grant_type is client_credentials</value>
        [DataMember(Name="grant_type")]
        public GrantTypeEnum? GrantType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientCredentialsBody {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ClientCredentialsBody)obj);
        }

        /// <summary>
        /// Returns true if ClientCredentialsBody instances are equal
        /// </summary>
        /// <param name="other">Instance of ClientCredentialsBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCredentialsBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ClientId == other.ClientId ||
                    ClientId != null &&
                    ClientId.Equals(other.ClientId)
                ) && 
                (
                    ClientSecret == other.ClientSecret ||
                    ClientSecret != null &&
                    ClientSecret.Equals(other.ClientSecret)
                ) && 
                (
                    GrantType == other.GrantType ||
                    GrantType != null &&
                    GrantType.Equals(other.GrantType)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ClientId != null)
                    hashCode = hashCode * 59 + ClientId.GetHashCode();
                    if (ClientSecret != null)
                    hashCode = hashCode * 59 + ClientSecret.GetHashCode();
                    if (GrantType != null)
                    hashCode = hashCode * 59 + GrantType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ClientCredentialsBody left, ClientCredentialsBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ClientCredentialsBody left, ClientCredentialsBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
