// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The type of the action to take to perform the health check. </summary>
    internal readonly partial struct ProbeActionType : IEquatable<ProbeActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProbeActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProbeActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpGetActionValue = "HTTPGetAction";
        private const string TCPSocketActionValue = "TCPSocketAction";
        private const string ExecActionValue = "ExecAction";

        /// <summary> HTTPGetAction. </summary>
        public static ProbeActionType HttpGetAction { get; } = new ProbeActionType(HttpGetActionValue);
        /// <summary> TCPSocketAction. </summary>
        public static ProbeActionType TCPSocketAction { get; } = new ProbeActionType(TCPSocketActionValue);
        /// <summary> ExecAction. </summary>
        public static ProbeActionType ExecAction { get; } = new ProbeActionType(ExecActionValue);
        /// <summary> Determines if two <see cref="ProbeActionType"/> values are the same. </summary>
        public static bool operator ==(ProbeActionType left, ProbeActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProbeActionType"/> values are not the same. </summary>
        public static bool operator !=(ProbeActionType left, ProbeActionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ProbeActionType"/>. </summary>
        public static implicit operator ProbeActionType(string value) => new ProbeActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProbeActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProbeActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
