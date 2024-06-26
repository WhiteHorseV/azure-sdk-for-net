// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The retention details of the MT. </summary>
    public partial class SiteRecoveryRetentionVolume
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRetentionVolume"/>. </summary>
        internal SiteRecoveryRetentionVolume()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRetentionVolume"/>. </summary>
        /// <param name="volumeName"> The volume name. </param>
        /// <param name="capacityInBytes"> The volume capacity. </param>
        /// <param name="freeSpaceInBytes"> The free space available in this volume. </param>
        /// <param name="thresholdPercentage"> The threshold percentage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryRetentionVolume(string volumeName, long? capacityInBytes, long? freeSpaceInBytes, int? thresholdPercentage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VolumeName = volumeName;
            CapacityInBytes = capacityInBytes;
            FreeSpaceInBytes = freeSpaceInBytes;
            ThresholdPercentage = thresholdPercentage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The volume name. </summary>
        public string VolumeName { get; }
        /// <summary> The volume capacity. </summary>
        public long? CapacityInBytes { get; }
        /// <summary> The free space available in this volume. </summary>
        public long? FreeSpaceInBytes { get; }
        /// <summary> The threshold percentage. </summary>
        public int? ThresholdPercentage { get; }
    }
}
