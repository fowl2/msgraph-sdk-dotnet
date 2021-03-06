// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ScheduleOpenShiftChangeRequestsCollectionRequestBuilder.
    /// </summary>
    public partial class ScheduleOpenShiftChangeRequestsCollectionRequestBuilder : BaseRequestBuilder, IScheduleOpenShiftChangeRequestsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ScheduleOpenShiftChangeRequestsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ScheduleOpenShiftChangeRequestsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IScheduleOpenShiftChangeRequestsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IScheduleOpenShiftChangeRequestsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ScheduleOpenShiftChangeRequestsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOpenShiftChangeRequestRequestBuilder"/> for the specified ScheduleOpenShiftChangeRequest.
        /// </summary>
        /// <param name="id">The ID for the ScheduleOpenShiftChangeRequest.</param>
        /// <returns>The <see cref="IOpenShiftChangeRequestRequestBuilder"/>.</returns>
        public IOpenShiftChangeRequestRequestBuilder this[string id]
        {
            get
            {
                return new OpenShiftChangeRequestRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
