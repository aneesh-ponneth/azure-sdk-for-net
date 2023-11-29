// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Grafana
{
    internal class ManagedPrivateEndpointModelOperationSource : IOperationSource<ManagedPrivateEndpointModelResource>
    {
        private readonly ArmClient _client;

        internal ManagedPrivateEndpointModelOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedPrivateEndpointModelResource IOperationSource<ManagedPrivateEndpointModelResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedPrivateEndpointModelData.DeserializeManagedPrivateEndpointModelData(document.RootElement);
            return new ManagedPrivateEndpointModelResource(_client, data);
        }

        async ValueTask<ManagedPrivateEndpointModelResource> IOperationSource<ManagedPrivateEndpointModelResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedPrivateEndpointModelData.DeserializeManagedPrivateEndpointModelData(document.RootElement);
            return new ManagedPrivateEndpointModelResource(_client, data);
        }
    }
}
