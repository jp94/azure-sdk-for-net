// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a sku for a scalable resource
    /// </summary>
    public partial class SkuDescription
    {
        /// <summary>
        /// Initializes a new instance of the SkuDescription class.
        /// </summary>
        public SkuDescription() { }

        /// <summary>
        /// Initializes a new instance of the SkuDescription class.
        /// </summary>
        public SkuDescription(string name = default(string), string tier = default(string), string size = default(string), string family = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
        }

        /// <summary>
        /// Name of the resource sku
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Service Tier of the resource sku
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Size specifier of the resource sku
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Family code of the resource sku
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Current number of instances assigned to the resource
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

    }
}