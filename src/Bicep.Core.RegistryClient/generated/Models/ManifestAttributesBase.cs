// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Bicep.Core.RegistryClient.Models
{
    /// <summary> Manifest details. </summary>
    internal partial class ManifestAttributesBase
    {
        /// <summary> Initializes a new instance of ManifestAttributesBase. </summary>
        /// <param name="digest"> Manifest. </param>
        /// <param name="createdOn"> Created time. </param>
        /// <param name="lastUpdatedOn"> Last update time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="digest"/> is null. </exception>
        internal ManifestAttributesBase(string digest, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn)
        {
            if (digest == null)
            {
                throw new ArgumentNullException(nameof(digest));
            }

            Digest = digest;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            RelatedArtifacts = new ChangeTrackingList<ArtifactManifestPlatform>();
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ManifestAttributesBase. </summary>
        /// <param name="digest"> Manifest. </param>
        /// <param name="size"> Image size. </param>
        /// <param name="createdOn"> Created time. </param>
        /// <param name="lastUpdatedOn"> Last update time. </param>
        /// <param name="architecture"> CPU architecture. </param>
        /// <param name="operatingSystem"> Operating system. </param>
        /// <param name="mediaType"> Media type. </param>
        /// <param name="relatedArtifacts"> List of artifacts that are referenced by this manifest list, with information about the platform each supports.  This list will be empty if this is a leaf manifest and not a manifest list. </param>
        /// <param name="tags"> List of tags. </param>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        /// <param name="quarantineState"> Quarantine state. </param>
        /// <param name="quarantineDetails"> Quarantine details. </param>
        internal ManifestAttributesBase(string digest, long? size, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, ArtifactArchitecture? architecture, ArtifactOperatingSystem? operatingSystem, string mediaType, IReadOnlyList<ArtifactManifestPlatform> relatedArtifacts, IReadOnlyList<string> tags, bool? canDelete, bool? canWrite, bool? canList, bool? canRead, string quarantineState, string quarantineDetails)
        {
            Digest = digest;
            Size = size;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Architecture = architecture;
            OperatingSystem = operatingSystem;
            MediaType = mediaType;
            RelatedArtifacts = relatedArtifacts;
            Tags = tags;
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
            QuarantineState = quarantineState;
            QuarantineDetails = quarantineDetails;
        }

        /// <summary> Manifest. </summary>
        public string Digest { get; }
        /// <summary> Image size. </summary>
        public long? Size { get; }
        /// <summary> Created time. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Last update time. </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary> CPU architecture. </summary>
        public ArtifactArchitecture? Architecture { get; }
        /// <summary> Operating system. </summary>
        public ArtifactOperatingSystem? OperatingSystem { get; }
        /// <summary> Media type. </summary>
        public string MediaType { get; }
        /// <summary> List of artifacts that are referenced by this manifest list, with information about the platform each supports.  This list will be empty if this is a leaf manifest and not a manifest list. </summary>
        public IReadOnlyList<ArtifactManifestPlatform> RelatedArtifacts { get; }
        /// <summary> List of tags. </summary>
        public IReadOnlyList<string> Tags { get; }
        /// <summary> Delete enabled. </summary>
        public bool? CanDelete { get; }
        /// <summary> Write enabled. </summary>
        public bool? CanWrite { get; }
        /// <summary> List enabled. </summary>
        public bool? CanList { get; }
        /// <summary> Read enabled. </summary>
        public bool? CanRead { get; }
        /// <summary> Quarantine state. </summary>
        public string QuarantineState { get; }
        /// <summary> Quarantine details. </summary>
        public string QuarantineDetails { get; }
    }
}
