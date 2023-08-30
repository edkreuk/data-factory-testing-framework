// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The UnknownActivity. </summary>
    internal partial class UnknownActivity : PipelineActivity
    {
        /// <summary> Initializes a new instance of UnknownActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            ActivityType = activityType ?? "Unknown";
        }
    }
}