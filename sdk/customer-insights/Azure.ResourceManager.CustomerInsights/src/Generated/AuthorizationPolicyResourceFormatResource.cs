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
using Azure.ResourceManager.CustomerInsights.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A Class representing an AuthorizationPolicyResourceFormat along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AuthorizationPolicyResourceFormatResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAuthorizationPolicyResourceFormatResource method.
    /// Otherwise you can get one from its parent resource <see cref="HubResource"/> using the GetAuthorizationPolicyResourceFormat method.
    /// </summary>
    public partial class AuthorizationPolicyResourceFormatResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AuthorizationPolicyResourceFormatResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="hubName"> The hubName. </param>
        /// <param name="authorizationPolicyName"> The authorizationPolicyName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hubName, string authorizationPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics;
        private readonly AuthorizationPoliciesRestOperations _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient;
        private readonly AuthorizationPolicyResourceFormatData _data;

        /// <summary> Initializes a new instance of the <see cref="AuthorizationPolicyResourceFormatResource"/> class for mocking. </summary>
        protected AuthorizationPolicyResourceFormatResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationPolicyResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AuthorizationPolicyResourceFormatResource(ArmClient client, AuthorizationPolicyResourceFormatData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationPolicyResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AuthorizationPolicyResourceFormatResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string authorizationPolicyResourceFormatAuthorizationPoliciesApiVersion);
            _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient = new AuthorizationPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, authorizationPolicyResourceFormatAuthorizationPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CustomerInsights/hubs/authorizationPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AuthorizationPolicyResourceFormatData Data
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
        /// Gets an authorization policy in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AuthorizationPolicyResourceFormatResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = await _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization policy in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AuthorizationPolicyResourceFormatResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an authorization policy or updates an existing authorization policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate authorization policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AuthorizationPolicyResourceFormatResource>> UpdateAsync(WaitUntil waitUntil, AuthorizationPolicyResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = await _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<AuthorizationPolicyResourceFormatResource>(Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response), response.GetRawResponse()));
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
        /// Creates an authorization policy or updates an existing authorization policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate authorization policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AuthorizationPolicyResourceFormatResource> Update(WaitUntil waitUntil, AuthorizationPolicyResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<AuthorizationPolicyResourceFormatResource>(Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response), response.GetRawResponse()));
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
        /// Regenerates the primary policy key of the specified authorization policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}/regeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_RegeneratePrimaryKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AuthorizationPolicy>> RegeneratePrimaryKeyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatResource.RegeneratePrimaryKey");
            scope.Start();
            try
            {
                var response = await _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.RegeneratePrimaryKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary policy key of the specified authorization policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}/regeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_RegeneratePrimaryKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AuthorizationPolicy> RegeneratePrimaryKey(CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatResource.RegeneratePrimaryKey");
            scope.Start();
            try
            {
                var response = _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.RegeneratePrimaryKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the secondary policy key of the specified authorization policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}/regenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_RegenerateSecondaryKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AuthorizationPolicy>> RegenerateSecondaryKeyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatResource.RegenerateSecondaryKey");
            scope.Start();
            try
            {
                var response = await _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.RegenerateSecondaryKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the secondary policy key of the specified authorization policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}/regenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_RegenerateSecondaryKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AuthorizationPolicy> RegenerateSecondaryKey(CancellationToken cancellationToken = default)
        {
            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatResource.RegenerateSecondaryKey");
            scope.Start();
            try
            {
                var response = _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.RegenerateSecondaryKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
