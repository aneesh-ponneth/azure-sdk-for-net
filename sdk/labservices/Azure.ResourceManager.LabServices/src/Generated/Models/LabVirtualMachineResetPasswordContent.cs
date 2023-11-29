// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Body of a reset password request. </summary>
    public partial class LabVirtualMachineResetPasswordContent
    {
        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineResetPasswordContent"/>. </summary>
        /// <param name="username"> The user whose password is being reset. </param>
        /// <param name="password"> The password. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> or <paramref name="password"/> is null. </exception>
        public LabVirtualMachineResetPasswordContent(string username, string password)
        {
            Argument.AssertNotNull(username, nameof(username));
            Argument.AssertNotNull(password, nameof(password));

            Username = username;
            Password = password;
        }

        /// <summary> The user whose password is being reset. </summary>
        public string Username { get; }
        /// <summary> The password. </summary>
        public string Password { get; }
    }
}
