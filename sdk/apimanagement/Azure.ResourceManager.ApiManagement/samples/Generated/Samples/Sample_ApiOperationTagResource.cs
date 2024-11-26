// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiOperationTagResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetApiOperationTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetApiOperationTag.json
            // this example is just showing the usage of "Tag_GetByOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiOperationTagResource created on azure
            // for more information of creating ApiOperationTagResource, please refer to the document of ApiOperationTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string operationId = "59d6bb8f1f7fab13dc67ec9a";
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiOperationTagResourceId = ApiOperationTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId, tagId);
            ApiOperationTagResource apiOperationTag = client.GetApiOperationTagResource(apiOperationTagResourceId);

            // invoke the operation
            ApiOperationTagResource result = await apiOperationTag.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteApiOperationTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteApiOperationTag.json
            // this example is just showing the usage of "Tag_DetachFromOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiOperationTagResource created on azure
            // for more information of creating ApiOperationTagResource, please refer to the document of ApiOperationTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d5b28d1f7fab116c282650";
            string operationId = "59d5b28d1f7fab116c282651";
            string tagId = "59d5b28e1f7fab116402044e";
            ResourceIdentifier apiOperationTagResourceId = ApiOperationTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId, tagId);
            ApiOperationTagResource apiOperationTag = client.GetApiOperationTagResource(apiOperationTagResourceId);

            // invoke the operation
            await apiOperationTag.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateApiOperationTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateApiOperationTag.json
            // this example is just showing the usage of "Tag_AssignToOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiOperationTagResource created on azure
            // for more information of creating ApiOperationTagResource, please refer to the document of ApiOperationTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5931a75ae4bbd512a88c680b";
            string operationId = "5931a75ae4bbd512a88c680a";
            string tagId = "tagId1";
            ResourceIdentifier apiOperationTagResourceId = ApiOperationTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId, tagId);
            ApiOperationTagResource apiOperationTag = client.GetApiOperationTagResource(apiOperationTagResourceId);

            // invoke the operation
            ArmOperation<ApiOperationTagResource> lro = await apiOperationTag.UpdateAsync(WaitUntil.Completed);
            ApiOperationTagResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityStateByOperation_ApiManagementHeadApiOperationTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadApiOperationTag.json
            // this example is just showing the usage of "Tag_GetEntityStateByOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiOperationTagResource created on azure
            // for more information of creating ApiOperationTagResource, please refer to the document of ApiOperationTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string operationId = "59d6bb8f1f7fab13dc67ec9a";
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiOperationTagResourceId = ApiOperationTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId, tagId);
            ApiOperationTagResource apiOperationTag = client.GetApiOperationTagResource(apiOperationTagResourceId);

            // invoke the operation
            bool result = await apiOperationTag.GetEntityStateByOperationAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
