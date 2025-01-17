// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the command that finishes a migration in whole or in part. </summary>
    public partial class MongoDBFinishCommand : CommandProperties
    {
        /// <summary> Initializes a new instance of <see cref="MongoDBFinishCommand"/>. </summary>
        public MongoDBFinishCommand()
        {
            CommandType = CommandType.Finish;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBFinishCommand"/>. </summary>
        /// <param name="commandType"> Command type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the command. This is ignored if submitted. </param>
        /// <param name="input"> Command input. </param>
        internal MongoDBFinishCommand(CommandType commandType, IReadOnlyList<ODataError> errors, CommandState? state, MongoDBFinishCommandInput input) : base(commandType, errors, state)
        {
            Input = input;
            CommandType = commandType;
        }

        /// <summary> Command input. </summary>
        public MongoDBFinishCommandInput Input { get; set; }
    }
}
