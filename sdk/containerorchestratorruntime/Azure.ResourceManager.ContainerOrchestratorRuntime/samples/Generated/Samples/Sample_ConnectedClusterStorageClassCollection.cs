// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerOrchestratorRuntime.Models;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Samples
{
    public partial class Sample_ConnectedClusterStorageClassCollection
    {
        // StorageClass_Get_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StorageClassGet0()
        {
            // Generated from example definition: 2024-03-01/StorageClass_Get.json
            // this example is just showing the usage of "StorageClass_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterStorageClassResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterStorageClassCollection collection = client.GetConnectedClusterStorageClasses(scopeId);

            // invoke the operation
            string storageClassName = "testrwx";
            ConnectedClusterStorageClassResource result = await collection.GetAsync(storageClassName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectedClusterStorageClassData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageClass_Get_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_StorageClassGet0()
        {
            // Generated from example definition: 2024-03-01/StorageClass_Get.json
            // this example is just showing the usage of "StorageClass_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterStorageClassResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterStorageClassCollection collection = client.GetConnectedClusterStorageClasses(scopeId);

            // invoke the operation
            string storageClassName = "testrwx";
            bool result = await collection.ExistsAsync(storageClassName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // StorageClass_Get_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_StorageClassGet0()
        {
            // Generated from example definition: 2024-03-01/StorageClass_Get.json
            // this example is just showing the usage of "StorageClass_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterStorageClassResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterStorageClassCollection collection = client.GetConnectedClusterStorageClasses(scopeId);

            // invoke the operation
            string storageClassName = "testrwx";
            NullableResponse<ConnectedClusterStorageClassResource> response = await collection.GetIfExistsAsync(storageClassName);
            ConnectedClusterStorageClassResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectedClusterStorageClassData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // StorageClass_CreateOrUpdate_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageClassCreateOrUpdate0()
        {
            // Generated from example definition: 2024-03-01/StorageClass_CreateOrUpdate.json
            // this example is just showing the usage of "StorageClass_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterStorageClassResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterStorageClassCollection collection = client.GetConnectedClusterStorageClasses(scopeId);

            // invoke the operation
            string storageClassName = "testrwx";
            ConnectedClusterStorageClassData data = new ConnectedClusterStorageClassData()
            {
                Properties = new ConnectedClusterStorageClassProperties(new RwxStorageClassTypeProperties("default")),
            };
            ArmOperation<ConnectedClusterStorageClassResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageClassName, data);
            ConnectedClusterStorageClassResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectedClusterStorageClassData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageClass_List_0
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_StorageClassList0()
        {
            // Generated from example definition: 2024-03-01/StorageClass_List.json
            // this example is just showing the usage of "StorageClassResource_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterStorageClassResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterStorageClassCollection collection = client.GetConnectedClusterStorageClasses(scopeId);

            // invoke the operation and iterate over the result
            await foreach (ConnectedClusterStorageClassResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectedClusterStorageClassData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
