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
using Azure.ResourceManager.AppPlatform;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformBuildResource
    {
        // BuildService_GetBuild
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BuildServiceGetBuild()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildService_GetBuild.json
            // this example is just showing the usage of "BuildService_GetBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildResource created on azure
            // for more information of creating AppPlatformBuildResource, please refer to the document of AppPlatformBuildResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            string buildName = "mybuild";
            ResourceIdentifier appPlatformBuildResourceId = AppPlatformBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName, buildName);
            AppPlatformBuildResource appPlatformBuild = client.GetAppPlatformBuildResource(appPlatformBuildResourceId);

            // invoke the operation
            AppPlatformBuildResource result = await appPlatformBuild.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformBuildData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BuildService_CreateOrUpdateBuild
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_BuildServiceCreateOrUpdateBuild()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildService_CreateOrUpdateBuild.json
            // this example is just showing the usage of "BuildService_CreateOrUpdateBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildResource created on azure
            // for more information of creating AppPlatformBuildResource, please refer to the document of AppPlatformBuildResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            string buildName = "mybuild";
            ResourceIdentifier appPlatformBuildResourceId = AppPlatformBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName, buildName);
            AppPlatformBuildResource appPlatformBuild = client.GetAppPlatformBuildResource(appPlatformBuildResourceId);

            // invoke the operation
            AppPlatformBuildData data = new AppPlatformBuildData()
            {
                Properties = new AppPlatformBuildProperties()
                {
                    RelativePath = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855-20210601-3ed9f4a2-986b-4bbd-b833-a42dccb2f777",
                    Builder = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.AppPlatform/Spring/myservice/buildServices/default/builders/default",
                    AgentPool = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.AppPlatform/Spring/myservice/buildServices/default/agentPools/default",
                    Env =
{
["environmentVariable"] = "test",
},
                    ResourceRequests = new AppPlatformBuildResourceRequirements()
                    {
                        Cpu = "1",
                        Memory = "2Gi",
                    },
                },
            };
            ArmOperation<AppPlatformBuildResource> lro = await appPlatformBuild.UpdateAsync(WaitUntil.Completed, data);
            AppPlatformBuildResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformBuildData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
