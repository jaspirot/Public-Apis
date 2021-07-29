// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Sherweb.Apis.ServiceProvider
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceProvidingPublicApiClient.
    /// </summary>
    public static partial class ServiceProvidingPublicApiClientExtensions
    {
            /// <summary>
            /// GetCustomers (beta)
            /// </summary>
            /// <remarks>
            /// Get the list of all your customers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceProviderId'>
            /// </param>
            /// <param name='acceptLanguage'>
            /// Specify language (and culture) following [RFC 7231, section 5.3.5:
            /// Accept-Language].
            /// </param>
            public static Customers GetCustomers(this IServiceProvidingPublicApiClient operations, System.Guid serviceProviderId, string acceptLanguage = default(string))
            {
                return operations.GetCustomersAsync(serviceProviderId, acceptLanguage).GetAwaiter().GetResult();
            }

            /// <summary>
            /// GetCustomers (beta)
            /// </summary>
            /// <remarks>
            /// Get the list of all your customers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceProviderId'>
            /// </param>
            /// <param name='acceptLanguage'>
            /// Specify language (and culture) following [RFC 7231, section 5.3.5:
            /// Accept-Language].
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Customers> GetCustomersAsync(this IServiceProvidingPublicApiClient operations, System.Guid serviceProviderId, string acceptLanguage = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCustomersWithHttpMessagesAsync(serviceProviderId, acceptLanguage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// GetReceivableCharges (beta)
            /// </summary>
            /// <remarks>
            /// Get the amounts that one of your customers owe you for a specific billing
            /// period. There are three types of charges that are included in the data
            /// returned: recurring, usage, and setup.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceProviderId'>
            /// </param>
            /// <param name='customerId'>
            /// </param>
            /// <param name='date'>
            /// Specify a date within the desired billing period. Format: yyyy-MM-dd (UTC).
            /// Default: Today. For example, if the date is March 17th and your billing
            /// period is from the 1st to the 31st of the month, it will return data from
            /// March 1st to March 31st.
            /// </param>
            /// <param name='acceptLanguage'>
            /// Specify language (and culture) following [RFC 7231, section 5.3.5:
            /// Accept-Language].
            /// </param>
            public static ReceivableCharges GetReceivableCharges(this IServiceProvidingPublicApiClient operations, System.Guid serviceProviderId, System.Guid customerId, System.DateTime? date = default(System.DateTime?), string acceptLanguage = default(string))
            {
                return operations.GetReceivableChargesAsync(serviceProviderId, customerId, date, acceptLanguage).GetAwaiter().GetResult();
            }

            /// <summary>
            /// GetReceivableCharges (beta)
            /// </summary>
            /// <remarks>
            /// Get the amounts that one of your customers owe you for a specific billing
            /// period. There are three types of charges that are included in the data
            /// returned: recurring, usage, and setup.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceProviderId'>
            /// </param>
            /// <param name='customerId'>
            /// </param>
            /// <param name='date'>
            /// Specify a date within the desired billing period. Format: yyyy-MM-dd (UTC).
            /// Default: Today. For example, if the date is March 17th and your billing
            /// period is from the 1st to the 31st of the month, it will return data from
            /// March 1st to March 31st.
            /// </param>
            /// <param name='acceptLanguage'>
            /// Specify language (and culture) following [RFC 7231, section 5.3.5:
            /// Accept-Language].
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReceivableCharges> GetReceivableChargesAsync(this IServiceProvidingPublicApiClient operations, System.Guid serviceProviderId, System.Guid customerId, System.DateTime? date = default(System.DateTime?), string acceptLanguage = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReceivableChargesWithHttpMessagesAsync(serviceProviderId, customerId, date, acceptLanguage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

