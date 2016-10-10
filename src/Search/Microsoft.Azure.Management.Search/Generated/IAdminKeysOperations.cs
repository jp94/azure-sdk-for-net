// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AdminKeysOperations operations.
    /// </summary>
    public partial interface IAdminKeysOperations
    {
        /// <summary>
        /// Returns the primary and secondary API keys for the given Azure
        /// Search service.
        /// <see href="https://msdn.microsoft.com/library/azure/dn832685.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Search service for which to list admin keys.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AdminKeyResult>> ListWithHttpMessagesAsync(string resourceGroupName, string serviceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}