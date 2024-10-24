// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Specification for an App Service Environment to use for this resource.
/// </summary>
public partial class HostingEnvironmentProfile : ProvisionableConstruct
{
    /// <summary>
    /// Resource ID of the App Service Environment.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; set => _id.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Name of the App Service Environment.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Resource type of the App Service Environment.
    /// </summary>
    public BicepValue<ResourceType> ResourceType { get => _resourceType; }
    private readonly BicepValue<ResourceType> _resourceType;

    /// <summary>
    /// Creates a new HostingEnvironmentProfile.
    /// </summary>
    public HostingEnvironmentProfile()
    {
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"]);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _resourceType = BicepValue<ResourceType>.DefineProperty(this, "ResourceType", ["type"], isOutput: true);
    }
}
