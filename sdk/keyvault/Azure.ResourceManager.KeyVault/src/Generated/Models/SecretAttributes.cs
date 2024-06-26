// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The secret management attributes. </summary>
    public partial class SecretAttributes : SecretBaseAttributes
    {
        /// <summary> Initializes a new instance of <see cref="SecretAttributes"/>. </summary>
        public SecretAttributes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecretAttributes"/>. </summary>
        /// <param name="enabled"> Determines whether the object is enabled. </param>
        /// <param name="notBefore"> Not before date in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="expires"> Expiry date in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="created"> Creation time in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="updated"> Last updated time in seconds since 1970-01-01T00:00:00Z. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecretAttributes(bool? enabled, DateTimeOffset? notBefore, DateTimeOffset? expires, DateTimeOffset? created, DateTimeOffset? updated, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(enabled, notBefore, expires, created, updated, serializedAdditionalRawData)
        {
        }
    }
}
