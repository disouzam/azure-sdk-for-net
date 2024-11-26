// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AgFoodPlatform.Models;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AgFoodPlatform.Samples
{
    public partial class Sample_FarmBeatResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_FarmBeatsModelsGet()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/FarmBeatsModels_Get.json
            // this example is just showing the usage of "FarmBeatsModels_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmBeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // invoke the operation
            FarmBeatResource result = await farmBeat.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FarmBeatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_FarmBeatsModelsDelete()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/FarmBeatsModels_Delete.json
            // this example is just showing the usage of "FarmBeatsModels_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmBeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // invoke the operation
            await farmBeat.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_FarmBeatsModelsUpdate()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/FarmBeatsModels_Update.json
            // this example is just showing the usage of "FarmBeatsModels_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmBeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // invoke the operation
            FarmBeatPatch patch = new FarmBeatPatch
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2"
},
            };
            ArmOperation<FarmBeatResource> lro = await farmBeat.UpdateAsync(WaitUntil.Completed, patch);
            FarmBeatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FarmBeatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_FarmBeatsModelsUpdateWithSensor()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/FarmBeatsModels_UpdateWithSensor.json
            // this example is just showing the usage of "FarmBeatsModels_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmBeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // invoke the operation
            FarmBeatPatch patch = new FarmBeatPatch
            {
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Properties = new FarmBeatsUpdateProperties
                {
                    SensorIntegration = new SensorIntegration
                    {
                        Enabled = "True",
                    },
                },
                Tags =
{
["key1"] = "value1",
["key2"] = "value2"
},
            };
            ArmOperation<FarmBeatResource> lro = await farmBeat.UpdateAsync(WaitUntil.Completed, patch);
            FarmBeatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FarmBeatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetOperationResult_FarmBeatsModelsGetOperationResult()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/FarmBeatsModels_GetOperationResult.json
            // this example is just showing the usage of "FarmBeatsModels_GetOperationResult" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmBeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // invoke the operation
            string operationResultsId = "resource-provisioning-id-farmBeatsResourceName";
            ArmAsyncOperation result = await farmBeat.GetOperationResultAsync(operationResultsId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
