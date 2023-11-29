// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRouteCircuitConnectionResource"/> and their operations.
    /// Each <see cref="ExpressRouteCircuitConnectionResource"/> in the collection will belong to the same instance of <see cref="ExpressRouteCircuitPeeringResource"/>.
    /// To get an <see cref="ExpressRouteCircuitConnectionCollection"/> instance call the GetExpressRouteCircuitConnections method from an instance of <see cref="ExpressRouteCircuitPeeringResource"/>.
    /// </summary>
    public partial class ExpressRouteCircuitConnectionCollection : ArmCollection, IEnumerable<ExpressRouteCircuitConnectionResource>, IAsyncEnumerable<ExpressRouteCircuitConnectionResource>
    {
        private readonly ClientDiagnostics _expressRouteCircuitConnectionClientDiagnostics;
        private readonly ExpressRouteCircuitConnectionsRestOperations _expressRouteCircuitConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnectionCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCircuitConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCircuitConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteCircuitConnectionResource.ResourceType, out string expressRouteCircuitConnectionApiVersion);
            _expressRouteCircuitConnectionRestClient = new ExpressRouteCircuitConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteCircuitConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCircuitPeeringResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCircuitPeeringResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Express Route Circuit Connection in the specified express route circuits.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuitConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, ExpressRouteCircuitConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuitConnectionResource>(new ExpressRouteCircuitConnectionOperationSource(Client), _expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a Express Route Circuit Connection in the specified express route circuits.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="data"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuitConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, ExpressRouteCircuitConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuitConnectionResource>(new ExpressRouteCircuitConnectionOperationSource(Client), _expressRouteCircuitConnectionClientDiagnostics, Pipeline, _expressRouteCircuitConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Express Route Circuit Connection from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCircuitConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Express Route Circuit Connection from the specified express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all global reach connections associated with a private peering in an express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuitConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuitConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCircuitConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCircuitConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteCircuitConnectionResource(Client, ExpressRouteCircuitConnectionData.DeserializeExpressRouteCircuitConnectionData(e)), _expressRouteCircuitConnectionClientDiagnostics, Pipeline, "ExpressRouteCircuitConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all global reach connections associated with a private peering in an express route circuit.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuitConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuitConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCircuitConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCircuitConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExpressRouteCircuitConnectionResource(Client, ExpressRouteCircuitConnectionData.DeserializeExpressRouteCircuitConnectionData(e)), _expressRouteCircuitConnectionClientDiagnostics, Pipeline, "ExpressRouteCircuitConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExpressRouteCircuitConnectionResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteCircuitConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCircuitConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual NullableResponse<ExpressRouteCircuitConnectionResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteCircuitConnectionClientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteCircuitConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCircuitConnectionResource> IEnumerable<ExpressRouteCircuitConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuitConnectionResource> IAsyncEnumerable<ExpressRouteCircuitConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
