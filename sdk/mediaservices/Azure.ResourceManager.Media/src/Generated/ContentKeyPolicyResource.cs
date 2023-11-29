// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A Class representing a ContentKeyPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContentKeyPolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContentKeyPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="MediaServicesAccountResource"/> using the GetContentKeyPolicy method.
    /// </summary>
    public partial class ContentKeyPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContentKeyPolicyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="contentKeyPolicyName"> The contentKeyPolicyName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string contentKeyPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _contentKeyPolicyClientDiagnostics;
        private readonly ContentKeyPoliciesRestOperations _contentKeyPolicyRestClient;
        private readonly ContentKeyPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="ContentKeyPolicyResource"/> class for mocking. </summary>
        protected ContentKeyPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContentKeyPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContentKeyPolicyResource(ArmClient client, ContentKeyPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContentKeyPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContentKeyPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _contentKeyPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string contentKeyPolicyApiVersion);
            _contentKeyPolicyRestClient = new ContentKeyPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, contentKeyPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Media/mediaServices/contentKeyPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContentKeyPolicyData Data
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

        /// <summary>
        /// Get the details of a Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContentKeyPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _contentKeyPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContentKeyPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of a Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContentKeyPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _contentKeyPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContentKeyPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyResource.Delete");
            scope.Start();
            try
            {
                var response = await _contentKeyPolicyRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation(response);
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
        /// Deletes a Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyResource.Delete");
            scope.Start();
            try
            {
                var response = _contentKeyPolicyRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MediaArmOperation(response);
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
        /// Updates an existing Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<ContentKeyPolicyResource>> UpdateAsync(ContentKeyPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _contentKeyPolicyRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ContentKeyPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<ContentKeyPolicyResource> Update(ContentKeyPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _contentKeyPolicyRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new ContentKeyPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Content Key Policy including secret values
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}/getPolicyPropertiesWithSecrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_GetPolicyPropertiesWithSecrets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContentKeyPolicyProperties>> GetPolicyPropertiesWithSecretsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyResource.GetPolicyPropertiesWithSecrets");
            scope.Start();
            try
            {
                var response = await _contentKeyPolicyRestClient.GetPolicyPropertiesWithSecretsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Content Key Policy including secret values
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}/getPolicyPropertiesWithSecrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_GetPolicyPropertiesWithSecrets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContentKeyPolicyProperties> GetPolicyPropertiesWithSecrets(CancellationToken cancellationToken = default)
        {
            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyResource.GetPolicyPropertiesWithSecrets");
            scope.Start();
            try
            {
                var response = _contentKeyPolicyRestClient.GetPolicyPropertiesWithSecrets(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
