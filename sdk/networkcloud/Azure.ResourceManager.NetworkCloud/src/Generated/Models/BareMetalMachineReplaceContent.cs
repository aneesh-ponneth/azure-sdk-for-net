// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineReplaceParameters represents the body of the request to physically swap a bare metal machine for another. </summary>
    public partial class BareMetalMachineReplaceContent
    {
        /// <summary> Initializes a new instance of <see cref="BareMetalMachineReplaceContent"/>. </summary>
        public BareMetalMachineReplaceContent()
        {
        }

        /// <summary> The credentials of the baseboard management controller on this bare metal machine. </summary>
        public AdministrativeCredentials BmcCredentials { get; set; }
        /// <summary> The MAC address of the BMC device. </summary>
        public string BmcMacAddress { get; set; }
        /// <summary> The MAC address of a NIC connected to the PXE network. </summary>
        public string BootMacAddress { get; set; }
        /// <summary> The OS-level hostname assigned to this machine. </summary>
        public string MachineName { get; set; }
        /// <summary> The serial number of the bare metal machine. </summary>
        public string SerialNumber { get; set; }
    }
}
