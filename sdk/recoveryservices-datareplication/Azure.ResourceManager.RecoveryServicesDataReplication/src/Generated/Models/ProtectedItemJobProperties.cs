// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Protected item job properties. </summary>
    public partial class ProtectedItemJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="ProtectedItemJobProperties"/>. </summary>
        internal ProtectedItemJobProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProtectedItemJobProperties"/>. </summary>
        /// <param name="scenarioName"> Gets or sets protection scenario name. </param>
        /// <param name="id"> Gets or sets workflow Id. </param>
        /// <param name="name"> Gets or sets workflow name. </param>
        /// <param name="displayName"> Gets or sets the workflow friendly display name. </param>
        /// <param name="state"> Gets or sets workflow state. </param>
        /// <param name="startOn"> Gets or sets start time of the workflow. </param>
        /// <param name="endOn"> Gets or sets end time of the workflow. </param>
        internal ProtectedItemJobProperties(string scenarioName, string id, string name, string displayName, string state, DateTimeOffset? startOn, DateTimeOffset? endOn)
        {
            ScenarioName = scenarioName;
            Id = id;
            Name = name;
            DisplayName = displayName;
            State = state;
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> Gets or sets protection scenario name. </summary>
        public string ScenarioName { get; }
        /// <summary> Gets or sets workflow Id. </summary>
        public string Id { get; }
        /// <summary> Gets or sets workflow name. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the workflow friendly display name. </summary>
        public string DisplayName { get; }
        /// <summary> Gets or sets workflow state. </summary>
        public string State { get; }
        /// <summary> Gets or sets start time of the workflow. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets or sets end time of the workflow. </summary>
        public DateTimeOffset? EndOn { get; }
    }
}
