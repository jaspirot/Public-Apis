// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Sherweb.Apis.ServiceProvider
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IServiceProviderService : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// GetCustomerCatalog (beta)
        /// </summary>
        /// <param name='customerId'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CustomerCatalog>> GetCustomerCatalogWithHttpMessagesAsync(System.Guid customerId, string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetCustomerCatalogItemsPricingInformation (beta)
        /// </summary>
        /// <param name='customerId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CustomerCatalogItemsPricingInformationDto>> GetCustomerCatalogItemsPricingInformationWithHttpMessagesAsync(System.Guid customerId, GetCustomerCatalogItemsPricingInformationRequest body = default(GetCustomerCatalogItemsPricingInformationRequest), string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetCustomerPlatformsConfigurations (beta)
        /// </summary>
        /// <remarks>
        /// Get the list of all configured platforms for a customer.
        /// </remarks>
        /// <param name='customerId'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CustomerConfiguredPlatforms>> GetCustomerPlatformsConfigurationsWithHttpMessagesAsync(System.Guid customerId, string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// ConfigurePlatforms (beta)
        /// </summary>
        /// <remarks>
        /// Configure platforms required parameters.
        /// </remarks>
        /// <param name='customerId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ConfigurePlatformsWithHttpMessagesAsync(System.Guid customerId, ConfigurePlatformsRequest body = default(ConfigurePlatformsRequest), string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetCustomers (beta)
        /// </summary>
        /// <remarks>
        /// Get the list of all your customers.
        /// </remarks>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Customers>> GetCustomersWithHttpMessagesAsync(string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetAllPlatforms (beta)
        /// </summary>
        /// <remarks>
        /// Get the list of all available platforms.
        /// </remarks>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PlatformsCollection>> GetAllPlatformsWithHttpMessagesAsync(string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetPlatformsForSkus (beta)
        /// </summary>
        /// <remarks>
        /// Get the list of all platforms associated to the provided Skus.
        /// Specifying multiple language tags in Accept-Language header will
        /// generate translations for each of them.
        /// CultureInfo.InvariantCulture ("iv") is used as a fallback when
        /// language tags were not provided or not supported.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PlatformsForSkusCollection>> GetPlatformsForSkusWithHttpMessagesAsync(GetPlatformsForSkusRequest body = default(GetPlatformsForSkusRequest), string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetPlatformRequiredParameters (beta)
        /// </summary>
        /// <remarks>
        /// Get the list of required parameters for selected platforms.
        /// Specifying multiple language tags in Accept-Language header will
        /// generate translations for each of them.
        /// CultureInfo.InvariantCulture ("iv") is used as a fallback when
        /// language tags were not provided or not supported.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PlatformRequiredParametersCollection>> GetPlatformRequiredParametersWithHttpMessagesAsync(GetPlatformRequiredParametersRequest body = default(GetPlatformRequiredParametersRequest), string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetReceivableCharges (beta)
        /// </summary>
        /// <remarks>
        /// Get the amounts that one of your customers owe you for a specific
        /// billing period. There are three types of charges that are included
        /// in the data returned: recurring, usage, and setup.
        /// &lt;div
        /// style="color:#FF9B00;background-color:#FCF8E3;padding:1rem;border-radius:5px;border:1px
        /// solid #FF9B00;display:inline-block"&gt;&lt;svg width="16"
        /// height="16" fill="currentColor" viewBox="0 0 16 16"&gt;&lt;path
        /// d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091
        /// 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8
        /// 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1
        /// 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"
        /// /&gt;&lt;/svg&gt;
        /// For the time being, you cannot use the Service Provider API
        /// rebilling feature (&lt;i&gt;GetReceivableCharges&lt;/i&gt;
        /// endpoint) while having a PSA integration enabled.
        /// &lt;/div&gt;
        /// </remarks>
        /// <param name='customerId'>
        /// </param>
        /// <param name='date'>
        /// Specify a date within the desired billing period. Format:
        /// yyyy-MM-dd (UTC). Default: Today. For example, if the date is March
        /// 17th and your billing period is from the 1st to the 31st of the
        /// month, it will return data from March 1st to March 31st.
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ReceivableCharges>> GetReceivableChargesWithHttpMessagesAsync(System.Guid customerId, System.DateTime? date = default(System.DateTime?), string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetSubscriptions (beta)
        /// </summary>
        /// <remarks>
        /// Get the list of subscriptions for one of your customers.
        /// </remarks>
        /// <param name='customerId'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Subscriptions>> GetCustomerSubscriptionsWithHttpMessagesAsync(System.Guid customerId, string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CreateSubscriptionsAmendment (beta)
        /// </summary>
        /// <remarks>
        /// Amend subscription quantities for one of your customers.
        /// </remarks>
        /// <param name='customerId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SubscriptionsAmendment>> CreateSubscriptionsAmendmentWithHttpMessagesAsync(System.Guid customerId, CreateSubscriptionsAmendmentParameters body = default(CreateSubscriptionsAmendmentParameters), string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CancelSubscriptions (beta)
        /// </summary>
        /// <remarks>
        /// Cancel subscriptions for one of your customers.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='customerId'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SubscriptionsCancellation>> CancelSubscriptionsWithHttpMessagesAsync(SubscriptionsCancellationRequest body, System.Guid customerId, string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetSubscriptionsAmendmentStatus (beta)
        /// </summary>
        /// <remarks>
        /// Get the status of a subscriptions amendment.
        /// </remarks>
        /// <param name='subscriptionsAmendmentId'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> GetSubscriptionsAmendmentStatusWithHttpMessagesAsync(System.Guid subscriptionsAmendmentId, string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// GetSubscriptionsCancellationStatus (beta)
        /// </summary>
        /// <remarks>
        /// Get the status of a subscriptions cancellation.
        /// </remarks>
        /// <param name='subscriptionsCancellationId'>
        /// </param>
        /// <param name='acceptLanguage'>
        /// Specify language (and culture) following [RFC 7231, section 5.3.5:
        /// Accept-Language].
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> GetSubscriptionsCancellationStatusWithHttpMessagesAsync(System.Guid subscriptionsCancellationId, string acceptLanguage = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
