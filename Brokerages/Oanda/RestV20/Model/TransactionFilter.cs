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
    /// A filter that can be used when fetching Transactions
    /// </summary>
    /// <value>A filter that can be used when fetching Transactions</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionFilter
    {
        
        /// <summary>
        /// Enum ORDER for "ORDER"
        /// </summary>
        [EnumMember(Value = "ORDER")]
        ORDER,
        
        /// <summary>
        /// Enum FUNDING for "FUNDING"
        /// </summary>
        [EnumMember(Value = "FUNDING")]
        FUNDING,
        
        /// <summary>
        /// Enum ADMIN for "ADMIN"
        /// </summary>
        [EnumMember(Value = "ADMIN")]
        ADMIN,
        
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
        /// Enum ONECANCELSALLORDER for "ONE_CANCELS_ALL_ORDER"
        /// </summary>
        [EnumMember(Value = "ONE_CANCELS_ALL_ORDER")]
        ONECANCELSALLORDER,
        
        /// <summary>
        /// Enum ONECANCELSALLORDERREJECT for "ONE_CANCELS_ALL_ORDER_REJECT"
        /// </summary>
        [EnumMember(Value = "ONE_CANCELS_ALL_ORDER_REJECT")]
        ONECANCELSALLORDERREJECT,
        
        /// <summary>
        /// Enum ONECANCELSALLORDERTRIGGERED for "ONE_CANCELS_ALL_ORDER_TRIGGERED"
        /// </summary>
        [EnumMember(Value = "ONE_CANCELS_ALL_ORDER_TRIGGERED")]
        ONECANCELSALLORDERTRIGGERED,
        
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

}
