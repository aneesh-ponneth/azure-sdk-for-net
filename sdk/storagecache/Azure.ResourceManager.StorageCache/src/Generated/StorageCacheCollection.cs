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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageCacheResource"/> and their operations.
    /// Each <see cref="StorageCacheResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="StorageCacheCollection"/> instance call the GetStorageCaches method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class StorageCacheCollection : ArmCollection, IEnumerable<StorageCacheResource>, IAsyncEnumerable<StorageCacheResource>
    {
        private readonly ClientDiagnostics _storageCacheCachesClientDiagnostics;
        private readonly CachesRestOperations _storageCacheCachesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageCacheCollection"/> class for mocking. </summary>
        protected StorageCacheCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageCacheCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageCacheCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageCacheCachesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageCache", StorageCacheResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageCacheResource.ResourceType, out string storageCacheCachesApiVersion);
            _storageCacheCachesRestClient = new CachesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageCacheCachesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="data"> Object containing the user-selectable properties of the new cache. If read-only properties are included, they must match the existing values of those properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageCacheResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cacheName, StorageCacheData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageCacheCachesClientDiagnostics.CreateScope("StorageCacheCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageCacheCachesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cacheName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageCacheArmOperation<StorageCacheResource>(new StorageCacheOperationSource(Client), _storageCacheCachesClientDiagnostics, Pipeline, _storageCacheCachesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cacheName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="data"> Object containing the user-selectable properties of the new cache. If read-only properties are included, they must match the existing values of those properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageCacheResource> CreateOrUpdate(WaitUntil waitUntil, string cacheName, StorageCacheData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageCacheCachesClientDiagnostics.CreateScope("StorageCacheCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageCacheCachesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cacheName, data, cancellationToken);
                var operation = new StorageCacheArmOperation<StorageCacheResource>(new StorageCacheOperationSource(Client), _storageCacheCachesClientDiagnostics, Pipeline, _storageCacheCachesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cacheName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Returns a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual async Task<Response<StorageCacheResource>> GetAsync(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _storageCacheCachesClientDiagnostics.CreateScope("StorageCacheCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageCacheCachesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageCacheResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual Response<StorageCacheResource> Get(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _storageCacheCachesClientDiagnostics.CreateScope("StorageCacheCollection.Get");
            scope.Start();
            try
            {
                var response = _storageCacheCachesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageCacheResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns all caches the user has access to under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageCacheResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageCacheCachesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageCacheCachesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageCacheResource(Client, StorageCacheData.DeserializeStorageCacheData(e)), _storageCacheCachesClientDiagnostics, Pipeline, "StorageCacheCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all caches the user has access to under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageCacheResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageCacheCachesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageCacheCachesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageCacheResource(Client, StorageCacheData.DeserializeStorageCacheData(e)), _storageCacheCachesClientDiagnostics, Pipeline, "StorageCacheCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _storageCacheCachesClientDiagnostics.CreateScope("StorageCacheCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageCacheCachesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual Response<bool> Exists(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _storageCacheCachesClientDiagnostics.CreateScope("StorageCacheCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageCacheCachesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageCacheResource>> GetIfExistsAsync(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _storageCacheCachesClientDiagnostics.CreateScope("StorageCacheCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageCacheCachesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageCacheResource>(response.GetRawResponse());
                return Response.FromValue(new StorageCacheResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheName"> Name of cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        public virtual NullableResponse<StorageCacheResource> GetIfExists(string cacheName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheName, nameof(cacheName));

            using var scope = _storageCacheCachesClientDiagnostics.CreateScope("StorageCacheCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageCacheCachesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cacheName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageCacheResource>(response.GetRawResponse());
                return Response.FromValue(new StorageCacheResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageCacheResource> IEnumerable<StorageCacheResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageCacheResource> IAsyncEnumerable<StorageCacheResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
