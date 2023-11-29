// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SoftwareInventory along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SoftwareInventoryResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSoftwareInventoryResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetSoftwareInventory method.
    /// </summary>
    public partial class SoftwareInventoryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SoftwareInventoryResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceNamespace"> The resourceNamespace. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="softwareName"> The softwareName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string softwareName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/softwareInventories/{softwareName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _softwareInventoryClientDiagnostics;
        private readonly SoftwareInventoriesRestOperations _softwareInventoryRestClient;
        private readonly SoftwareInventoryData _data;

        /// <summary> Initializes a new instance of the <see cref="SoftwareInventoryResource"/> class for mocking. </summary>
        protected SoftwareInventoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SoftwareInventoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SoftwareInventoryResource(ArmClient client, SoftwareInventoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SoftwareInventoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SoftwareInventoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _softwareInventoryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string softwareInventoryApiVersion);
            _softwareInventoryRestClient = new SoftwareInventoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, softwareInventoryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/softwareInventories";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SoftwareInventoryData Data
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
        /// Gets a single software data of the virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/softwareInventories/{softwareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareInventories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SoftwareInventoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _softwareInventoryClientDiagnostics.CreateScope("SoftwareInventoryResource.Get");
            scope.Start();
            try
            {
                var response = await _softwareInventoryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SoftwareInventoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a single software data of the virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceNamespace}/{resourceType}/{resourceName}/providers/Microsoft.Security/softwareInventories/{softwareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareInventories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SoftwareInventoryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _softwareInventoryClientDiagnostics.CreateScope("SoftwareInventoryResource.Get");
            scope.Start();
            try
            {
                var response = _softwareInventoryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SoftwareInventoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
