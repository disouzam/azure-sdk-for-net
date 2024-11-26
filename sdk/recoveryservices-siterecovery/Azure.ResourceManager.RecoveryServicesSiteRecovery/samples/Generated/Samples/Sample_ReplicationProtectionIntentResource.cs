// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_ReplicationProtectionIntentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheDetailsOfAReplicationProtectionIntentItem()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationProtectionIntents_Get.json
            // this example is just showing the usage of "ReplicationProtectionIntents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReplicationProtectionIntentResource created on azure
            // for more information of creating ReplicationProtectionIntentResource, please refer to the document of ReplicationProtectionIntentResource
            string subscriptionId = "509099b2-9d2c-4636-b43e-bd5cafb6be69";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string intentObjectName = "vm1";
            ResourceIdentifier replicationProtectionIntentResourceId = ReplicationProtectionIntentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, intentObjectName);
            ReplicationProtectionIntentResource replicationProtectionIntent = client.GetReplicationProtectionIntentResource(replicationProtectionIntentResourceId);

            // invoke the operation
            ReplicationProtectionIntentResource result = await replicationProtectionIntent.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReplicationProtectionIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateProtectionIntentResource()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationProtectionIntents_Create.json
            // this example is just showing the usage of "ReplicationProtectionIntents_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReplicationProtectionIntentResource created on azure
            // for more information of creating ReplicationProtectionIntentResource, please refer to the document of ReplicationProtectionIntentResource
            string subscriptionId = "509099b2-9d2c-4636-b43e-bd5cafb6be69";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string intentObjectName = "vm1";
            ResourceIdentifier replicationProtectionIntentResourceId = ReplicationProtectionIntentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, intentObjectName);
            ReplicationProtectionIntentResource replicationProtectionIntent = client.GetReplicationProtectionIntentResource(replicationProtectionIntentResourceId);

            // invoke the operation
            ReplicationProtectionIntentCreateOrUpdateContent content = new ReplicationProtectionIntentCreateOrUpdateContent
            {
                SiteRecoveryCreateProtectionIntentProviderSpecificDetails = new A2ACreateProtectionIntentContent(
                new ResourceIdentifier("/subscriptions/509099b2-9d2c-4636-b43e-bd5cafb6be69/resourceGroups/removeOne/providers/Microsoft.Compute/virtualMachines/vmPpgAv5"),
                new AzureLocation("eastUs2"),
                new AzureLocation("westus2"),
                "ed5bcdf6-d61e-47bd-8ea9-f2bd379a2640",
                A2ARecoveryAvailabilityType.Single,
                new ResourceIdentifier("/subscriptions/509099b2-9d2c-4636-b43e-bd5cafb6be69/resourceGroups/removeOne-asr")),
            };
            ArmOperation<ReplicationProtectionIntentResource> lro = await replicationProtectionIntent.UpdateAsync(WaitUntil.Completed, content);
            ReplicationProtectionIntentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReplicationProtectionIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
