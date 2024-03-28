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

    public partial class GetCustomerCatalogItemsPricingInformationRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetCustomerCatalogItemsPricingInformationRequest class.
        /// </summary>
        public GetCustomerCatalogItemsPricingInformationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetCustomerCatalogItemsPricingInformationRequest class.
        /// </summary>
        public GetCustomerCatalogItemsPricingInformationRequest(IList<string> skus)
        {
            Skus = skus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skus")]
        public IList<string> Skus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Skus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Skus");
            }
        }
    }
}
