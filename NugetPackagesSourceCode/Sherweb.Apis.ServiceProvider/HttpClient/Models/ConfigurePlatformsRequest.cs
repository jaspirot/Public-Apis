// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Sherweb.Apis.ServiceProvider.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ConfigurePlatformsRequest
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurePlatformsRequest class.
        /// </summary>
        public ConfigurePlatformsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurePlatformsRequest class.
        /// </summary>
        public ConfigurePlatformsRequest(IList<PlatformConfiguration> platformConfigurations)
        {
            PlatformConfigurations = platformConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "platformConfigurations")]
        public IList<PlatformConfiguration> PlatformConfigurations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PlatformConfigurations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PlatformConfigurations");
            }
            if (PlatformConfigurations != null)
            {
                foreach (var element in PlatformConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}