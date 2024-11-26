// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.VoiceServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.VoiceServices.Samples
{
    public partial class Sample_VoiceServicesCommunicationsGatewayCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateCommunicationsGatewayResource()
        {
            // Generated from example definition: specification/voiceservices/resource-manager/Microsoft.VoiceServices/stable/2023-01-31/examples/CommunicationsGateways_CreateOrUpdate.json
            // this example is just showing the usage of "CommunicationsGateways_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VoiceServicesCommunicationsGatewayResource
            VoiceServicesCommunicationsGatewayCollection collection = resourceGroupResource.GetVoiceServicesCommunicationsGateways();

            // invoke the operation
            string communicationsGatewayName = "myname";
            VoiceServicesCommunicationsGatewayData data = new VoiceServicesCommunicationsGatewayData(new AzureLocation("useast"))
            {
                ServiceLocations = {new VoiceServicesServiceRegionProperties("useast", new VoiceServicesPrimaryRegionProperties(new string[]{"198.51.100.1"})
{
AllowedSignalingSourceAddressPrefixes = {"10.1.1.0/24"},
AllowedMediaSourceAddressPrefixes = {"10.1.2.0/24"},
}), new VoiceServicesServiceRegionProperties("useast2", new VoiceServicesPrimaryRegionProperties(new string[]{"198.51.100.2"})
{
AllowedSignalingSourceAddressPrefixes = {"10.2.1.0/24"},
AllowedMediaSourceAddressPrefixes = {"10.2.2.0/24"},
})},
                Connectivity = VoiceServicesCommunicationsGatewayConnectivity.PublicAddress,
                Codecs = { VoiceServicesTeamsCodec.Pcma },
                E911Type = VoiceServicesEmergencyCallType.Standard,
                Platforms = { VoiceServicesCommunicationsPlatform.OperatorConnect },
                AutoGeneratedDomainNameLabelScope = VoiceServicesAutoGeneratedDomainNameLabelScope.NoReuse,
                TeamsVoicemailPilotNumber = "1234567890",
            };
            ArmOperation<VoiceServicesCommunicationsGatewayResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, communicationsGatewayName, data);
            VoiceServicesCommunicationsGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VoiceServicesCommunicationsGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCommunicationsGatewayResource()
        {
            // Generated from example definition: specification/voiceservices/resource-manager/Microsoft.VoiceServices/stable/2023-01-31/examples/CommunicationsGateways_Get.json
            // this example is just showing the usage of "CommunicationsGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VoiceServicesCommunicationsGatewayResource
            VoiceServicesCommunicationsGatewayCollection collection = resourceGroupResource.GetVoiceServicesCommunicationsGateways();

            // invoke the operation
            string communicationsGatewayName = "myname";
            VoiceServicesCommunicationsGatewayResource result = await collection.GetAsync(communicationsGatewayName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VoiceServicesCommunicationsGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCommunicationsGatewayResource()
        {
            // Generated from example definition: specification/voiceservices/resource-manager/Microsoft.VoiceServices/stable/2023-01-31/examples/CommunicationsGateways_ListByResourceGroup.json
            // this example is just showing the usage of "CommunicationsGateways_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VoiceServicesCommunicationsGatewayResource
            VoiceServicesCommunicationsGatewayCollection collection = resourceGroupResource.GetVoiceServicesCommunicationsGateways();

            // invoke the operation and iterate over the result
            await foreach (VoiceServicesCommunicationsGatewayResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VoiceServicesCommunicationsGatewayData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetCommunicationsGatewayResource()
        {
            // Generated from example definition: specification/voiceservices/resource-manager/Microsoft.VoiceServices/stable/2023-01-31/examples/CommunicationsGateways_Get.json
            // this example is just showing the usage of "CommunicationsGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VoiceServicesCommunicationsGatewayResource
            VoiceServicesCommunicationsGatewayCollection collection = resourceGroupResource.GetVoiceServicesCommunicationsGateways();

            // invoke the operation
            string communicationsGatewayName = "myname";
            bool result = await collection.ExistsAsync(communicationsGatewayName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetCommunicationsGatewayResource()
        {
            // Generated from example definition: specification/voiceservices/resource-manager/Microsoft.VoiceServices/stable/2023-01-31/examples/CommunicationsGateways_Get.json
            // this example is just showing the usage of "CommunicationsGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VoiceServicesCommunicationsGatewayResource
            VoiceServicesCommunicationsGatewayCollection collection = resourceGroupResource.GetVoiceServicesCommunicationsGateways();

            // invoke the operation
            string communicationsGatewayName = "myname";
            NullableResponse<VoiceServicesCommunicationsGatewayResource> response = await collection.GetIfExistsAsync(communicationsGatewayName);
            VoiceServicesCommunicationsGatewayResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VoiceServicesCommunicationsGatewayData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
