/* 
 * OANDA v20 REST API
 *
 * The full OANDA v20 REST API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * OpenAPI spec version: 3.0.14
 * Contact: api@oanda.com
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

namespace Oanda.RestV20.Model
{
    /// <summary>
    /// The dynamic (calculated) state of a Position
    /// </summary>
    [DataContract]
    public partial class CalculatedPositionState :  IEquatable<CalculatedPositionState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatedPositionState" /> class.
        /// </summary>
        /// <param name="Instrument">The Position&#39;s Instrument..</param>
        /// <param name="NetUnrealizedPL">The Position&#39;s net unrealized profit/loss.</param>
        /// <param name="LongUnrealizedPL">The unrealized profit/loss of the Position&#39;s long open Trades.</param>
        /// <param name="ShortUnrealizedPL">The unrealized profit/loss of the Position&#39;s short open Trades.</param>
        public CalculatedPositionState(string Instrument = default(string), string NetUnrealizedPL = default(string), string LongUnrealizedPL = default(string), string ShortUnrealizedPL = default(string))
        {
            this.Instrument = Instrument;
            this.NetUnrealizedPL = NetUnrealizedPL;
            this.LongUnrealizedPL = LongUnrealizedPL;
            this.ShortUnrealizedPL = ShortUnrealizedPL;
        }
        
        /// <summary>
        /// The Position&#39;s Instrument.
        /// </summary>
        /// <value>The Position&#39;s Instrument.</value>
        [DataMember(Name="instrument", EmitDefaultValue=false)]
        public string Instrument { get; set; }
        /// <summary>
        /// The Position&#39;s net unrealized profit/loss
        /// </summary>
        /// <value>The Position&#39;s net unrealized profit/loss</value>
        [DataMember(Name="netUnrealizedPL", EmitDefaultValue=false)]
        public string NetUnrealizedPL { get; set; }
        /// <summary>
        /// The unrealized profit/loss of the Position&#39;s long open Trades
        /// </summary>
        /// <value>The unrealized profit/loss of the Position&#39;s long open Trades</value>
        [DataMember(Name="longUnrealizedPL", EmitDefaultValue=false)]
        public string LongUnrealizedPL { get; set; }
        /// <summary>
        /// The unrealized profit/loss of the Position&#39;s short open Trades
        /// </summary>
        /// <value>The unrealized profit/loss of the Position&#39;s short open Trades</value>
        [DataMember(Name="shortUnrealizedPL", EmitDefaultValue=false)]
        public string ShortUnrealizedPL { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculatedPositionState {\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  NetUnrealizedPL: ").Append(NetUnrealizedPL).Append("\n");
            sb.Append("  LongUnrealizedPL: ").Append(LongUnrealizedPL).Append("\n");
            sb.Append("  ShortUnrealizedPL: ").Append(ShortUnrealizedPL).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CalculatedPositionState);
        }

        /// <summary>
        /// Returns true if CalculatedPositionState instances are equal
        /// </summary>
        /// <param name="other">Instance of CalculatedPositionState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculatedPositionState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Instrument == other.Instrument ||
                    this.Instrument != null &&
                    this.Instrument.Equals(other.Instrument)
                ) && 
                (
                    this.NetUnrealizedPL == other.NetUnrealizedPL ||
                    this.NetUnrealizedPL != null &&
                    this.NetUnrealizedPL.Equals(other.NetUnrealizedPL)
                ) && 
                (
                    this.LongUnrealizedPL == other.LongUnrealizedPL ||
                    this.LongUnrealizedPL != null &&
                    this.LongUnrealizedPL.Equals(other.LongUnrealizedPL)
                ) && 
                (
                    this.ShortUnrealizedPL == other.ShortUnrealizedPL ||
                    this.ShortUnrealizedPL != null &&
                    this.ShortUnrealizedPL.Equals(other.ShortUnrealizedPL)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Instrument != null)
                    hash = hash * 59 + this.Instrument.GetHashCode();
                if (this.NetUnrealizedPL != null)
                    hash = hash * 59 + this.NetUnrealizedPL.GetHashCode();
                if (this.LongUnrealizedPL != null)
                    hash = hash * 59 + this.LongUnrealizedPL.GetHashCode();
                if (this.ShortUnrealizedPL != null)
                    hash = hash * 59 + this.ShortUnrealizedPL.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
