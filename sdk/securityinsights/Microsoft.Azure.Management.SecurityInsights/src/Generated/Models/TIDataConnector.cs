// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents threat intelligence data connector.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ThreatIntelligence")]
    [Rest.Serialization.JsonTransformation]
    public partial class TIDataConnector : DataConnector
    {
        /// <summary>
        /// Initializes a new instance of the TIDataConnector class.
        /// </summary>
        public TIDataConnector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TIDataConnector class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="tenantId">The tenant id to connect to, and get the
        /// data from.</param>
        /// <param name="tipLookbackPeriod">The lookback period for the feed to
        /// be imported.</param>
        /// <param name="dataTypes">The available data types for the
        /// connector.</param>
        public TIDataConnector(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), string tenantId = default(string), System.DateTime? tipLookbackPeriod = default(System.DateTime?), TIDataConnectorDataTypes dataTypes = default(TIDataConnectorDataTypes))
            : base(id, name, type, etag)
        {
            TenantId = tenantId;
            TipLookbackPeriod = tipLookbackPeriod;
            DataTypes = dataTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tenant id to connect to, and get the data from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the lookback period for the feed to be imported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tipLookbackPeriod")]
        public System.DateTime? TipLookbackPeriod { get; set; }

        /// <summary>
        /// Gets or sets the available data types for the connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataTypes")]
        public TIDataConnectorDataTypes DataTypes { get; set; }

    }
}
