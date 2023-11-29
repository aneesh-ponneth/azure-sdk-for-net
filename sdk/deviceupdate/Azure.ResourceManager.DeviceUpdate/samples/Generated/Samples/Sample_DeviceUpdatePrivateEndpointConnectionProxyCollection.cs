// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceUpdate;
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate.Samples
{
    public partial class Sample_DeviceUpdatePrivateEndpointConnectionProxyCollection
    {
        // PrivateEndpointConnectionProxyList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateEndpointConnectionProxyList()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateEndpointConnectionProxies/PrivateEndpointConnectionProxy_ListByAccount.json
            // this example is just showing the usage of "PrivateEndpointConnectionProxies_ListByAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateEndpointConnectionProxyResource
            DeviceUpdatePrivateEndpointConnectionProxyCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateEndpointConnectionProxies();

            // invoke the operation and iterate over the result
            await foreach (DeviceUpdatePrivateEndpointConnectionProxyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceUpdatePrivateEndpointConnectionProxyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateEndpointConnectionProxyGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionProxyGet()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateEndpointConnectionProxies/PrivateEndpointConnectionProxy_Get.json
            // this example is just showing the usage of "PrivateEndpointConnectionProxies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateEndpointConnectionProxyResource
            DeviceUpdatePrivateEndpointConnectionProxyCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateEndpointConnectionProxies();

            // invoke the operation
            string privateEndpointConnectionProxyId = "peexample01";
            DeviceUpdatePrivateEndpointConnectionProxyResource result = await collection.GetAsync(privateEndpointConnectionProxyId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceUpdatePrivateEndpointConnectionProxyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnectionProxyGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateEndpointConnectionProxyGet()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateEndpointConnectionProxies/PrivateEndpointConnectionProxy_Get.json
            // this example is just showing the usage of "PrivateEndpointConnectionProxies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateEndpointConnectionProxyResource
            DeviceUpdatePrivateEndpointConnectionProxyCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateEndpointConnectionProxies();

            // invoke the operation
            string privateEndpointConnectionProxyId = "peexample01";
            bool result = await collection.ExistsAsync(privateEndpointConnectionProxyId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateEndpointConnectionProxyGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateEndpointConnectionProxyGet()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateEndpointConnectionProxies/PrivateEndpointConnectionProxy_Get.json
            // this example is just showing the usage of "PrivateEndpointConnectionProxies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateEndpointConnectionProxyResource
            DeviceUpdatePrivateEndpointConnectionProxyCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateEndpointConnectionProxies();

            // invoke the operation
            string privateEndpointConnectionProxyId = "peexample01";
            NullableResponse<DeviceUpdatePrivateEndpointConnectionProxyResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionProxyId);
            DeviceUpdatePrivateEndpointConnectionProxyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceUpdatePrivateEndpointConnectionProxyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateEndpointConnectionProxyCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateEndpointConnectionProxyCreateOrUpdate()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateEndpointConnectionProxies/PrivateEndpointConnectionProxy_CreateOrUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnectionProxies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateEndpointConnectionProxyResource
            DeviceUpdatePrivateEndpointConnectionProxyCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateEndpointConnectionProxies();

            // invoke the operation
            string privateEndpointConnectionProxyId = "peexample01";
            DeviceUpdatePrivateEndpointConnectionProxyData data = new DeviceUpdatePrivateEndpointConnectionProxyData()
            {
                RemotePrivateEndpoint = new DeviceUpdateRemotePrivateEndpoint()
                {
                    Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Network/privateEndpoints/{peName}"),
                    Location = new AzureLocation("westus2"),
                    ImmutableSubscriptionId = "00000000-0000-0000-0000-000000000000",
                    ImmutableResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Network/privateEndpoints/{peName}"),
                    ManualPrivateLinkServiceConnections =
{
new DeviceUpdatePrivateLinkServiceConnection()
{
Name = "{privateEndpointConnectionProxyId}",
GroupIds =
{
"DeviceUpdate"
},
RequestMessage = "Please approve my connection, thanks.",
}
},
                    PrivateLinkServiceProxies =
{
new DeviceUpdatePrivateLinkServiceProxy()
{
Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Network/privateEndpoints/{privateEndpointConnectionProxyId}/privateLinkServiceProxies/{privateEndpointConnectionProxyId}"),
GroupConnectivityInformation =
{
},
}
},
                },
            };
            ArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionProxyId, data);
            DeviceUpdatePrivateEndpointConnectionProxyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceUpdatePrivateEndpointConnectionProxyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
