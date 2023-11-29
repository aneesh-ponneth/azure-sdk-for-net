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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="TenantAssessmentMetadataResource"/> and their operations.
    /// Each <see cref="TenantAssessmentMetadataResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="TenantAssessmentMetadataCollection"/> instance call the GetTenantAssessmentMetadata method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class TenantAssessmentMetadataCollection : ArmCollection, IEnumerable<TenantAssessmentMetadataResource>, IAsyncEnumerable<TenantAssessmentMetadataResource>
    {
        private readonly ClientDiagnostics _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics;
        private readonly AssessmentsMetadataRestOperations _tenantAssessmentMetadataAssessmentsMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantAssessmentMetadataCollection"/> class for mocking. </summary>
        protected TenantAssessmentMetadataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantAssessmentMetadataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TenantAssessmentMetadataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", TenantAssessmentMetadataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TenantAssessmentMetadataResource.ResourceType, out string tenantAssessmentMetadataAssessmentsMetadataApiVersion);
            _tenantAssessmentMetadataAssessmentsMetadataRestClient = new AssessmentsMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantAssessmentMetadataAssessmentsMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get metadata information on an assessment type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual async Task<Response<TenantAssessmentMetadataResource>> GetAsync(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("TenantAssessmentMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantAssessmentMetadataAssessmentsMetadataRestClient.GetAsync(assessmentMetadataName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantAssessmentMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get metadata information on an assessment type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual Response<TenantAssessmentMetadataResource> Get(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("TenantAssessmentMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantAssessmentMetadataAssessmentsMetadataRestClient.Get(assessmentMetadataName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantAssessmentMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get metadata information on all assessment types
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/assessmentMetadata</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantAssessmentMetadataResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantAssessmentMetadataResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tenantAssessmentMetadataAssessmentsMetadataRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tenantAssessmentMetadataAssessmentsMetadataRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TenantAssessmentMetadataResource(Client, SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(e)), _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics, Pipeline, "TenantAssessmentMetadataCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get metadata information on all assessment types
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/assessmentMetadata</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantAssessmentMetadataResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantAssessmentMetadataResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tenantAssessmentMetadataAssessmentsMetadataRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tenantAssessmentMetadataAssessmentsMetadataRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TenantAssessmentMetadataResource(Client, SecurityAssessmentMetadataData.DeserializeSecurityAssessmentMetadataData(e)), _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics, Pipeline, "TenantAssessmentMetadataCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("TenantAssessmentMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tenantAssessmentMetadataAssessmentsMetadataRestClient.GetAsync(assessmentMetadataName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual Response<bool> Exists(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("TenantAssessmentMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = _tenantAssessmentMetadataAssessmentsMetadataRestClient.Get(assessmentMetadataName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual async Task<NullableResponse<TenantAssessmentMetadataResource>> GetIfExistsAsync(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("TenantAssessmentMetadataCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _tenantAssessmentMetadataAssessmentsMetadataRestClient.GetAsync(assessmentMetadataName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TenantAssessmentMetadataResource>(response.GetRawResponse());
                return Response.FromValue(new TenantAssessmentMetadataResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentMetadataName"> The Assessment Key - Unique key for the assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentMetadataName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentMetadataName"/> is null. </exception>
        public virtual NullableResponse<TenantAssessmentMetadataResource> GetIfExists(string assessmentMetadataName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentMetadataName, nameof(assessmentMetadataName));

            using var scope = _tenantAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("TenantAssessmentMetadataCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _tenantAssessmentMetadataAssessmentsMetadataRestClient.Get(assessmentMetadataName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TenantAssessmentMetadataResource>(response.GetRawResponse());
                return Response.FromValue(new TenantAssessmentMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TenantAssessmentMetadataResource> IEnumerable<TenantAssessmentMetadataResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantAssessmentMetadataResource> IAsyncEnumerable<TenantAssessmentMetadataResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
