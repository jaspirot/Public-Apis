// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Sherweb.Apis.ServiceProvider.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubscriptionsCancellation
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionsCancellation class.
        /// </summary>
        public SubscriptionsCancellation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionsCancellation class.
        /// </summary>
        public SubscriptionsCancellation(System.Guid subscriptionsCancellationId, TrackingId trackingId)
        {
            SubscriptionsCancellationId = subscriptionsCancellationId;
            TrackingId = trackingId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionsCancellationId")]
        public System.Guid SubscriptionsCancellationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "trackingId")]
        public TrackingId TrackingId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TrackingId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TrackingId");
            }
            if (TrackingId != null)
            {
                TrackingId.Validate();
            }
        }
    }
}
