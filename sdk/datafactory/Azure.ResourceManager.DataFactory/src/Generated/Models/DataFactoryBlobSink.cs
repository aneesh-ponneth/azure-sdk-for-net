// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Azure Blob sink. </summary>
    public partial class DataFactoryBlobSink : CopySink
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryBlobSink"/>. </summary>
        public DataFactoryBlobSink()
        {
            Metadata = new ChangeTrackingList<DataFactoryMetadataItemInfo>();
            CopySinkType = "BlobSink";
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryBlobSink"/>. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="blobWriterOverwriteFiles"> Blob writer overwrite files. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="blobWriterDateTimeFormat"> Blob writer date time format. Type: string (or Expression with resultType string). </param>
        /// <param name="blobWriterAddHeader"> Blob writer add header. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="metadata"> Specify the custom metadata to be added to sink data. Type: array of objects (or Expression with resultType array of objects). </param>
        internal DataFactoryBlobSink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<bool> blobWriterOverwriteFiles, DataFactoryElement<string> blobWriterDateTimeFormat, DataFactoryElement<bool> blobWriterAddHeader, BinaryData copyBehavior, IList<DataFactoryMetadataItemInfo> metadata) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            BlobWriterOverwriteFiles = blobWriterOverwriteFiles;
            BlobWriterDateTimeFormat = blobWriterDateTimeFormat;
            BlobWriterAddHeader = blobWriterAddHeader;
            CopyBehavior = copyBehavior;
            Metadata = metadata;
            CopySinkType = copySinkType ?? "BlobSink";
        }

        /// <summary> Blob writer overwrite files. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> BlobWriterOverwriteFiles { get; set; }
        /// <summary> Blob writer date time format. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> BlobWriterDateTimeFormat { get; set; }
        /// <summary> Blob writer add header. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> BlobWriterAddHeader { get; set; }
        /// <summary>
        /// The type of copy behavior for copy sink.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData CopyBehavior { get; set; }
        /// <summary> Specify the custom metadata to be added to sink data. Type: array of objects (or Expression with resultType array of objects). </summary>
        public IList<DataFactoryMetadataItemInfo> Metadata { get; }
    }
}
