using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    /// <summary>
    /// Query builder for the "Launches" endpoint.
    /// </summary>
    public class LaunchesBuilder : TelemetryParametersBuilderBase<LaunchesResponse>
    {
        /// <inheritdoc />
        protected override string Endpoint { get; set; } = "launches";

        /// <summary>
        /// Initializes a new instance of the <see cref="LaunchesBuilder"/> class.
        /// </summary>
        /// <param name="httpClient">HTTP client which will be used to communication with the API.</param>
        /// <param name="company">Company name for which requested data belongs.</param>
        public LaunchesBuilder(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }
    }
}