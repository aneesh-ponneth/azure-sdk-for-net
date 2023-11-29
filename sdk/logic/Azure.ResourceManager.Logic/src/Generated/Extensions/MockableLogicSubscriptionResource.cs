// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableLogicSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _logicWorkflowWorkflowsClientDiagnostics;
        private WorkflowsRestOperations _logicWorkflowWorkflowsRestClient;
        private ClientDiagnostics _integrationAccountClientDiagnostics;
        private IntegrationAccountsRestOperations _integrationAccountRestClient;
        private ClientDiagnostics _integrationServiceEnvironmentClientDiagnostics;
        private IntegrationServiceEnvironmentsRestOperations _integrationServiceEnvironmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableLogicSubscriptionResource"/> class for mocking. </summary>
        protected MockableLogicSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableLogicSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableLogicSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics LogicWorkflowWorkflowsClientDiagnostics => _logicWorkflowWorkflowsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowResource.ResourceType.Namespace, Diagnostics);
        private WorkflowsRestOperations LogicWorkflowWorkflowsRestClient => _logicWorkflowWorkflowsRestClient ??= new WorkflowsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LogicWorkflowResource.ResourceType));
        private ClientDiagnostics IntegrationAccountClientDiagnostics => _integrationAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationAccountResource.ResourceType.Namespace, Diagnostics);
        private IntegrationAccountsRestOperations IntegrationAccountRestClient => _integrationAccountRestClient ??= new IntegrationAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(IntegrationAccountResource.ResourceType));
        private ClientDiagnostics IntegrationServiceEnvironmentClientDiagnostics => _integrationServiceEnvironmentClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationServiceEnvironmentResource.ResourceType.Namespace, Diagnostics);
        private IntegrationServiceEnvironmentsRestOperations IntegrationServiceEnvironmentRestClient => _integrationServiceEnvironmentRestClient ??= new IntegrationServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(IntegrationServiceEnvironmentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets a list of workflows by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Logic/workflows</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: State, Trigger, and ReferencedResourceId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicWorkflowResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicWorkflowResource> GetLogicWorkflowsAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LogicWorkflowWorkflowsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LogicWorkflowWorkflowsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LogicWorkflowResource(Client, LogicWorkflowData.DeserializeLogicWorkflowData(e)), LogicWorkflowWorkflowsClientDiagnostics, Pipeline, "MockableLogicSubscriptionResource.GetLogicWorkflows", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of workflows by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Logic/workflows</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: State, Trigger, and ReferencedResourceId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicWorkflowResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicWorkflowResource> GetLogicWorkflows(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LogicWorkflowWorkflowsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LogicWorkflowWorkflowsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LogicWorkflowResource(Client, LogicWorkflowData.DeserializeLogicWorkflowData(e)), LogicWorkflowWorkflowsClientDiagnostics, Pipeline, "MockableLogicSubscriptionResource.GetLogicWorkflows", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of integration accounts by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Logic/integrationAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationAccountResource> GetIntegrationAccountsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IntegrationAccountRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IntegrationAccountRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IntegrationAccountResource(Client, IntegrationAccountData.DeserializeIntegrationAccountData(e)), IntegrationAccountClientDiagnostics, Pipeline, "MockableLogicSubscriptionResource.GetIntegrationAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of integration accounts by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Logic/integrationAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationAccountResource> GetIntegrationAccounts(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IntegrationAccountRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IntegrationAccountRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IntegrationAccountResource(Client, IntegrationAccountData.DeserializeIntegrationAccountData(e)), IntegrationAccountClientDiagnostics, Pipeline, "MockableLogicSubscriptionResource.GetIntegrationAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of integration service environments by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Logic/integrationServiceEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationServiceEnvironmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationServiceEnvironmentResource> GetIntegrationServiceEnvironmentsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IntegrationServiceEnvironmentRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IntegrationServiceEnvironmentRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IntegrationServiceEnvironmentResource(Client, IntegrationServiceEnvironmentData.DeserializeIntegrationServiceEnvironmentData(e)), IntegrationServiceEnvironmentClientDiagnostics, Pipeline, "MockableLogicSubscriptionResource.GetIntegrationServiceEnvironments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of integration service environments by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Logic/integrationServiceEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationServiceEnvironmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationServiceEnvironmentResource> GetIntegrationServiceEnvironments(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IntegrationServiceEnvironmentRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IntegrationServiceEnvironmentRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IntegrationServiceEnvironmentResource(Client, IntegrationServiceEnvironmentData.DeserializeIntegrationServiceEnvironmentData(e)), IntegrationServiceEnvironmentClientDiagnostics, Pipeline, "MockableLogicSubscriptionResource.GetIntegrationServiceEnvironments", "value", "nextLink", cancellationToken);
        }
    }
}
