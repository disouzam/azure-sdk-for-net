// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Support.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_SubscriptionSupportTicketResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDetailsOfASubscriptionTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/GetSubscriptionSupportTicketDetails.json
            // this example is just showing the usage of "SupportTickets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // invoke the operation
            SubscriptionSupportTicketResource result = await subscriptionSupportTicket.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAdvancedDiagnosticConsentOfASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/UpdateAdvancedDiagnosticConsentOfSupportTicketForSubscription.json
            // this example is just showing the usage of "SupportTickets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // invoke the operation
            UpdateSupportTicket updateSupportTicket = new UpdateSupportTicket
            {
                AdvancedDiagnosticConsent = AdvancedDiagnosticConsent.Yes,
            };
            SubscriptionSupportTicketResource result = await subscriptionSupportTicket.UpdateAsync(updateSupportTicket);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateContactDetailsOfASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/UpdateContactDetailsOfSupportTicketForSubscription.json
            // this example is just showing the usage of "SupportTickets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // invoke the operation
            UpdateSupportTicket updateSupportTicket = new UpdateSupportTicket
            {
                ContactDetails = new SupportContactProfileContent
                {
                    FirstName = "first name",
                    LastName = "last name",
                    PreferredContactMethod = PreferredContactMethod.Email,
                    PrimaryEmailAddress = "test.name@contoso.com",
                    AdditionalEmailAddresses = { "tname@contoso.com", "teamtest@contoso.com" },
                    PhoneNumber = "123-456-7890",
                    PreferredTimeZone = "Pacific Standard Time",
                    Country = "USA",
                    PreferredSupportLanguage = "en-US",
                },
            };
            SubscriptionSupportTicketResource result = await subscriptionSupportTicket.UpdateAsync(updateSupportTicket);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateSeverityOfASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/UpdateSeverityOfSupportTicketForSubscription.json
            // this example is just showing the usage of "SupportTickets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // invoke the operation
            UpdateSupportTicket updateSupportTicket = new UpdateSupportTicket
            {
                Severity = SupportSeverityLevel.Critical,
            };
            SubscriptionSupportTicketResource result = await subscriptionSupportTicket.UpdateAsync(updateSupportTicket);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateStatusOfASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/UpdateStatusOfSupportTicketForSubscription.json
            // this example is just showing the usage of "SupportTickets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // invoke the operation
            UpdateSupportTicket updateSupportTicket = new UpdateSupportTicket
            {
                Status = SupportTicketStatus.Closed,
            };
            SubscriptionSupportTicketResource result = await subscriptionSupportTicket.UpdateAsync(updateSupportTicket);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckCommunicationNameAvailability_ChecksWhetherNameIsAvailableForCommunicationResourceForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/CheckNameAvailabilityForSupportTicketCommunication.json
            // this example is just showing the usage of "Communications_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSupportTicketResource created on azure
            // for more information of creating SubscriptionSupportTicketResource, please refer to the document of SubscriptionSupportTicketResource
            string subscriptionId = "132d901f-189d-4381-9214-fe68e27e05a1";
            string supportTicketName = "testticket";
            ResourceIdentifier subscriptionSupportTicketResourceId = SubscriptionSupportTicketResource.CreateResourceIdentifier(subscriptionId, supportTicketName);
            SubscriptionSupportTicketResource subscriptionSupportTicket = client.GetSubscriptionSupportTicketResource(subscriptionSupportTicketResourceId);

            // invoke the operation
            SupportNameAvailabilityContent content = new SupportNameAvailabilityContent("sampleName", SupportResourceType.MicrosoftSupportCommunications);
            SupportNameAvailabilityResult result = await subscriptionSupportTicket.CheckCommunicationNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
