// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error diagnostic information for failed jobs.
    /// </summary>
    public partial class Diagnostics
    {
        /// <summary>
        /// Initializes a new instance of the Diagnostics class.
        /// </summary>
        public Diagnostics() { }

        /// <summary>
        /// Initializes a new instance of the Diagnostics class.
        /// </summary>
        /// <param name="columnNumber">the column where the error
        /// occured.</param>
        /// <param name="end">the ending index of the error.</param>
        /// <param name="lineNumber">the line number the error occured
        /// on.</param>
        /// <param name="message">the error message.</param>
        /// <param name="severity">the severity of the error. Possible values
        /// include: 'Warning', 'Error', 'Info'</param>
        /// <param name="start">the starting index of the error.</param>
        public Diagnostics(int? columnNumber = default(int?), int? end = default(int?), int? lineNumber = default(int?), string message = default(string), SeverityTypes? severity = default(SeverityTypes?), int? start = default(int?))
        {
            ColumnNumber = columnNumber;
            End = end;
            LineNumber = lineNumber;
            Message = message;
            Severity = severity;
            Start = start;
        }

        /// <summary>
        /// Gets the column where the error occured.
        /// </summary>
        [JsonProperty(PropertyName = "columnNumber")]
        public int? ColumnNumber { get; protected set; }

        /// <summary>
        /// Gets the ending index of the error.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public int? End { get; protected set; }

        /// <summary>
        /// Gets the line number the error occured on.
        /// </summary>
        [JsonProperty(PropertyName = "lineNumber")]
        public int? LineNumber { get; protected set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; protected set; }

        /// <summary>
        /// Gets the severity of the error. Possible values include: 'Warning',
        /// 'Error', 'Info'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public SeverityTypes? Severity { get; protected set; }

        /// <summary>
        /// Gets the starting index of the error.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public int? Start { get; protected set; }

    }
}

