// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Sherweb.Apis.ServiceProvider.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Null for subscriptions that are not tied to a commitment
    /// </summary>
    public partial class SubscriptionCommitmentTerm
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionCommitmentTerm class.
        /// </summary>
        public SubscriptionCommitmentTerm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionCommitmentTerm class.
        /// </summary>
        /// <param name="type">Possible values include: 'Monthly', 'Annual',
        /// 'Biennial', 'Triennial'</param>
        /// <param name="termEndDate">The last day of the commitment
        /// term</param>
        public SubscriptionCommitmentTerm(string type = default(string), System.DateTime? termEndDate = default(System.DateTime?), SubscriptionRenewalConfiguration renewalConfiguration = default(SubscriptionRenewalConfiguration))
        {
            Type = type;
            TermEndDate = termEndDate;
            RenewalConfiguration = renewalConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Monthly', 'Annual',
        /// 'Biennial', 'Triennial'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the last day of the commitment term
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "termEndDate")]
        public System.DateTime? TermEndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "renewalConfiguration")]
        public SubscriptionRenewalConfiguration RenewalConfiguration { get; set; }

    }
}