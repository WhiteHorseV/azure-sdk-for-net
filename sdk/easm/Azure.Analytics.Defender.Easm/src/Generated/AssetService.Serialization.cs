// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class AssetService : IUtf8JsonSerializable, IJsonModel<AssetService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssetService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AssetService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Scheme != null)
            {
                writer.WritePropertyName("scheme"u8);
                writer.WriteStringValue(Scheme);
            }
            if (Port.HasValue)
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (!(WebComponents is ChangeTrackingList<WebComponent> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("webComponents"u8);
                writer.WriteStartArray();
                foreach (var item in WebComponents)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(SslCerts is ChangeTrackingList<SslCertAsset> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("sslCerts"u8);
                writer.WriteStartArray();
                foreach (var item in SslCerts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Exceptions is ChangeTrackingList<ObservedString> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("exceptions"u8);
                writer.WriteStartArray();
                foreach (var item in Exceptions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Sources is ChangeTrackingList<SourceDetails> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (FirstSeen.HasValue)
            {
                writer.WritePropertyName("firstSeen"u8);
                writer.WriteStringValue(FirstSeen.Value, "O");
            }
            if (LastSeen.HasValue)
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeen.Value, "O");
            }
            if (Count.HasValue)
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Recent.HasValue)
            {
                writer.WritePropertyName("recent"u8);
                writer.WriteBooleanValue(Recent.Value);
            }
            if (!(PortStates is ChangeTrackingList<ObservedPortState> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("portStates"u8);
                writer.WriteStartArray();
                foreach (var item in PortStates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AssetService IJsonModel<AssetService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssetService(document.RootElement, options);
        }

        internal static AssetService DeserializeAssetService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scheme = default;
            int? port = default;
            IReadOnlyList<WebComponent> webComponents = default;
            IReadOnlyList<SslCertAsset> sslCerts = default;
            IReadOnlyList<ObservedString> exceptions = default;
            IReadOnlyList<SourceDetails> sources = default;
            DateTimeOffset? firstSeen = default;
            DateTimeOffset? lastSeen = default;
            long? count = default;
            bool? recent = default;
            IReadOnlyList<ObservedPortState> portStates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheme"u8))
                {
                    scheme = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("webComponents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebComponent> array = new List<WebComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebComponent.DeserializeWebComponent(item, options));
                    }
                    webComponents = array;
                    continue;
                }
                if (property.NameEquals("sslCerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SslCertAsset> array = new List<SslCertAsset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SslCertAsset.DeserializeSslCertAsset(item, options));
                    }
                    sslCerts = array;
                    continue;
                }
                if (property.NameEquals("exceptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    exceptions = array;
                    continue;
                }
                if (property.NameEquals("sources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SourceDetails> array = new List<SourceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SourceDetails.DeserializeSourceDetails(item, options));
                    }
                    sources = array;
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("portStates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedPortState> array = new List<ObservedPortState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedPortState.DeserializeObservedPortState(item, options));
                    }
                    portStates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AssetService(
                scheme,
                port,
                webComponents ?? new ChangeTrackingList<WebComponent>(),
                sslCerts ?? new ChangeTrackingList<SslCertAsset>(),
                exceptions ?? new ChangeTrackingList<ObservedString>(),
                sources ?? new ChangeTrackingList<SourceDetails>(),
                firstSeen,
                lastSeen,
                count,
                recent,
                portStates ?? new ChangeTrackingList<ObservedPortState>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssetService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssetService)} does not support '{options.Format}' format.");
            }
        }

        AssetService IPersistableModel<AssetService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssetService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssetService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssetService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AssetService FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAssetService(document.RootElement);
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
