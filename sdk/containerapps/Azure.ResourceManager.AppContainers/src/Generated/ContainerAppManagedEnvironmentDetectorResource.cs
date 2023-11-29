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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A Class representing a ContainerAppManagedEnvironmentDetector along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerAppManagedEnvironmentDetectorResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerAppManagedEnvironmentDetectorResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppManagedEnvironmentResource"/> using the GetContainerAppManagedEnvironmentDetector method.
    /// </summary>
    public partial class ContainerAppManagedEnvironmentDetectorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerAppManagedEnvironmentDetectorResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="environmentName"> The environmentName. </param>
        /// <param name="detectorName"> The detectorName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string environmentName, string detectorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics;
        private readonly ManagedEnvironmentDiagnosticsRestOperations _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient;
        private readonly ContainerAppDiagnosticData _data;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDetectorResource"/> class for mocking. </summary>
        protected ContainerAppManagedEnvironmentDetectorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDetectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerAppManagedEnvironmentDetectorResource(ArmClient client, ContainerAppDiagnosticData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDetectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerAppManagedEnvironmentDetectorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsApiVersion);
            _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient = new ManagedEnvironmentDiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/managedEnvironments/detectors";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerAppDiagnosticData Data
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
        /// Get the diagnostics data for a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_GetDetector</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerAppManagedEnvironmentDetectorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorResource.Get");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the diagnostics data for a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_GetDetector</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerAppManagedEnvironmentDetectorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorResource.Get");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
