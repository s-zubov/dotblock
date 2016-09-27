﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SignRawTransactionInput.cs" company="Dark Caesium">
//   Copyright (c) Dark Caesium.  All rights reserved.
//   THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>
// <summary>
//   The sign raw transaction input.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blockchain.Protocol.Bitcoin.Client.Types
{
    #region Using Directives

    using Newtonsoft.Json;

    #endregion

    /// <summary>
    /// The sign raw transaction input.
    /// </summary>
    public class SignRawTransactionInput
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the output.
        /// </summary>
        [JsonProperty("vout")]
        public int Output { get; set; }

        /// <summary>
        /// Gets or sets the script pub key.
        /// </summary>
        [JsonProperty("scriptPubKey")]
        public string ScriptPubKey { get; set; }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        [JsonProperty("txid")]
        public string TransactionId { get; set; }

        #endregion
    }
}