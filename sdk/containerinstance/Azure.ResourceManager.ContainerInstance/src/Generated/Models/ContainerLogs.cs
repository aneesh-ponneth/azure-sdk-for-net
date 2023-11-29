// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The logs. </summary>
    public partial class ContainerLogs
    {
        /// <summary> Initializes a new instance of <see cref="ContainerLogs"/>. </summary>
        internal ContainerLogs()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerLogs"/>. </summary>
        /// <param name="content"> The content of the log. </param>
        internal ContainerLogs(string content)
        {
            Content = content;
        }

        /// <summary> The content of the log. </summary>
        public string Content { get; }
    }
}
