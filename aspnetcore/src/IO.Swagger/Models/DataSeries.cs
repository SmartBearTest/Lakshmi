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
    /// 
    /// </summary>
    [DataContract]
    public partial class DataSeries : IEquatable<DataSeries>
    { 
        /// <summary>
        /// Gets or Sets Freq
        /// </summary>
        [DataMember(Name="freq")]
        public string Freq { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets FreqCode
        /// </summary>
        [DataMember(Name="freqCode")]
        public int? FreqCode { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start")]
        public int? Start { get; set; }

        /// <summary>
        /// Gets or Sets Periods
        /// </summary>
        [DataMember(Name="periods")]
        public int? Periods { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data")]
        public List<double?> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSeries {\n");
            sb.Append("  Freq: ").Append(Freq).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  FreqCode: ").Append(FreqCode).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Periods: ").Append(Periods).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DataSeries)obj);
        }

        /// <summary>
        /// Returns true if DataSeries instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSeries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSeries other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Freq == other.Freq ||
                    Freq != null &&
                    Freq.Equals(other.Freq)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    FreqCode == other.FreqCode ||
                    FreqCode != null &&
                    FreqCode.Equals(other.FreqCode)
                ) && 
                (
                    Start == other.Start ||
                    Start != null &&
                    Start.Equals(other.Start)
                ) && 
                (
                    Periods == other.Periods ||
                    Periods != null &&
                    Periods.Equals(other.Periods)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.SequenceEqual(other.Data)
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
                    if (Freq != null)
                    hashCode = hashCode * 59 + Freq.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (FreqCode != null)
                    hashCode = hashCode * 59 + FreqCode.GetHashCode();
                    if (Start != null)
                    hashCode = hashCode * 59 + Start.GetHashCode();
                    if (Periods != null)
                    hashCode = hashCode * 59 + Periods.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DataSeries left, DataSeries right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DataSeries left, DataSeries right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
