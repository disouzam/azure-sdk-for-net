// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Quota.Samples
{
    public partial class Sample_QuotaRequestDetailCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuotaRequestFailed()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusFailed.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            QuotaRequestDetailResource result = await collection.GetAsync(id);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QuotaRequestDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuotaRequestInProgress()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusInProgress.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            QuotaRequestDetailResource result = await collection.GetAsync(id);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QuotaRequestDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuotaRequestStatus()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusById.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/D7EC67B3-7657-4966-BFFC-41EFD36BAAB3/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            QuotaRequestDetailResource result = await collection.GetAsync(id);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QuotaRequestDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_QuotaRequestHistory()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestsHistory.json
            // this example is just showing the usage of "QuotaRequestStatus_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/D7EC67B3-7657-4966-BFFC-41EFD36BAAB3/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation and iterate over the result
            await foreach (QuotaRequestDetailResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QuotaRequestDetailData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_QuotaRequestFailed()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusFailed.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            bool result = await collection.ExistsAsync(id);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_QuotaRequestInProgress()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusInProgress.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            bool result = await collection.ExistsAsync(id);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_QuotaRequestStatus()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusById.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/D7EC67B3-7657-4966-BFFC-41EFD36BAAB3/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            bool result = await collection.ExistsAsync(id);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_QuotaRequestFailed()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusFailed.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            NullableResponse<QuotaRequestDetailResource> response = await collection.GetIfExistsAsync(id);
            QuotaRequestDetailResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QuotaRequestDetailData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_QuotaRequestInProgress()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusInProgress.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            NullableResponse<QuotaRequestDetailResource> response = await collection.GetIfExistsAsync(id);
            QuotaRequestDetailResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QuotaRequestDetailData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_QuotaRequestStatus()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/getQuotaRequestStatusById.json
            // this example is just showing the usage of "QuotaRequestStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this QuotaRequestDetailResource
            string scope = "subscriptions/D7EC67B3-7657-4966-BFFC-41EFD36BAAB3/providers/Microsoft.Compute/locations/eastus";
            QuotaRequestDetailCollection collection = client.GetQuotaRequestDetails(new ResourceIdentifier(scope));

            // invoke the operation
            string id = "2B5C8515-37D8-4B6A-879B-CD641A2CF605";
            NullableResponse<QuotaRequestDetailResource> response = await collection.GetIfExistsAsync(id);
            QuotaRequestDetailResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QuotaRequestDetailData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
