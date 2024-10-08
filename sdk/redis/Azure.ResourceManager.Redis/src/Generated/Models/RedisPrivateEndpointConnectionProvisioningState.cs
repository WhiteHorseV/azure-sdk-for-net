// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct RedisPrivateEndpointConnectionProvisioningState : IEquatable<RedisPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static RedisPrivateEndpointConnectionProvisioningState Succeeded { get; } = new RedisPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static RedisPrivateEndpointConnectionProvisioningState Creating { get; } = new RedisPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static RedisPrivateEndpointConnectionProvisioningState Deleting { get; } = new RedisPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static RedisPrivateEndpointConnectionProvisioningState Failed { get; } = new RedisPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="RedisPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(RedisPrivateEndpointConnectionProvisioningState left, RedisPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(RedisPrivateEndpointConnectionProvisioningState left, RedisPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RedisPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator RedisPrivateEndpointConnectionProvisioningState(string value) => new RedisPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
