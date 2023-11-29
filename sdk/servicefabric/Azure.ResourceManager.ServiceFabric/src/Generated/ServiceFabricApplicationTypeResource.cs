// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary>
    /// A Class representing a ServiceFabricApplicationType along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ServiceFabricApplicationTypeResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetServiceFabricApplicationTypeResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceFabricClusterResource"/> using the GetServiceFabricApplicationType method.
    /// </summary>
    public partial class ServiceFabricApplicationTypeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceFabricApplicationTypeResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="clusterName"> The clusterName. </param>
        /// <param name="applicationTypeName"> The applicationTypeName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceFabricApplicationTypeApplicationTypesClientDiagnostics;
        private readonly ApplicationTypesRestOperations _serviceFabricApplicationTypeApplicationTypesRestClient;
        private readonly ServiceFabricApplicationTypeData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationTypeResource"/> class for mocking. </summary>
        protected ServiceFabricApplicationTypeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceFabricApplicationTypeResource(ArmClient client, ServiceFabricApplicationTypeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricApplicationTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceFabricApplicationTypeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceFabricApplicationTypeApplicationTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceFabric", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceFabricApplicationTypeApplicationTypesApiVersion);
            _serviceFabricApplicationTypeApplicationTypesRestClient = new ApplicationTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceFabricApplicationTypeApplicationTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceFabric/clusters/applicationTypes";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceFabricApplicationTypeData Data
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

        /// <summary> Gets a collection of ServiceFabricApplicationTypeVersionResources in the ServiceFabricApplicationType. </summary>
        /// <returns> An object representing collection of ServiceFabricApplicationTypeVersionResources and their operations over a ServiceFabricApplicationTypeVersionResource. </returns>
        public virtual ServiceFabricApplicationTypeVersionCollection GetServiceFabricApplicationTypeVersions()
        {
            return GetCachedClient(client => new ServiceFabricApplicationTypeVersionCollection(client, Id));
        }

        /// <summary>
        /// Get a Service Fabric application type version resource created or in the process of being created in the Service Fabric application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceFabricApplicationTypeVersionResource>> GetServiceFabricApplicationTypeVersionAsync(string version, CancellationToken cancellationToken = default)
        {
            return await GetServiceFabricApplicationTypeVersions().GetAsync(version, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Service Fabric application type version resource created or in the process of being created in the Service Fabric application type name resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypeVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The application type version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServiceFabricApplicationTypeVersionResource> GetServiceFabricApplicationTypeVersion(string version, CancellationToken cancellationToken = default)
        {
            return GetServiceFabricApplicationTypeVersions().Get(version, cancellationToken);
        }

        /// <summary>
        /// Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceFabricApplicationTypeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric cluster resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceFabricApplicationTypeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.Get");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Service Fabric application type name resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeApplicationTypesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricArmOperation(_serviceFabricApplicationTypeApplicationTypesClientDiagnostics, Pipeline, _serviceFabricApplicationTypeApplicationTypesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Service Fabric application type name resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeApplicationTypesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ServiceFabricArmOperation(_serviceFabricApplicationTypeApplicationTypesClientDiagnostics, Pipeline, _serviceFabricApplicationTypeApplicationTypesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a Service Fabric application type name resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceFabricApplicationTypeResource>> UpdateAsync(WaitUntil waitUntil, ServiceFabricApplicationTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.Update");
            scope.Start();
            try
            {
                var response = await _serviceFabricApplicationTypeApplicationTypesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricArmOperation<ServiceFabricApplicationTypeResource>(Response.FromValue(new ServiceFabricApplicationTypeResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a Service Fabric application type name resource with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceFabricApplicationTypeResource> Update(WaitUntil waitUntil, ServiceFabricApplicationTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.Update");
            scope.Start();
            try
            {
                var response = _serviceFabricApplicationTypeApplicationTypesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ServiceFabricArmOperation<ServiceFabricApplicationTypeResource>(Response.FromValue(new ServiceFabricApplicationTypeResource(Client, response), response.GetRawResponse()));
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
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricApplicationTypeResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _serviceFabricApplicationTypeApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<ServiceFabricApplicationTypeResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _serviceFabricApplicationTypeApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricApplicationTypeResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _serviceFabricApplicationTypeApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<ServiceFabricApplicationTypeResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _serviceFabricApplicationTypeApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricApplicationTypeResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _serviceFabricApplicationTypeApplicationTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/clusters/{clusterName}/applicationTypes/{applicationTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<ServiceFabricApplicationTypeResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _serviceFabricApplicationTypeApplicationTypesClientDiagnostics.CreateScope("ServiceFabricApplicationTypeResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _serviceFabricApplicationTypeApplicationTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new ServiceFabricApplicationTypeResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
