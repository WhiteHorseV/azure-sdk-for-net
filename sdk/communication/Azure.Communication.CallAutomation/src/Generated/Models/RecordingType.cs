// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The RecordingType. </summary>
    public readonly partial struct RecordingType : IEquatable<RecordingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecordingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecordingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcsValue = "acs";
        private const string TeamsValue = "teams";
        private const string TeamsComplianceValue = "teamsCompliance";

        /// <summary> acs. </summary>
        public static RecordingType Acs { get; } = new RecordingType(AcsValue);
        /// <summary> teams. </summary>
        public static RecordingType Teams { get; } = new RecordingType(TeamsValue);
        /// <summary> teamsCompliance. </summary>
        public static RecordingType TeamsCompliance { get; } = new RecordingType(TeamsComplianceValue);
        /// <summary> Determines if two <see cref="RecordingType"/> values are the same. </summary>
        public static bool operator ==(RecordingType left, RecordingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecordingType"/> values are not the same. </summary>
        public static bool operator !=(RecordingType left, RecordingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecordingType"/>. </summary>
        public static implicit operator RecordingType(string value) => new RecordingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecordingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecordingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
