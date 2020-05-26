using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    /// <summary>
    /// Query builder for the "Raw" endpoint.
    /// </summary>
    public class RawBuilder : TelemetryParametersBuilderBase<RawResponse>
    {
        /// <inheritdoc />
        protected override string Endpoint { get; set; } = "raw";

        /// <summary>
        /// Initializes a new instance of the <see cref="RawBuilder"/> class.
        /// </summary>
        /// <param name="httpClient">HTTP client which will be used to communication with the API.</param>
        /// <param name="company">Company name for which requested data belongs.</param>
        public RawBuilder(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }
    }
}