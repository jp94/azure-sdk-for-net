// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PolicySetDefinitionsOperations.
    /// </summary>
    public static partial class PolicySetDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a policy set definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policySetDefinitionName'>
            /// The name of the policy set definition to create.
            /// </param>
            /// <param name='parameters'>
            /// The policy set definition properties.
            /// </param>
            public static PolicySetDefinition CreateOrUpdate(this IPolicySetDefinitionsOperations operations, string policySetDefinitionName, PolicySetDefinition parameters)
            {
                return operations.CreateOrUpdateAsync(policySetDefinitionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a policy set definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policySetDefinitionName'>
            /// The name of the policy set definition to create.
            /// </param>
            /// <param name='parameters'>
            /// The policy set definition properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicySetDefinition> CreateOrUpdateAsync(this IPolicySetDefinitionsOperations operations, string policySetDefinitionName, PolicySetDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(policySetDefinitionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a policy set definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policySetDefinitionName'>
            /// The name of the policy set definition to delete.
            /// </param>
            public static void Delete(this IPolicySetDefinitionsOperations operations, string policySetDefinitionName)
            {
                operations.DeleteAsync(policySetDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a policy set definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policySetDefinitionName'>
            /// The name of the policy set definition to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPolicySetDefinitionsOperations operations, string policySetDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(policySetDefinitionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the policy set definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policySetDefinitionName'>
            /// The name of the policy set definition to get.
            /// </param>
            public static PolicySetDefinition Get(this IPolicySetDefinitionsOperations operations, string policySetDefinitionName)
            {
                return operations.GetAsync(policySetDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the policy set definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policySetDefinitionName'>
            /// The name of the policy set definition to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicySetDefinition> GetAsync(this IPolicySetDefinitionsOperations operations, string policySetDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(policySetDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the policy set definitions for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PolicySetDefinition> List(this IPolicySetDefinitionsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the policy set definitions for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicySetDefinition>> ListAsync(this IPolicySetDefinitionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the policy set definitions for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PolicySetDefinition> ListNext(this IPolicySetDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the policy set definitions for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicySetDefinition>> ListNextAsync(this IPolicySetDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}