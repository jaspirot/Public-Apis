// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Sherweb.Apis.ServiceProvider.Models
{
    /// <summary> The Customer. </summary>
    public partial class Customer
    {
        /// <summary> Initializes a new instance of Customer. </summary>
        internal Customer()
        {
            Path = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of Customer. </summary>
        /// <param name="id"> . </param>
        /// <param name="displayName"> . </param>
        /// <param name="path"> . </param>
        /// <param name="suspendedOn"> Format: yyyy-MM-ddTHH:mm:ss.fffffffK (UTC). Example : 2021-01-13T20:30:05.7613888. </param>
        /// <param name="deletedOn"> Format: yyyy-MM-ddTHH:mm:ss.fffffffK (UTC). Example : 2021-01-13T20:30:05.7613888. </param>
        internal Customer(Guid? id, string displayName, IReadOnlyList<string> path, DateTimeOffset? suspendedOn, DateTimeOffset? deletedOn)
        {
            Id = id;
            DisplayName = displayName;
            Path = path;
            SuspendedOn = suspendedOn;
            DeletedOn = deletedOn;
        }

        public Guid? Id { get; }
        public string DisplayName { get; }
        public IReadOnlyList<string> Path { get; }
        /// <summary> Format: yyyy-MM-ddTHH:mm:ss.fffffffK (UTC). Example : 2021-01-13T20:30:05.7613888. </summary>
        public DateTimeOffset? SuspendedOn { get; }
        /// <summary> Format: yyyy-MM-ddTHH:mm:ss.fffffffK (UTC). Example : 2021-01-13T20:30:05.7613888. </summary>
        public DateTimeOffset? DeletedOn { get; }
    }
}
