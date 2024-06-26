// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> Bulk import result. </summary>
    public partial class BulkImportResult
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

        /// <summary> Initializes a new instance of <see cref="BulkImportResult"/>. </summary>
        internal BulkImportResult()
        {
            FailedImportInfoList = new ChangeTrackingList<ImportInfo>();
            SuccessImportInfoList = new ChangeTrackingList<ImportInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="BulkImportResult"/>. </summary>
        /// <param name="failedImportInfoList"> failed importInfoList. </param>
        /// <param name="successImportInfoList"> successful importInfoList. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BulkImportResult(IReadOnlyList<ImportInfo> failedImportInfoList, IReadOnlyList<ImportInfo> successImportInfoList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FailedImportInfoList = failedImportInfoList;
            SuccessImportInfoList = successImportInfoList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> failed importInfoList. </summary>
        public IReadOnlyList<ImportInfo> FailedImportInfoList { get; }
        /// <summary> successful importInfoList. </summary>
        public IReadOnlyList<ImportInfo> SuccessImportInfoList { get; }
    }
}
