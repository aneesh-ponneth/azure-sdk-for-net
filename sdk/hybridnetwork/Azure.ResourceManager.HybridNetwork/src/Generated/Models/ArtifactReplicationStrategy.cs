// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The replication strategy. </summary>
    public readonly partial struct ArtifactReplicationStrategy : IEquatable<ArtifactReplicationStrategy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArtifactReplicationStrategy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArtifactReplicationStrategy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string SingleReplicationValue = "SingleReplication";

        /// <summary> Unknown. </summary>
        public static ArtifactReplicationStrategy Unknown { get; } = new ArtifactReplicationStrategy(UnknownValue);
        /// <summary> SingleReplication. </summary>
        public static ArtifactReplicationStrategy SingleReplication { get; } = new ArtifactReplicationStrategy(SingleReplicationValue);
        /// <summary> Determines if two <see cref="ArtifactReplicationStrategy"/> values are the same. </summary>
        public static bool operator ==(ArtifactReplicationStrategy left, ArtifactReplicationStrategy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArtifactReplicationStrategy"/> values are not the same. </summary>
        public static bool operator !=(ArtifactReplicationStrategy left, ArtifactReplicationStrategy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArtifactReplicationStrategy"/>. </summary>
        public static implicit operator ArtifactReplicationStrategy(string value) => new ArtifactReplicationStrategy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArtifactReplicationStrategy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArtifactReplicationStrategy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
