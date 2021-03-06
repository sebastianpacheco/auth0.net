﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Auth0.ManagementApi.Models;

namespace Auth0.ManagementApi.Clients
{
    /// <summary>
    /// Contains all the methods to call the /clients endpoints.
    /// </summary>
    public interface IClientsClient
    {
        /// <summary>
        ///     Creates a new client application.
        /// </summary>
        /// <param name="request">The request containing the properties of the new client.</param>
        /// <returns></returns>
        Task<Core.Client> CreateAsync(ClientCreateRequest request);

        /// <summary>
        ///     Deletes a client and all its related assets (like rules, connections, etc) given its id.
        /// </summary>
        /// <param name="id">The id of the client to delete.</param>
        /// <returns></returns>
        Task DeleteAsync(string id);

        /// <summary>
        ///     Retrieves a list of all client applications. Accepts a list of fields to include or exclude.
        /// </summary>
        /// <param name="fields">
        ///     A comma separated list of fields to include or exclude (depending on includeFields) from the
        ///     result, empty to retrieve all fields
        /// </param>
        /// <param name="includeFields">
        ///     true if the fields specified are to be included in the result, false otherwise (defaults to
        ///     true)
        /// </param>
        /// <returns></returns>
        Task<IList<Core.Client>> GetAllAsync(string fields = null, bool includeFields = true);

        /// <summary>
        ///     Retrieves a client by its id.
        /// </summary>
        /// <param name="id">The id of the client to retrieve</param>
        /// <param name="fields">
        ///     A comma separated list of fields to include or exclude (depending on includeFields) from the
        ///     result, empty to retrieve all fields
        /// </param>
        /// <param name="includeFields">
        ///     true if the fields specified are to be included in the result, false otherwise (defaults to
        ///     true)
        /// </param>
        /// <returns></returns>
        Task<Core.Client> GetAsync(string id, string fields = null, bool includeFields = true);

        /// <summary>
        ///     Updates a client application.
        /// </summary>
        /// <param name="id">The id of the client you want to update.</param>
        /// <param name="request">The request containing the properties of the client you want to update.</param>
        /// <returns></returns>
        Task<Core.Client> UpdateAsync(string id, ClientUpdateRequest request);

        #region Obsolete Methods
#pragma warning disable 1591

        [Obsolete("Use CreateAsync instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        Task<Core.Client> Create(ClientCreateRequest request);

        [Obsolete("Use DeleteAsync instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        Task Delete(string id);

        [Obsolete("Use GetAsync instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        Task<Core.Client> Get(string id, string fields = null, bool includeFields = true);

        [Obsolete("Use GetAllAsync instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        Task<IList<Core.Client>> GetAll(string fields = null, bool includeFields = true);

        [Obsolete("Use UpdateAsync instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        Task<Core.Client> Update(string id, ClientUpdateRequest request);

#pragma warning restore 1591
        #endregion
    }
}