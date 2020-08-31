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
    /// contains token information
    /// </summary>
    [DataContract]
    public partial class OAuthSuccess : IEquatable<OAuthSuccess>
    { 
        /// <summary>
        /// token type
        /// </summary>
        /// <value>token type</value>
        [DataMember(Name="token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// access token
        /// </summary>
        /// <value>access token</value>
        [DataMember(Name="access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// time to expiry
        /// </summary>
        /// <value>time to expiry</value>
        [DataMember(Name="expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuthSuccess {\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OAuthSuccess)obj);
        }

        /// <summary>
        /// Returns true if OAuthSuccess instances are equal
        /// </summary>
        /// <param name="other">Instance of OAuthSuccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthSuccess other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TokenType == other.TokenType ||
                    TokenType != null &&
                    TokenType.Equals(other.TokenType)
                ) && 
                (
                    AccessToken == other.AccessToken ||
                    AccessToken != null &&
                    AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    ExpiresIn == other.ExpiresIn ||
                    ExpiresIn != null &&
                    ExpiresIn.Equals(other.ExpiresIn)
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
                    if (TokenType != null)
                    hashCode = hashCode * 59 + TokenType.GetHashCode();
                    if (AccessToken != null)
                    hashCode = hashCode * 59 + AccessToken.GetHashCode();
                    if (ExpiresIn != null)
                    hashCode = hashCode * 59 + ExpiresIn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OAuthSuccess left, OAuthSuccess right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OAuthSuccess left, OAuthSuccess right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
