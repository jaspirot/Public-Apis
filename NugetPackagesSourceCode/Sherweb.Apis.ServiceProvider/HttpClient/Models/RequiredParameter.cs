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

    public partial class RequiredParameter
    {
        /// <summary>
        /// Initializes a new instance of the RequiredParameter class.
        /// </summary>
        public RequiredParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequiredParameter class.
        /// </summary>
        public RequiredParameter(string identifier, string value = default(string))
        {
            Identifier = identifier;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identifier");
            }
        }
    }
}
