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
    /// A TradeClientExtensionsModifyTransaction represents the modification of a Trade&#39;s Client Extensions.
    /// </summary>
    [DataContract]
    public partial class TradeClientExtensionsModifyTransaction :  IEquatable<TradeClientExtensionsModifyTransaction>, IValidatableObject
    {
        /// <summary>
        /// The Type of the Transaction. Always set to \"TRADE_CLIENT_EXTENSIONS_MODIFY\" for a TradeClientExtensionsModifyTransaction.
        /// </summary>
        /// <value>The Type of the Transaction. Always set to \"TRADE_CLIENT_EXTENSIONS_MODIFY\" for a TradeClientExtensionsModifyTransaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum CREATE for "CREATE"
            /// </summary>
            [EnumMember(Value = "CREATE")]
            CREATE,
            
            /// <summary>
            /// Enum CLOSE for "CLOSE"
            /// </summary>
            [EnumMember(Value = "CLOSE")]
            CLOSE,
            
            /// <summary>
            /// Enum REOPEN for "REOPEN"
            /// </summary>
            [EnumMember(Value = "REOPEN")]
            REOPEN,
            
            /// <summary>
            /// Enum CLIENTCONFIGURE for "CLIENT_CONFIGURE"
            /// </summary>
            [EnumMember(Value = "CLIENT_CONFIGURE")]
            CLIENTCONFIGURE,
            
            /// <summary>
            /// Enum CLIENTCONFIGUREREJECT for "CLIENT_CONFIGURE_REJECT"
            /// </summary>
            [EnumMember(Value = "CLIENT_CONFIGURE_REJECT")]
            CLIENTCONFIGUREREJECT,
            
            /// <summary>
            /// Enum TRANSFERFUNDS for "TRANSFER_FUNDS"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FUNDS")]
            TRANSFERFUNDS,
            
            /// <summary>
            /// Enum TRANSFERFUNDSREJECT for "TRANSFER_FUNDS_REJECT"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FUNDS_REJECT")]
            TRANSFERFUNDSREJECT,
            
            /// <summary>
            /// Enum MARKETORDER for "MARKET_ORDER"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER")]
            MARKETORDER,
            
            /// <summary>
            /// Enum MARKETORDERREJECT for "MARKET_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "MARKET_ORDER_REJECT")]
            MARKETORDERREJECT,
            
            /// <summary>
            /// Enum LIMITORDER for "LIMIT_ORDER"
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER")]
            LIMITORDER,
            
            /// <summary>
            /// Enum LIMITORDERREJECT for "LIMIT_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "LIMIT_ORDER_REJECT")]
            LIMITORDERREJECT,
            
            /// <summary>
            /// Enum STOPORDER for "STOP_ORDER"
            /// </summary>
            [EnumMember(Value = "STOP_ORDER")]
            STOPORDER,
            
            /// <summary>
            /// Enum STOPORDERREJECT for "STOP_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "STOP_ORDER_REJECT")]
            STOPORDERREJECT,
            
            /// <summary>
            /// Enum MARKETIFTOUCHEDORDER for "MARKET_IF_TOUCHED_ORDER"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER")]
            MARKETIFTOUCHEDORDER,
            
            /// <summary>
            /// Enum MARKETIFTOUCHEDORDERREJECT for "MARKET_IF_TOUCHED_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "MARKET_IF_TOUCHED_ORDER_REJECT")]
            MARKETIFTOUCHEDORDERREJECT,
            
            /// <summary>
            /// Enum TAKEPROFITORDER for "TAKE_PROFIT_ORDER"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER")]
            TAKEPROFITORDER,
            
            /// <summary>
            /// Enum TAKEPROFITORDERREJECT for "TAKE_PROFIT_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "TAKE_PROFIT_ORDER_REJECT")]
            TAKEPROFITORDERREJECT,
            
            /// <summary>
            /// Enum STOPLOSSORDER for "STOP_LOSS_ORDER"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER")]
            STOPLOSSORDER,
            
            /// <summary>
            /// Enum STOPLOSSORDERREJECT for "STOP_LOSS_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "STOP_LOSS_ORDER_REJECT")]
            STOPLOSSORDERREJECT,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDER for "TRAILING_STOP_LOSS_ORDER"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER")]
            TRAILINGSTOPLOSSORDER,
            
            /// <summary>
            /// Enum TRAILINGSTOPLOSSORDERREJECT for "TRAILING_STOP_LOSS_ORDER_REJECT"
            /// </summary>
            [EnumMember(Value = "TRAILING_STOP_LOSS_ORDER_REJECT")]
            TRAILINGSTOPLOSSORDERREJECT,
            
            /// <summary>
            /// Enum ORDERFILL for "ORDER_FILL"
            /// </summary>
            [EnumMember(Value = "ORDER_FILL")]
            ORDERFILL,
            
            /// <summary>
            /// Enum ORDERCANCEL for "ORDER_CANCEL"
            /// </summary>
            [EnumMember(Value = "ORDER_CANCEL")]
            ORDERCANCEL,
            
            /// <summary>
            /// Enum ORDERCANCELREJECT for "ORDER_CANCEL_REJECT"
            /// </summary>
            [EnumMember(Value = "ORDER_CANCEL_REJECT")]
            ORDERCANCELREJECT,
            
            /// <summary>
            /// Enum ORDERCLIENTEXTENSIONSMODIFY for "ORDER_CLIENT_EXTENSIONS_MODIFY"
            /// </summary>
            [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY")]
            ORDERCLIENTEXTENSIONSMODIFY,
            
            /// <summary>
            /// Enum ORDERCLIENTEXTENSIONSMODIFYREJECT for "ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT"
            /// </summary>
            [EnumMember(Value = "ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT")]
            ORDERCLIENTEXTENSIONSMODIFYREJECT,
            
            /// <summary>
            /// Enum TRADECLIENTEXTENSIONSMODIFY for "TRADE_CLIENT_EXTENSIONS_MODIFY"
            /// </summary>
            [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY")]
            TRADECLIENTEXTENSIONSMODIFY,
            
            /// <summary>
            /// Enum TRADECLIENTEXTENSIONSMODIFYREJECT for "TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT"
            /// </summary>
            [EnumMember(Value = "TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT")]
            TRADECLIENTEXTENSIONSMODIFYREJECT,
            
            /// <summary>
            /// Enum MARGINCALLENTER for "MARGIN_CALL_ENTER"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_ENTER")]
            MARGINCALLENTER,
            
            /// <summary>
            /// Enum MARGINCALLEXTEND for "MARGIN_CALL_EXTEND"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_EXTEND")]
            MARGINCALLEXTEND,
            
            /// <summary>
            /// Enum MARGINCALLEXIT for "MARGIN_CALL_EXIT"
            /// </summary>
            [EnumMember(Value = "MARGIN_CALL_EXIT")]
            MARGINCALLEXIT,
            
            /// <summary>
            /// Enum DELAYEDTRADECLOSURE for "DELAYED_TRADE_CLOSURE"
            /// </summary>
            [EnumMember(Value = "DELAYED_TRADE_CLOSURE")]
            DELAYEDTRADECLOSURE,
            
            /// <summary>
            /// Enum DAILYFINANCING for "DAILY_FINANCING"
            /// </summary>
            [EnumMember(Value = "DAILY_FINANCING")]
            DAILYFINANCING,
            
            /// <summary>
            /// Enum RESETRESETTABLEPL for "RESET_RESETTABLE_PL"
            /// </summary>
            [EnumMember(Value = "RESET_RESETTABLE_PL")]
            RESETRESETTABLEPL
        }

        /// <summary>
        /// The Type of the Transaction. Always set to \"TRADE_CLIENT_EXTENSIONS_MODIFY\" for a TradeClientExtensionsModifyTransaction.
        /// </summary>
        /// <value>The Type of the Transaction. Always set to \"TRADE_CLIENT_EXTENSIONS_MODIFY\" for a TradeClientExtensionsModifyTransaction.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeClientExtensionsModifyTransaction" /> class.
        /// </summary>
        /// <param name="Id">The Transaction&#39;s Identifier..</param>
        /// <param name="Time">The date/time when the Transaction was created..</param>
        /// <param name="UserID">The ID of the user that initiated the creation of the Transaction..</param>
        /// <param name="AccountID">The ID of the Account the Transaction was created for..</param>
        /// <param name="BatchID">The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously..</param>
        /// <param name="Type">The Type of the Transaction. Always set to \&quot;TRADE_CLIENT_EXTENSIONS_MODIFY\&quot; for a TradeClientExtensionsModifyTransaction..</param>
        /// <param name="TradeID">The ID of the Trade who&#39;s client extensions are to be modified..</param>
        /// <param name="ClientTradeID">The original Client ID of the Trade who&#39;s client extensions are to be modified..</param>
        /// <param name="TradeClientExtensionsModify">The new Client Extensions for the Trade..</param>
        public TradeClientExtensionsModifyTransaction(string Id = default(string), string Time = default(string), int? UserID = default(int?), string AccountID = default(string), string BatchID = default(string), TypeEnum? Type = default(TypeEnum?), string TradeID = default(string), string ClientTradeID = default(string), ClientExtensions TradeClientExtensionsModify = default(ClientExtensions))
        {
            this.Id = Id;
            this.Time = Time;
            this.UserID = UserID;
            this.AccountID = AccountID;
            this.BatchID = BatchID;
            this.Type = Type;
            this.TradeID = TradeID;
            this.ClientTradeID = ClientTradeID;
            this.TradeClientExtensionsModify = TradeClientExtensionsModify;
        }
        
        /// <summary>
        /// The Transaction&#39;s Identifier.
        /// </summary>
        /// <value>The Transaction&#39;s Identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The date/time when the Transaction was created.
        /// </summary>
        /// <value>The date/time when the Transaction was created.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }
        /// <summary>
        /// The ID of the user that initiated the creation of the Transaction.
        /// </summary>
        /// <value>The ID of the user that initiated the creation of the Transaction.</value>
        [DataMember(Name="userID", EmitDefaultValue=false)]
        public int? UserID { get; set; }
        /// <summary>
        /// The ID of the Account the Transaction was created for.
        /// </summary>
        /// <value>The ID of the Account the Transaction was created for.</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public string AccountID { get; set; }
        /// <summary>
        /// The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.
        /// </summary>
        /// <value>The ID of the \&quot;batch\&quot; that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.</value>
        [DataMember(Name="batchID", EmitDefaultValue=false)]
        public string BatchID { get; set; }
        /// <summary>
        /// The ID of the Trade who&#39;s client extensions are to be modified.
        /// </summary>
        /// <value>The ID of the Trade who&#39;s client extensions are to be modified.</value>
        [DataMember(Name="tradeID", EmitDefaultValue=false)]
        public string TradeID { get; set; }
        /// <summary>
        /// The original Client ID of the Trade who&#39;s client extensions are to be modified.
        /// </summary>
        /// <value>The original Client ID of the Trade who&#39;s client extensions are to be modified.</value>
        [DataMember(Name="clientTradeID", EmitDefaultValue=false)]
        public string ClientTradeID { get; set; }
        /// <summary>
        /// The new Client Extensions for the Trade.
        /// </summary>
        /// <value>The new Client Extensions for the Trade.</value>
        [DataMember(Name="tradeClientExtensionsModify", EmitDefaultValue=false)]
        public ClientExtensions TradeClientExtensionsModify { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeClientExtensionsModifyTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  BatchID: ").Append(BatchID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TradeID: ").Append(TradeID).Append("\n");
            sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
            sb.Append("  TradeClientExtensionsModify: ").Append(TradeClientExtensionsModify).Append("\n");
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
            return this.Equals(obj as TradeClientExtensionsModifyTransaction);
        }

        /// <summary>
        /// Returns true if TradeClientExtensionsModifyTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of TradeClientExtensionsModifyTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeClientExtensionsModifyTransaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.UserID == other.UserID ||
                    this.UserID != null &&
                    this.UserID.Equals(other.UserID)
                ) && 
                (
                    this.AccountID == other.AccountID ||
                    this.AccountID != null &&
                    this.AccountID.Equals(other.AccountID)
                ) && 
                (
                    this.BatchID == other.BatchID ||
                    this.BatchID != null &&
                    this.BatchID.Equals(other.BatchID)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.TradeID == other.TradeID ||
                    this.TradeID != null &&
                    this.TradeID.Equals(other.TradeID)
                ) && 
                (
                    this.ClientTradeID == other.ClientTradeID ||
                    this.ClientTradeID != null &&
                    this.ClientTradeID.Equals(other.ClientTradeID)
                ) && 
                (
                    this.TradeClientExtensionsModify == other.TradeClientExtensionsModify ||
                    this.TradeClientExtensionsModify != null &&
                    this.TradeClientExtensionsModify.Equals(other.TradeClientExtensionsModify)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.UserID != null)
                    hash = hash * 59 + this.UserID.GetHashCode();
                if (this.AccountID != null)
                    hash = hash * 59 + this.AccountID.GetHashCode();
                if (this.BatchID != null)
                    hash = hash * 59 + this.BatchID.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.TradeID != null)
                    hash = hash * 59 + this.TradeID.GetHashCode();
                if (this.ClientTradeID != null)
                    hash = hash * 59 + this.ClientTradeID.GetHashCode();
                if (this.TradeClientExtensionsModify != null)
                    hash = hash * 59 + this.TradeClientExtensionsModify.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
