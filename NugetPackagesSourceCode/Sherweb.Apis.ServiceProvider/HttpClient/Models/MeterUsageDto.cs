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

    public partial class MeterUsageDto
    {
        /// <summary>
        /// Initializes a new instance of the MeterUsageDto class.
        /// </summary>
        public MeterUsageDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MeterUsageDto class.
        /// </summary>
        public MeterUsageDto(string meterId, long totalQuantities, long consumedQuantities, long availableQuantities)
        {
            MeterId = meterId;
            TotalQuantities = totalQuantities;
            ConsumedQuantities = consumedQuantities;
            AvailableQuantities = availableQuantities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "meterId")]
        public string MeterId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalQuantities")]
        public long TotalQuantities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "consumedQuantities")]
        public long ConsumedQuantities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "availableQuantities")]
        public long AvailableQuantities { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MeterId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MeterId");
            }
        }
    }
}
