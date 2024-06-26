// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The configuration parameters used for performing automatic OS upgrade. </summary>
    public partial class AutomaticOSUpgradePolicy
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

        /// <summary> Initializes a new instance of <see cref="AutomaticOSUpgradePolicy"/>. </summary>
        public AutomaticOSUpgradePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomaticOSUpgradePolicy"/>. </summary>
        /// <param name="enableAutomaticOSUpgrade"> Indicates whether OS upgrades should automatically be applied to scale set instances in a rolling fashion when a newer version of the OS image becomes available. Default value is false. If this is set to true for Windows based scale sets, [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet) is automatically set to false and cannot be set to true. </param>
        /// <param name="disableAutomaticRollback"> Whether OS image rollback feature should be disabled. Default value is false. </param>
        /// <param name="useRollingUpgradePolicy"> Indicates whether rolling upgrade policy should be used during Auto OS Upgrade. Default value is false. Auto OS Upgrade will fallback to the default policy if no policy is defined on the VMSS. </param>
        /// <param name="osRollingUpgradeDeferral"> Indicates whether Auto OS Upgrade should undergo deferral. Deferred OS upgrades will send advanced notifications on a per-VM basis that an OS upgrade from rolling upgrades is incoming, via the IMDS tag 'Platform.PendingOSUpgrade'. The upgrade then defers until the upgrade is approved via an ApproveRollingUpgrade call. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomaticOSUpgradePolicy(bool? enableAutomaticOSUpgrade, bool? disableAutomaticRollback, bool? useRollingUpgradePolicy, bool? osRollingUpgradeDeferral, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnableAutomaticOSUpgrade = enableAutomaticOSUpgrade;
            DisableAutomaticRollback = disableAutomaticRollback;
            UseRollingUpgradePolicy = useRollingUpgradePolicy;
            OSRollingUpgradeDeferral = osRollingUpgradeDeferral;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether OS upgrades should automatically be applied to scale set instances in a rolling fashion when a newer version of the OS image becomes available. Default value is false. If this is set to true for Windows based scale sets, [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet) is automatically set to false and cannot be set to true. </summary>
        public bool? EnableAutomaticOSUpgrade { get; set; }
        /// <summary> Whether OS image rollback feature should be disabled. Default value is false. </summary>
        public bool? DisableAutomaticRollback { get; set; }
        /// <summary> Indicates whether rolling upgrade policy should be used during Auto OS Upgrade. Default value is false. Auto OS Upgrade will fallback to the default policy if no policy is defined on the VMSS. </summary>
        public bool? UseRollingUpgradePolicy { get; set; }
        /// <summary> Indicates whether Auto OS Upgrade should undergo deferral. Deferred OS upgrades will send advanced notifications on a per-VM basis that an OS upgrade from rolling upgrades is incoming, via the IMDS tag 'Platform.PendingOSUpgrade'. The upgrade then defers until the upgrade is approved via an ApproveRollingUpgrade call. </summary>
        public bool? OSRollingUpgradeDeferral { get; set; }
    }
}
