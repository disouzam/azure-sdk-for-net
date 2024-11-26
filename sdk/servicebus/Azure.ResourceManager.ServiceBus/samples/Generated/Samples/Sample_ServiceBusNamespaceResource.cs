// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ServiceBus.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusNamespaceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NameSpaceGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/SBNameSpaceGet.json
            // this example is just showing the usage of "Namespaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2924";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // invoke the operation
            ServiceBusNamespaceResource result = await serviceBusNamespace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusNamespaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NameSpaceDelete()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/SBNameSpaceDelete.json
            // this example is just showing the usage of "Namespaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3285";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // invoke the operation
            await serviceBusNamespace.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NameSpaceUpdate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/SBNameSpaceUpdate.json
            // this example is just showing the usage of "Namespaces_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3285";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // invoke the operation
            ServiceBusNamespacePatch patch = new ServiceBusNamespacePatch(new AzureLocation("South Central US"))
            {
                Tags =
{
["tag3"] = "value3",
["tag4"] = "value4"
},
            };
            ServiceBusNamespaceResource result = await serviceBusNamespace.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusNamespaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPrivateLinkResources_NameSpacePrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/PrivateLinkResourcesGet.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "subID";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2924";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // invoke the operation and iterate over the result
            await foreach (ServiceBusPrivateLinkResource item in serviceBusNamespace.GetPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckServiceBusDisasterRecoveryNameAvailability_AliasNameAvailability()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/disasterRecoveryConfigs/SBAliasCheckNameAvailability.json
            // this example is just showing the usage of "DisasterRecoveryConfigs_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "exampleSubscriptionId";
            string resourceGroupName = "exampleResourceGroup";
            string namespaceName = "sdk-Namespace-9080";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // invoke the operation
            ServiceBusNameAvailabilityContent content = new ServiceBusNameAvailabilityContent("sdk-DisasterRecovery-9474");
            ServiceBusNameAvailabilityResult result = await serviceBusNamespace.CheckServiceBusDisasterRecoveryNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
