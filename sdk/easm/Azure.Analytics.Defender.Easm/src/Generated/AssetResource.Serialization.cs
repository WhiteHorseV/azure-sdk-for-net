// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    [PersistableModelProxy(typeof(UnknownAssetResource))]
    public partial class AssetResource : IUtf8JsonSerializable, IJsonModel<AssetResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssetResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AssetResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetResource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Uuid.HasValue)
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid.Value);
            }
            if (CreatedDate.HasValue)
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedDate.Value, "O");
            }
            if (UpdatedDate.HasValue)
            {
                writer.WritePropertyName("updatedDate"u8);
                writer.WriteStringValue(UpdatedDate.Value, "O");
            }
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (ExternalId != null)
            {
                writer.WritePropertyName("externalId"u8);
                writer.WriteStringValue(ExternalId);
            }
            if (!(Labels is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Wildcard.HasValue)
            {
                writer.WritePropertyName("wildcard"u8);
                writer.WriteBooleanValue(Wildcard.Value);
            }
            if (DiscoGroupName != null)
            {
                writer.WritePropertyName("discoGroupName"u8);
                writer.WriteStringValue(DiscoGroupName);
            }
            if (!(AuditTrail is ChangeTrackingList<AuditTrailItem> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("auditTrail"u8);
                writer.WriteStartArray();
                foreach (var item in AuditTrail)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Reason != null)
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AssetResource IJsonModel<AssetResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetResource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssetResource(document.RootElement, options);
        }

        internal static AssetResource DeserializeAssetResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "as": return AsAssetResource.DeserializeAsAssetResource(element, options);
                    case "contact": return ContactAssetResource.DeserializeContactAssetResource(element, options);
                    case "domain": return DomainAssetResource.DeserializeDomainAssetResource(element, options);
                    case "host": return HostAssetResource.DeserializeHostAssetResource(element, options);
                    case "ipAddress": return IpAddressAssetResource.DeserializeIpAddressAssetResource(element, options);
                    case "ipBlock": return IpBlockAssetResource.DeserializeIpBlockAssetResource(element, options);
                    case "page": return PageAssetResource.DeserializePageAssetResource(element, options);
                    case "sslCert": return SslCertAssetResource.DeserializeSslCertAssetResource(element, options);
                }
            }
            return UnknownAssetResource.DeserializeUnknownAssetResource(element, options);
        }

        BinaryData IPersistableModel<AssetResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssetResource)} does not support '{options.Format}' format.");
            }
        }

        AssetResource IPersistableModel<AssetResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssetResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssetResource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssetResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AssetResource FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAssetResource(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
