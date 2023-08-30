// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The type of SSIS object metadata. </summary>
    internal readonly partial struct SsisObjectMetadataType : IEquatable<SsisObjectMetadataType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SsisObjectMetadataType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SsisObjectMetadataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FolderValue = "Folder";
        private const string ProjectValue = "Project";
        private const string PackageValue = "Package";
        private const string EnvironmentValue = "Environment";

        /// <summary> Folder. </summary>
        public static SsisObjectMetadataType Folder { get; } = new SsisObjectMetadataType(FolderValue);
        /// <summary> Project. </summary>
        public static SsisObjectMetadataType Project { get; } = new SsisObjectMetadataType(ProjectValue);
        /// <summary> Package. </summary>
        public static SsisObjectMetadataType Package { get; } = new SsisObjectMetadataType(PackageValue);
        /// <summary> Environment. </summary>
        public static SsisObjectMetadataType Environment { get; } = new SsisObjectMetadataType(EnvironmentValue);
        /// <summary> Determines if two <see cref="SsisObjectMetadataType"/> values are the same. </summary>
        public static bool operator ==(SsisObjectMetadataType left, SsisObjectMetadataType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SsisObjectMetadataType"/> values are not the same. </summary>
        public static bool operator !=(SsisObjectMetadataType left, SsisObjectMetadataType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SsisObjectMetadataType"/>. </summary>
        public static implicit operator SsisObjectMetadataType(string value) => new SsisObjectMetadataType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SsisObjectMetadataType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SsisObjectMetadataType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}