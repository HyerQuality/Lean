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
    /// The status of the Price.
    /// </summary>
    /// <value>The status of the Price.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriceStatus
    {
        
        /// <summary>
        /// Enum Tradeable for "tradeable"
        /// </summary>
        [EnumMember(Value = "tradeable")]
        Tradeable,
        
        /// <summary>
        /// Enum Nontradeable for "non-tradeable"
        /// </summary>
        [EnumMember(Value = "non-tradeable")]
        Nontradeable,
        
        /// <summary>
        /// Enum Invalid for "invalid"
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid
    }

}
