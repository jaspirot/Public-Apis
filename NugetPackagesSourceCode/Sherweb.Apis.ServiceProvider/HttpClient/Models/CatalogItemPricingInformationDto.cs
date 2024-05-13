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

    public partial class CatalogItemPricingInformationDto
    {
        /// <summary>
        /// Initializes a new instance of the CatalogItemPricingInformationDto
        /// class.
        /// </summary>
        public CatalogItemPricingInformationDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CatalogItemPricingInformationDto
        /// class.
        /// </summary>
        public CatalogItemPricingInformationDto(string sku, PricingInformationDto pricingInformation)
        {
            Sku = sku;
            PricingInformation = pricingInformation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingInformation")]
        public PricingInformationDto PricingInformation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (PricingInformation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PricingInformation");
            }
            if (PricingInformation != null)
            {
                PricingInformation.Validate();
            }
        }
    }
}
