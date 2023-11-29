// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A Class representing a ResourceHealthEvent along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ResourceHealthEventResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetResourceHealthEventResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetResourceHealthEvent method.
    /// </summary>
    public partial class ResourceHealthEventResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceHealthEventResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="eventTrackingId"> The eventTrackingId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string eventTrackingId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceHealthEventEventClientDiagnostics;
        private readonly EventRestOperations _resourceHealthEventEventRestClient;
        private readonly ClientDiagnostics _securityAdvisoryImpactedResourcesClientDiagnostics;
        private readonly SecurityAdvisoryImpactedResourcesRestOperations _securityAdvisoryImpactedResourcesRestClient;
        private readonly ResourceHealthEventData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthEventResource"/> class for mocking. </summary>
        protected ResourceHealthEventResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthEventResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceHealthEventResource(ArmClient client, ResourceHealthEventData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthEventResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceHealthEventResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceHealthEventEventClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceHealthEventEventApiVersion);
            _resourceHealthEventEventRestClient = new EventRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceHealthEventEventApiVersion);
            _securityAdvisoryImpactedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _securityAdvisoryImpactedResourcesRestClient = new SecurityAdvisoryImpactedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ResourceHealth/events";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceHealthEventData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ResourceHealthEventImpactedResources in the ResourceHealthEvent. </summary>
        /// <returns> An object representing collection of ResourceHealthEventImpactedResources and their operations over a ResourceHealthEventImpactedResource. </returns>
        public virtual ResourceHealthEventImpactedResourceCollection GetResourceHealthEventImpactedResources()
        {
            return GetCachedClient(client => new ResourceHealthEventImpactedResourceCollection(client, Id));
        }

        /// <summary>
        /// Gets the specific impacted resource in the subscription by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="impactedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ResourceHealthEventImpactedResource>> GetResourceHealthEventImpactedResourceAsync(string impactedResourceName, CancellationToken cancellationToken = default)
        {
            return await GetResourceHealthEventImpactedResources().GetAsync(impactedResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specific impacted resource in the subscription by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="impactedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ResourceHealthEventImpactedResource> GetResourceHealthEventImpactedResource(string impactedResourceName, CancellationToken cancellationToken = default)
        {
            return GetResourceHealthEventImpactedResources().Get(impactedResourceName, cancellationToken);
        }

        /// <summary>
        /// Service health event in the subscription by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceHealthEventResource>> GetAsync(string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceHealthEventEventRestClient.GetBySubscriptionIdAndTrackingIdAsync(Id.SubscriptionId, Id.Name, filter, queryStartTime, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Service health event in the subscription by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceHealthEventResource> Get(string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventResource.Get");
            scope.Start();
            try
            {
                var response = _resourceHealthEventEventRestClient.GetBySubscriptionIdAndTrackingId(Id.SubscriptionId, Id.Name, filter, queryStartTime, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists impacted resources in the subscription by an event (Security Advisory).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/listSecurityAdvisoryImpactedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityAdvisoryImpactedResources_ListBySubscriptionIdAndEventId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceHealthEventImpactedResourceData"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthEventImpactedResourceData> GetSecurityAdvisoryImpactedResourcesBySubscriptionIdAndEventIdAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityAdvisoryImpactedResourcesRestClient.CreateListBySubscriptionIdAndEventIdRequest(Id.SubscriptionId, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityAdvisoryImpactedResourcesRestClient.CreateListBySubscriptionIdAndEventIdNextPageRequest(nextLink, Id.SubscriptionId, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData, _securityAdvisoryImpactedResourcesClientDiagnostics, Pipeline, "ResourceHealthEventResource.GetSecurityAdvisoryImpactedResourcesBySubscriptionIdAndEventId", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists impacted resources in the subscription by an event (Security Advisory).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/listSecurityAdvisoryImpactedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityAdvisoryImpactedResources_ListBySubscriptionIdAndEventId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceHealthEventImpactedResourceData"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthEventImpactedResourceData> GetSecurityAdvisoryImpactedResourcesBySubscriptionIdAndEventId(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityAdvisoryImpactedResourcesRestClient.CreateListBySubscriptionIdAndEventIdRequest(Id.SubscriptionId, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityAdvisoryImpactedResourcesRestClient.CreateListBySubscriptionIdAndEventIdNextPageRequest(nextLink, Id.SubscriptionId, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData, _securityAdvisoryImpactedResourcesClientDiagnostics, Pipeline, "ResourceHealthEventResource.GetSecurityAdvisoryImpactedResourcesBySubscriptionIdAndEventId", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Service health event details in the subscription by event tracking id. This can be used to fetch sensitive properties for Security Advisory events
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/fetchEventDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_fetchDetailsBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceHealthEventResource>> FetchDetailsBySubscriptionIdAndTrackingIdAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventResource.FetchDetailsBySubscriptionIdAndTrackingId");
            scope.Start();
            try
            {
                var response = await _resourceHealthEventEventRestClient.FetchDetailsBySubscriptionIdAndTrackingIdAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Service health event details in the subscription by event tracking id. This can be used to fetch sensitive properties for Security Advisory events
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/fetchEventDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_fetchDetailsBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceHealthEventResource> FetchDetailsBySubscriptionIdAndTrackingId(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceHealthEventEventClientDiagnostics.CreateScope("ResourceHealthEventResource.FetchDetailsBySubscriptionIdAndTrackingId");
            scope.Start();
            try
            {
                var response = _resourceHealthEventEventRestClient.FetchDetailsBySubscriptionIdAndTrackingId(Id.SubscriptionId, Id.Name, cancellationToken);
                return Response.FromValue(new ResourceHealthEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
