// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Sherweb.Apis.ServiceProvider.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SkusNotFoundProblemDetails
    {
        /// <summary>
        /// Initializes a new instance of the SkusNotFoundProblemDetails class.
        /// </summary>
        public SkusNotFoundProblemDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkusNotFoundProblemDetails class.
        /// </summary>
        /// <param name="type">A URI reference [RFC3986] that identifies the
        /// problem type. This specification encourages that, when
        /// dereferenced, it provides human-readable documentation for the
        /// problem type (e.g., using HTML [W3C.REC-html5-20141028]).
        /// When this member is not present, its value is assumed to be
        /// "about:blank".</param>
        /// <param name="title">A short, human-readable summary of the problem
        /// type. It SHOULD NOT change from occurrence to occurrence
        /// of the problem, except for purposes of localization(e.g., using
        /// proactive content negotiation; see[RFC7231], Section 3.4).</param>
        /// <param name="status">The HTTP status code([RFC7231], Section 6)
        /// generated by the origin server for this occurrence of the
        /// problem.</param>
        /// <param name="detail">A human-readable explanation specific to this
        /// occurrence of the problem.</param>
        /// <param name="instance">A URI reference that identifies the specific
        /// occurrence of the problem. It may or may not yield further
        /// information if dereferenced.</param>
        /// <param name="extensions">Gets the
        /// System.Collections.Generic.IDictionary`2 for extension members.
        ///
        ///
        /// Problem type definitions MAY extend the problem details object with
        /// additional members.
        /// Extension members appear in the same namespace as other members of
        /// a problem type.
        /// </param>
        public SkusNotFoundProblemDetails(string type = default(string), string title = default(string), int? status = default(int?), string detail = default(string), string instance = default(string), IDictionary<string, object> extensions = default(IDictionary<string, object>))
        {
            Type = type;
            Title = title;
            Status = status;
            Detail = detail;
            Instance = instance;
            Extensions = extensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a URI reference [RFC3986] that identifies the problem
        /// type. This specification encourages that, when
        /// dereferenced, it provides human-readable documentation for the
        /// problem type (e.g., using HTML [W3C.REC-html5-20141028]).
        /// When this member is not present, its value is assumed to be
        /// "about:blank".
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a short, human-readable summary of the problem type.
        /// It SHOULD NOT change from occurrence to occurrence
        /// of the problem, except for purposes of localization(e.g., using
        /// proactive content negotiation; see[RFC7231], Section 3.4).
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code([RFC7231], Section 6) generated
        /// by the origin server for this occurrence of the problem.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets a human-readable explanation specific to this
        /// occurrence of the problem.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets a URI reference that identifies the specific
        /// occurrence of the problem. It may or may not yield further
        /// information if dereferenced.
        /// </summary>
        [JsonProperty(PropertyName = "instance")]
        public string Instance { get; set; }

        /// <summary>
        /// Gets the System.Collections.Generic.IDictionary`2 for extension
        /// members.
        ///
        ///
        /// Problem type definitions MAY extend the problem details object with
        /// additional members.
        /// Extension members appear in the same namespace as other members of
        /// a problem type.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IDictionary<string, object> Extensions { get; set; }

    }
}
